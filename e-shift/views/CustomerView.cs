﻿using e_shift.controller;
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
    public partial class CustomerView : Form
    {
        private bool _isUpdate = false;

        public CustomerView()
        {
            InitializeComponent();

            //load data to the grid
            LoadCustomerData();
            //load latest id
            SetCustomerID();
            //default resets
            ConductDefaultResets();
            //set values to search compbo
            SetValueToSearchCombo();
        }

        public void SetValueToSearchCombo() {


            ComboBoxItem firstNameItem = new ComboBoxItem();
            firstNameItem.Text = "First Name";
            firstNameItem.Value = "firstname";

            ComboBoxItem lstNameItem = new ComboBoxItem();
            lstNameItem.Text = "Last Name";
            lstNameItem.Value = "lastname";

            ComboBoxItem nicItem = new ComboBoxItem();
            nicItem.Text = "NIC";
            nicItem.Value = "nic";

            searchCombo.Items.Add(firstNameItem);
            searchCombo.Items.Add(lstNameItem);
            searchCombo.Items.Add(nicItem);
            
            searchCombo.SelectedIndex = 0;
        }

        //Get the values from the controller and set to the datagrid
        public void LoadCustomerData() {
            try
            {
                //set values to the data grid
                customerDataGridView.DataSource = new CustomerController().GetAllCustomers();

                ChangeHeaderNames();
                
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        private void ChangeHeaderNames()
        {
            customerDataGridView.Columns[0].HeaderText = "ID";
            customerDataGridView.Columns[1].HeaderText = "First Name";
            customerDataGridView.Columns[2].HeaderText = "Last Name";
            customerDataGridView.Columns[3].HeaderText = "NIC";
            customerDataGridView.Columns[4].HeaderText = "Address";
            customerDataGridView.Columns[5].HeaderText = "Contact Number";
        }

        public void SetCustomerID()
        {
            try
            {
                //set values to the data grid
                string custId = new CustomerController().GetCustId();
                lblCustId.Text = custId;
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /*Handle Submit Button click*/
        private void btnSubmit_onClick(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string nic = txtNic.Text;
            string address = txtAddress.Text;
            string conactNumber = txtContactNumber.Text;


            try
            {
                //Initialize dto with a builder
                CustomerDto customerDto = CustomerDto.Builder()
                        .WithFirstName(firstName).WithLastName(lastName)
                        .WithNic(nic).WithAddress(address).WithContactNumber(conactNumber).Build();

                bool isSuccess;

                if (!this._isUpdate) {
                    isSuccess = new CustomerController().SaveCustomer(customerDto);
                } else {
                    isSuccess = new CustomerController().UpdateCustomer(customerDto, lblCustId.Text);
                }

                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(!this._isUpdate ? Constants.SUCCESSFULLY_CREATED
                        : Constants.SUCCESSFULLY_UPDATED, Constants.CUSTOMER));

                    LoadCustomerData();
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
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNic.Text = "";
            txtAddress.Text = "";
            txtContactNumber.Text = "";

            //generae custId
            SetCustomerID();


            ConductDefaultResets();

        }

        private void ConductDefaultResets() {

            //change button txt and flag
            btnSubmit.Text = "Create";
            this._isUpdate = false;

            //disable delete btn
            btnDelete.Enabled = false;
            customerDataGridView.ClearSelection();

            txtSearch.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {

            
            btnSubmit.Text = "Update";
            this._isUpdate = true;

            btnDelete.Enabled = true;
            


            int selectedRowCount = customerDataGridView
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount)
            {
               
                string? custId = customerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string? firstName = customerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string? lastName = customerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string? nic = customerDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string? address = customerDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string? contactNumber = customerDataGridView.SelectedRows[0].Cells[5].Value.ToString();


                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;
                txtNic.Text = nic;
                txtAddress.Text = address;
                txtContactNumber.Text = contactNumber;

                lblCustId.Text = custId;
            }
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = new CustomerController().DeleteCustomer(lblCustId.Text);


                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_DELETED, Constants.CUSTOMER));
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }

                LoadCustomerData();
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

            DataTable dataTable = new CustomerController().SearchCustomers(type, text);

            customerDataGridView.DataSource = dataTable;

            ChangeHeaderNames();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}  
