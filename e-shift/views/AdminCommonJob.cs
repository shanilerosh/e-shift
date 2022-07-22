using System.ComponentModel;
using e_shift.controller;
using e_shift.dto;
using e_shift.utility;

namespace e_shift.views
{
    public partial class AdminCommonJob : Form
    {
        private bool _isDelete = false;
        private string _selectedJob;
        private string _selectedItem;

        private BindingList<JobItemDto> _itemNameList;
        private Status _status;

        public AdminCommonJob(Status status)
        {
            _status = status;

            InitializeComponent();

            //get accepted/declined data
            FetchData();
            //default resets
            ConductDefaultResets();
            
            ChangeHeaderNames();
            
        }

        /**
         * Fetch Pending Job Data and set to the pending grid
         */
        private void FetchData()
        {
            try
            {
                //get accepted or declined data basing the view
                var dt = new JobController().FetchAdminJobData(_status);
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
            var heading = _status switch
            {
                Status.PENDING => "Pending Jobs",
                Status.ACCEPTED => "Accepted Jobs",
                Status.COMPLETED => "Completed Jobs",
                _ => "NOT Applicable"
            };

            lblHeader.Text = heading;
        }
        

        private void ConductDefaultResets() {
            
            itemsGrid.ClearSelection();
            
            //hide item add panel & Form
            itemAddPanel.Hide();
            fromPanel.Hide();
            panelAcceptReject.Hide();


        }

        private void ReverseResets()
        {
            lblJobId.Text = _selectedJob;
            itemAddPanel.Show();
            fromPanel.Show();


            if (Status.PENDING == _status)
            {
                panelAcceptReject.Show();
            }


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

        private void Btn_Accept_Job_Handle(object sender, EventArgs e)
        {
            try
            {
                var isSucess = new JobController().DeclineAcceptJob(lblJobId.Text,Status.ACCEPTED);

                if (isSucess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_JOB_ACCEPTED, lblJobId.Text));
                    FetchData();
                    ConductDefaultResets();
                }
                else
                {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
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

        private void Btn_Reject_Job_Handle(object sender, EventArgs e)
        {
            try
            {
                var isSucess = new JobController().DeclineAcceptJob(lblJobId.Text,Status.DECLINED);
                
                if (isSucess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_REJECTED, lblJobId.Text));
                    FetchData();
                    ConductDefaultResets();
                }
                else
                {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
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
    }
}  
