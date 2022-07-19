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
            SetPriviladges();
            SetUserData();
        }

        private void SetUserData()
        {
            try
            {
                if (_userDetail.Role == Role.CUSTOMER)
                {
                    _customer = new CustomerController()
                        .findCustomerByUserId(_userDetail.Uid);
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
            if (!Role.ADMIN.Equals(_userDetail.Role)) {
                btnOrder.Hide();
            }
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
            JobView jobView = new JobView(_customer);
            jobView.TopLevel = false;
            panelMain.Controls.Add(jobView);
            jobView.BringToFront();
            jobView.Show();
        }
    }

}
