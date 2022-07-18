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

        private BindingList<JobItemDto> _itemNameList = new BindingList<JobItemDto>();

        public JobView(Customer customer)
        {
            InitializeComponent();

            //load latest id
            SetJobId();
            //default resets
            ConductDefaultResets();
            //set values to search compbo
            SetValueToSearchCombo();
        }

        public void SetValueToSearchCombo() {


            ComboBoxItem itemName = new ComboBoxItem();
            itemName.Text = "Item Name";
            itemName.Value = "itemName";

            ComboBoxItem itemId = new ComboBoxItem();
            itemId.Text = "Item ID";
            itemId.Value = "iid";

            ComboBoxItem remark = new ComboBoxItem();
            remark.Text = "Remark";
            remark.Value = "remark";



            comboItem.Items.Add(itemName); 
            comboItem.Items.Add(itemId); 
            comboItem.Items.Add(remark); 
        }





        //Get the values from the controller and set to the datagrid
        public void LoanItemData() {
            try
            {
                //set values to the data grid
                gridJob.DataSource = new ItemController().GetAllItems();

                ChangeHeaderNames();
                
            }
            catch (Exception)
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

        /// <summary>
        /// Generate unique job id for each job creation
        /// </summary>
        public void SetJobId()
        {
            try
            {
                //set values to the data grid
                string tid = new ItemController().GetItemId();
                lblItemId.Text = tid;
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

            string itemName = txtLocation.Text;
            string reamrk= txtRemark.Text;
            DateTime date = datePickerRequiredDate.Value.Date;

            
            try
            {
                //Initialize dto with a builder
                var itemDto = ItemDto.Builder().WithItemName(itemName)
                    .WithRemark(reamrk).Build();

                bool isSuccess;

                if (!this._isDelete) {
                    isSuccess = new ItemController().SaveItem(itemDto);
                } else {
                    isSuccess = new ItemController().UpdateItem(itemDto, lblItemId.Text);
                }

                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(!this._isDelete ? Constants.SUCCESSFULLY_CREATED
                        : Constants.SUCCESSFULLY_UPDATED, Constants.ITEM));

                    LoanItemData();
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
                string itemName = comboItem.Text;
                int qty = Int32.Parse(txtQty.Text);

                var jobItemDto = JobItemDto.Builder()
                    .WithQty(qty).WithItemName(itemName).Build();

                AddItemToTheList(jobItemDto);
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
