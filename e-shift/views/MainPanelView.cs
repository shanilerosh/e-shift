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
using e_shift.controller;

namespace e_shift.views
{
    public partial class MainPanelView : Form
    {
        private UserDto _userDetail;
        private CustomerDto _customer;
        
        public MainPanelView(UserDto userDto)
        {
            this._userDetail = userDto;  
            InitializeComponent();
            SetDefaultResets();
            SetPriviladges();
            SetUserData();          
        }

        private void SetDefaultResets()
        {
            panelMainCustomer.Hide();
        }

        private void SetUserData()
        {
            try
            {
                lblUserName.Text = _userDetail.Username;


                if (_userDetail.Role == Role.CUSTOMER)
                {
                    _customer = new CustomerController()
                        .findCustomerByUserId(_userDetail.Uid);
                    
                    panelMainCustomer.Show();

                    CustomerDashBoardView();
                }
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

        private void SetPriviladges()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged==="+this._userDetail.Username);
        }

        private void MainPanelView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.TopLevel = false;
            panelMain.Controls.Add(customerView);
            customerView.BringToFront();
            customerView.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Main_Job_Click_Handle(object sender, EventArgs e)
        {
            
        }

        private void Btn_Cust_Job_Panel_Click(object sender, EventArgs e)
        {
            var jobContainer = new JobContainer(_customer);
            jobContainer.TopLevel = false;
            panelMain.Controls.Add(jobContainer);
            jobContainer.BringToFront();
            jobContainer.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Customer_DashBoard_Click(object sender, EventArgs e)
        {
            CustomerDashBoardView();

        }

        private void CustomerDashBoardView() {

            var customerDashBoard = new CustomerDashBoard(_customer);
            customerDashBoard.TopLevel = false;
            panelMain.Controls.Add(customerDashBoard);
            customerDashBoard.BringToFront();
            customerDashBoard.Show();
        }

        private void Manage_Customer_Btn_Click(object sender, EventArgs e)
        {
            var customerUpdate = new CustomerUpdateView(_customer);
            customerUpdate.TopLevel = false;
            panelMain.Controls.Add(customerUpdate);
            customerUpdate.BringToFront();
            customerUpdate.Show();
        }
    }

}
