using e_shift.controller;
using e_shift.dto;
using e_shift.utility;
using System;
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
        private bool _isUpdate = false;

        public ItemView()
        {
            InitializeComponent();

            //load data to the grid
            LoanItemData();
            //load latest id
            SetItemId();
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



            searchCombo.Items.Add(itemName);
            searchCombo.Items.Add(remark);
            searchCombo.Items.Add(itemId);
            
            searchCombo.SelectedIndex = 0;
        }





        //Get the values from the controller and set to the datagrid
        public void LoanItemData() {
            try
            {
                //set values to the data grid
                gridItems.DataSource = new ItemController().GetAllItems();

                ChangeHeaderNames();
                
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        private void ChangeHeaderNames()
        {
            gridItems.Columns[0].HeaderText = "Item ID";
            gridItems.Columns[1].HeaderText = "Item Name";
            gridItems.Columns[2].HeaderText = "Remark";
        }

        public void SetItemId()
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

            string itemName = txtItemName.Text;
            string reamrk= txtRemark.Text;

            
            try
            {
                //Initialize dto with a builder
                var itemDto = ItemDto.Builder().WithItemName(itemName)
                    .WithRemark(reamrk).Build();

                bool isSuccess;

                if (!this._isUpdate) {
                    isSuccess = new ItemController().SaveItem(itemDto);
                } else {
                    isSuccess = new ItemController().UpdateItem(itemDto, lblItemId.Text);
                }

                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(!this._isUpdate ? Constants.SUCCESSFULLY_CREATED
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
            
            txtItemName.Text = "";
            txtRemark.Text = "";

            //generae custId
            SetItemId();


            ConductDefaultResets();

        }

        private void ConductDefaultResets() {

            //change button txt and flag
            btnSubmit.Text = "Create";
            this._isUpdate = false;

            //disable delete btn
            btnDelete.Enabled = false;
            gridItems.ClearSelection();

            txtSearch.Text = "";
        }

       

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {

            
            btnSubmit.Text = "Update";
            this._isUpdate = true;

            btnDelete.Enabled = true;
            


            int selectedRowCount = gridItems
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount)
            {
               
                string? iid = gridItems.SelectedRows[0].Cells[0].Value.ToString();
                string? itemName = gridItems.SelectedRows[0].Cells[1].Value.ToString();
                string? remark = gridItems.SelectedRows[0].Cells[2].Value.ToString();


                txtItemName.Text = itemName;
                txtRemark.Text = remark;

                lblItemId.Text = iid;
            }
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = new ItemController().DeleteItem(lblItemId.Text);


                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_DELETED, Constants.ITEM));
                    LoanItemData();
                }
                else
                {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }

                LoanItemData();
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }

            this.ClearFields();
        }

        private void txtsearch_Change(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            string type = ((ComboBoxItem) searchCombo.SelectedItem).Value;

            DataTable dataTable = new ItemController().SearchItem(type, text);

            gridItems.DataSource = dataTable;

            ChangeHeaderNames();
        }

    }
}  
