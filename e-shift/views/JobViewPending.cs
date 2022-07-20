using e_shift.controller;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_shift.views
{
    public partial class JobViewPending : Form
    {
        private bool _isDelete = false;
        private string _selectedJob;
        private string _selectedItem;
        private CustomerDto _loggdUser;

        private BindingList<JobItemDto> _itemNameList;

        public JobViewPending(CustomerDto customer)
        {
            _loggdUser = customer;
            
            InitializeComponent();

            //get pending data to table
            FetchPendingData();
            //default resets
            ConductDefaultResets();
            //set values to search compbo
            SetValueToSearchCombo();
        }

        /**
         * Fetch Pending Job Data and set to the pending grid
         */
        private void FetchPendingData()
        {
            try
            {
                var dt =new JobController().FetchPendingJobData(_loggdUser.Cid);
                gridPending.DataSource = dt;
            }
            catch (InvalidDataException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        private void SetValueToSearchCombo() {


            try
            {
                var dataTable = new ItemController().GetAllItems();

                foreach (DataRow item in dataTable.Rows) {
                    var comboItemType = new ComboBoxItem
                    {
                        Text = item["itemName"].ToString(),
                        Value = item["iid"].ToString()
                    };

                    comboItem.Items.Add(comboItemType);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Constants.SYSTEM_ERROR);
            }

        }

        private void ChangeHeaderNames()
        {
            itemsGrid.Columns[0].HeaderText = "Item ID";
            itemsGrid.Columns[1].HeaderText = "Item Name";
            itemsGrid.Columns[2].HeaderText = "Remark";
        }

        

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /*Handle Submit Button click*/
        private void btnSubmit_onClick(object sender, EventArgs e)
        {

            var location = txtLocation.Text;
            var remark= txtRemark.Text;
            var date = datePickerRequiredDate.Value.Date;

            
            try
            {
                
                Assert.IsEmptyCollection(_itemNameList, Constants.JOB_ERROR);
                
                //Initialize dto with a builder
                var jobDto = JobDto.Builder().WithRequiredDate(date)
                    .WithCustId(_loggdUser.Cid)
                    .WithJobId(lblJobId.Text)
                    .WithRemark(remark).WithLocation(location).Build();

                jobDto.ItemNameList = _itemNameList;

                bool isSuccess = new JobController().UpdateJob(jobDto, lblJobId.Text);

                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_UPDATED, Constants.JOB));
                }
                else {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }

                ConductDefaultResets();
            }
            //If data is invalid
            catch (InvalidDataException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
                this.ClearFields();
            }

        }

        /*Handle reset Button click*/
        private void btnReset_onClick(object sender, EventArgs e)
        {

            this.ClearFields();
            
        }

        /*Method to clear fields of the vie and load latestId*/
        private void ClearFields() {
            
            txtLocation.Text = "";
            txtRemark.Text = "";
            
            
            ConductDefaultResets();
            
            //clear the recording in the table
            ClearItemList();
        }

        private void ClearItemList()
        {
            _itemNameList.Clear();
        }

        private void ConductDefaultResets() {
            
            this._isDelete = false;

            //disable delete btn
            btnDelete.Visible = false;
            itemsGrid.ClearSelection();
            
            //hide update job
            btnUpdateJob.Hide();
            //hide item add panel & Form
            itemAddPanel.Hide();
            fromPanel.Hide();
            
        }

        private void ReverseResets()
        {
            lblJobId.Text = _selectedJob;
            btnUpdateJob.Show();
            itemAddPanel.Show();
            fromPanel.Show();

            try
            {
                var jobDto = new JobController().FetchJobDataWithItemsById(_selectedJob);
                _itemNameList = jobDto.ItemNameList;
                
                itemsGrid.DataSource = _itemNameList;
                itemsGrid.Refresh();

                txtLocation.Text = jobDto.Location;
                datePickerRequiredDate.Value = jobDto.RequiredDate;
                txtRemark.Text = jobDto.Remarks;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            int selectedRowCount = gridPending
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount && null != gridPending.SelectedRows[0].Cells[0])
            {
                
                this._selectedJob = gridPending.SelectedRows[0].Cells[0].Value.ToString();
                
                ReverseResets();

            }
        }

        /// <summary>
        /// Read the existing array list and filter out the user selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {


            List<JobItemDto> filteredList = _itemNameList
                .Where(obj => !obj.ItemName.Equals(_selectedItem)).ToList();

            this._itemNameList = new BindingList<JobItemDto>(filteredList);

            itemsGrid.DataSource = _itemNameList;
            itemsGrid.Refresh();

        }

        private void Btn_Add_Item(object sender, EventArgs e)
        {
            try
            {
                var itemName = comboItem.Text;

                var jobItemDto = JobItemDto.Builder()
                    .WithQty(txtQty.Text).WithItemName(itemName).Build();

                AddItemToTheList(jobItemDto);
                
                //clear items selected
                txtQty.Text = "";
            }
            //If data is invalid
            catch (InvalidDataException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
                this.ClearFields();
            }
        }

        private void AddItemToTheList(JobItemDto jobItemDto) {


            bool isExistFlag = false;


            foreach (var obj in _itemNameList)
            {
                //if record already exist replace the qty
                if (obj.ItemName.Equals(jobItemDto.ItemName))
                {
                    obj.Qty += jobItemDto.Qty;
                    isExistFlag = true;
                    break;
                }
            }

            if (!isExistFlag) { 
                _itemNameList.Add(jobItemDto);
            }


            //bind to the data source
            itemsGrid.DataSource = _itemNameList;
            itemsGrid.Refresh();
        }

        private void JobView_Load(object sender, EventArgs e)
        {

        }

        private void datePickerRequiredDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Items_Mouse_Click_Handle(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowCount = itemsGrid
                .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount && null != itemsGrid.SelectedRows[0].Cells[0])
            {
                
                _selectedItem = itemsGrid.SelectedRows[0].Cells[0].Value.ToString();
                

            }
            
            btnDelete.Show();
        }
    }
}  
