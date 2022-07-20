using e_shift.dto;
using e_shift.utility;

namespace e_shift.views
{
    public partial class AdminLoadContainer : Form

    {

        private UserDto _userDto;

        public AdminLoadContainer(UserDto user)
        {
            
            _userDto = user;

            InitializeComponent();

            LoadSpecificView(Status.PENDING);
        }

        

        private void LoadSpecificView(Status status)
        {
            var adminCommonJob = new AdminCommonJob(status);
            adminCommonJob.TopLevel = false;
            panelJobMain.Controls.Add(adminCommonJob);
            adminCommonJob.BringToFront();
            adminCommonJob.Show();
        }

        private void Pending_Button_Click_Handle(object sender, EventArgs e)
        {
            LoadSpecificView(Status.PENDING);
        }

        private void Declined_Job_Click_Handle(object sender, EventArgs e)
        {
            LoadSpecificView(Status.DECLINED);
        }

        private void Completed_Job_Click_Handle(object sender, EventArgs e)
        {
            LoadSpecificView(Status.ACCEPTED);

        }
    }
}
