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
    public partial class JobView : Form
    {
        private bool _isDelete = false;
        private string _selectedItem;
        private Customer _loggdUser;

        private BindingList<JobItemDto> _itemNameList = new BindingList<JobItemDto>();

        public JobView(Customer customer)
        {
            _loggdUser = customer;
            
            InitializeComponent();

            //load latest id
            SetJobId();
            //default resets
            ConductDefaultResets();
            //set values to search compbo
            SetValueToSearchCombo();
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
            gridJob.Columns[0].HeaderText = "Item ID";
            gridJob.Columns[1].HeaderText = "Item Name";
            gridJob.Columns[2].HeaderText = "Remark";
        }

        /**
         * Retrieve a new job id from the database
         */
        private void SetJobId()
        {
            try
            {

                lblJobId.Text = new JobController().GetJobId();
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
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
                //Initialize dto with a builder
                var jobDto = JobDto.Builder().WithRequiredDate(date)
                    .WithCustId(_loggdUser.Cid)
                    .WithJobId(lblJobId.Text)
                    .WithRemark(remark).WithLocation(location).Build();

                jobDto.ItemNameList = this._itemNameList;

                bool isSuccess = new JobController().CreateJob(jobDto);

                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_CREATED, Constants.JOB));
                }
                else {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }

                this.ClearFields();
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

            //generae custId
            SetJobId();
            
            ConductDefaultResets();
            
            //clear the recording in the table
            ClearItemList();
        }

        private void ClearItemList()
        {
            _itemNameList.Clear();
        }

        private void ConductDefaultResets() {

            //change button txt and flag
            btnSubmit.Text = "Create";
            this._isDelete = false;

            //disable delete btn
            btnDelete.Visible = false;
            gridJob.ClearSelection();

        }

       

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {

            
            btnAddItem.Visible = true;
            this._isDelete = true;

            

            int selectedRowCount = gridJob
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount && null != gridJob.SelectedRows[0].Cells[0])
            {
                btnDelete.Visible = true;
                this._selectedItem = gridJob.SelectedRows[0].Cells[0].Value.ToString();

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

            gridJob.DataSource = _itemNameList;
            gridJob.Refresh();

        }

        private void Btn_Add_Item(object sender, EventArgs e)
        {
            try
            {
                var itemName = comboItem.Text;
                var qty = int.Parse(txtQty.Text);

                var jobItemDto = JobItemDto.Builder()
                    .WithQty(qty).WithItemName(itemName).Build();

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
            gridJob.DataSource = _itemNameList;
            gridJob.Refresh();
        }
    }
}  
