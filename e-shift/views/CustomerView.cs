using e_shift.controller;
using e_shift.dto;
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

            var customerDto = 
                new CustomerDto(firstName, lastName, nic, address);

            bool isSuccess = new CustomerController().SaveCustomer(customerDto);
        }

        /*Handle reset Button click*/
        private void btnReset_onClick(object sender, EventArgs e)
        {

            this.ClearFields();
        }

        /*Method to clear fields of the view*/
        private void ClearFields() {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNic.Text = "";
            txtAddress.Text = "";

        }
    }
}
