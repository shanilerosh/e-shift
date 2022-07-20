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
    public partial class CustomerDashBoard : Form
    {
        private CustomerDto _customerDto;

        public CustomerDashBoard(CustomerDto customerDto)
        {
            _customerDto = customerDto;
            InitializeComponent();

            SetValuesToThePanels();

        }

        private void SetValuesToThePanels()
        {
            try
            {
                var acceptedCount = new JobController().FetchAcceptedJobData(_customerDto.Cid).Rows.Count.ToString();
                var declinedCount = new JobController().FetchDeclinedJobData(_customerDto.Cid).Rows.Count.ToString();
                var pending = new JobController().FetchPendingJobData(_customerDto.Cid).Rows.Count.ToString();
                var completed = new JobController().FetchCompletedJobData(_customerDto.Cid).Rows.Count.ToString();


                lblAcceptedJobs.Text = acceptedCount;
                lblDiscardedJobs.Text = declinedCount;
                lblPendingJobs.Text = pending;
                lblJobsToday.Text = completed;
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
