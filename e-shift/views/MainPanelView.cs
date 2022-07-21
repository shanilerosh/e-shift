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
            SetUserData();          
        }


        private void SetUserData()
        {
            try
            {
                lblUserName.Text = _userDetail.Username;


                //check the type of user
                if (_userDetail.Role == Role.CUSTOMER)
                {
                    //if customer retrieve customer obj from fb
                    _customer = new CustomerController()
                        .FindCustomerByUserId(_userDetail.Uid);

                    CustomerPriviladges();

                    CustomerDashBoardView();
                }
                else {

                    //admin dashboard
                    AdminDashBoardView();
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

       
        private void CustomerPriviladges()
        {

            btnItemsMain.Hide();
            btnLoadMain.Hide();
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

 

            if (_userDetail.Role == Role.CUSTOMER)
            {
                var jobContainer = new JobContainer(_customer);
                jobContainer.TopLevel = false;
                panelMain.Controls.Add(jobContainer);
                jobContainer.BringToFront();
                jobContainer.Show();
            }
            else {
                var jobContainer = new AdminJobContainer(_userDetail);
                jobContainer.TopLevel = false;
                panelMain.Controls.Add(jobContainer);
                jobContainer.BringToFront();
                jobContainer.Show();
            } 

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Customer_DashBoard_Click(object sender, EventArgs e)
        {
            if (_userDetail.Role == Role.CUSTOMER)
            {
                CustomerDashBoardView();
            }
            else {
                AdminDashBoardView();
            }

            

        }

        private void CustomerDashBoardView() {

            var customerDashBoard = new CustomerDashBoard(_customer);
            customerDashBoard.TopLevel = false;
            panelMain.Controls.Add(customerDashBoard);
            customerDashBoard.BringToFront();
            customerDashBoard.Show();
        }

        private void AdminDashBoardView()
        {

            var adminDash = new AdminDashBoard();
            adminDash.TopLevel = false;
            panelMain.Controls.Add(adminDash);
            adminDash.BringToFront();
            adminDash.Show();
        }

        private void Manage_Customer_Btn_Click(object sender, EventArgs e)
        {

            if (_userDetail.Role == Role.CUSTOMER)
            {
                var customerUpdate = new CustomerUpdateView(_customer);
                customerUpdate.TopLevel = false;
                panelMain.Controls.Add(customerUpdate);
                customerUpdate.BringToFront();
                customerUpdate.Show();
            }else{
                var customerUpdate = new CustomerAdminView();
                customerUpdate.TopLevel = false;
                panelMain.Controls.Add(customerUpdate);
                customerUpdate.BringToFront();
                customerUpdate.Show();
            }
        }

        private void Btn_Item_Panel_Click(object sender, EventArgs e)
        {
            ItemView itemView = new ItemView();
            itemView.TopLevel = false;
            panelMain.Controls.Add(itemView);
            itemView.BringToFront();
            itemView.Show();
        }

        private void btnLoadMain_Click(object sender, EventArgs e)
        {
            AdminLoadContainer itemView = new AdminLoadContainer(_userDetail);
            itemView.TopLevel = false;
            panelMain.Controls.Add(itemView);
            itemView.BringToFront();
            itemView.Show();
        }
    }

}
