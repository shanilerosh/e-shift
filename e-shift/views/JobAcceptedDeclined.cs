using e_shift.controller;
using e_shift.dto;
using e_shift.utility;
using System.ComponentModel;
using System.Data;

namespace e_shift.views
{
    public partial class JobAcceptedDeclined : Form
    {
        private bool _isDelete = false;
        private string _selectedJob;
        private string _selectedItem;
        private CustomerDto _loggdUser;

        private BindingList<JobItemDto> _itemNameList;
        private Status _status;

        public JobAcceptedDeclined(CustomerDto customer, Status status)
        {
            _loggdUser = customer;
            _status = status;

            InitializeComponent();

            //get accepted/declined data
            FetchAcceptedOrPendingData();
            //default resets
            ConductDefaultResets();
            
            ChangeHeaderNames();
            
        }

        /**
         * Fetch Pending Job Data and set to the pending grid
         */
        private void FetchAcceptedOrPendingData()
        {
            try
            {
                DataTable dt;

                //get accepted or declined data basing the view
                if (_status.Equals(Status.ACCEPTED))
                {
                    dt = new JobController().FetchAcceptedJobData(_loggdUser.Cid);
                }
                else
                {
                    dt = new JobController().FetchDeclinedJobData(_loggdUser.Cid);
                }


                gridPending.DataSource = dt;
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

        

        private void ChangeHeaderNames()
        {
            var heading = Status.ACCEPTED == _status
                ? "My Competed Jobs"
                : "My Declined Jobs";

            lblHeader.Text = heading;
        }

        

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /*Handle Submit Button click*/
        private void btnSubmit_onClick(object sender, EventArgs e)
        {

            var location = txtLocation.Text;
            var remark= txtRemark.Text;
            var date = datePickerRequiredDate.Value.Date;

            
            try
            {
                
                Assert.IsEmptyCollection(_itemNameList, Constants.JOB_ERROR);
                
                //Initialize dto with a builder
                var jobDto = JobDto.Builder().WithRequiredDate(date)
                    .WithCustId(_loggdUser.Cid)
                    .WithJobId(lblJobId.Text)   
                    .WithRemark(remark).WithLocation(location).Build();

                jobDto.ItemNameList = _itemNameList;

                bool isSuccess = new JobController().UpdateJob(jobDto, lblJobId.Text);

                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_UPDATED, Constants.JOB));
                }
                else {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }

                ConductDefaultResets();
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
            
            
            ConductDefaultResets();
            
            //clear the recording in the table
            ClearItemList();
        }

        private void ClearItemList()
        {
            _itemNameList.Clear();
        }

        private void ConductDefaultResets() {
            
            this._isDelete = false;
            
            itemsGrid.ClearSelection();
            
            //hide item add panel & Form
            itemAddPanel.Hide();
            fromPanel.Hide();
            
        }

        private void ReverseResets()
        {
            lblJobId.Text = _selectedJob;
            itemAddPanel.Show();
            fromPanel.Show();

            try
            {
                var jobDto = new JobController().FetchJobDataWithItemsById(_selectedJob);
                _itemNameList = jobDto.ItemNameList;
                
                itemsGrid.DataSource = _itemNameList;
                itemsGrid.Refresh();

                txtLocation.Text = jobDto.Location;
                datePickerRequiredDate.Value = jobDto.RequiredDate;
                txtRemark.Text = jobDto.Remarks;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            int selectedRowCount = gridPending
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount && null != gridPending.SelectedRows[0].Cells[0])
            {
                
                this._selectedJob = gridPending.SelectedRows[0].Cells[0].Value.ToString();
                
                ReverseResets();

            }
        }


        
    }
}  
