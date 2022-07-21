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
using e_shift.controller;
using e_shift.utility;

namespace e_shift.views
{
    public partial class AdminDashBoard : Form
    {
        private CustomerDto _customerDto;

        public AdminDashBoard()
        {
            InitializeComponent();

            SetValuesToThePanels();

        }

        private void SetValuesToThePanels()
        {
            try
            {
                var pending = new JobController().FetchAdminJobData(Status.PENDING).Rows.Count.ToString();
                var itemCount = new ItemController().GetAllItems().Rows.Count.ToString();
                var driverCount = new DriverController().fetchDrivers().Count.ToString();
                var custCount = new CustomerController().FetchCustomerByStatus(CustomerStatus.NOT_APPROVED).Rows.Count.ToString();
                
                


                lblPendingJobs.Text = pending;
                lblRegisteredItems.Text = itemCount;
                lblPendingCustomers.Text = custCount;
                lblDriverCount.Text = driverCount;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
