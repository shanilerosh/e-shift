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
    public partial class CustomerView : Form
    {

        public CustomerView()
        {
            InitializeComponent();

            
            //load latest id
            SetCustomerID();
            
        }

       

        /**
         * Set the generated Id to the view
         */
        public void SetCustomerID()
        {
            try
            {
                string custId = new CustomerController().GetCustId();
                lblCustId.Text = custId;
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

  

        /*Handle Submit Button click*/
        private void BtnSubmit_onClick(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string nic = txtNic.Text;
            string address = txtAddress.Text;
            string conactNumber = txtContactNumber.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;


            try
            {
                //Initialize dto with a builder
                CustomerDto customerDto = CustomerDto.Builder()
                        .WithFirstName(firstName).WithLastName(lastName)
                        .WithNic(nic).WithAddress(address).WithContactNumber(conactNumber)
                        .WithUserName(username).WithPassword(password)
                        .Build();

                bool isSuccess =  new CustomerController().SaveCustomer(customerDto);


                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_CREATED, Constants.CUSTOMER));
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
        private void BtnReset_onClick(object sender, EventArgs e)
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


        }

    }
}  
