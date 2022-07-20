using e_shift.dto;
using e_shift.utility;

namespace e_shift.views
{
    public partial class JobContainer : Form

    {

        private CustomerDto _customerDto;

        public JobContainer(CustomerDto customerDto)
        {
            _customerDto = customerDto;
            InitializeComponent();
            
            //defaultly load create data
            LoadDefaultCreateJobData();
        }

        private void JobContainer_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelJobMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Create_Job_On_Click(object sender, EventArgs e)
        {
            LoadDefaultCreateJobData();
        }

        private void LoadDefaultCreateJobData()
        {
            JobView customerView = new JobView(_customerDto);
            customerView.TopLevel = false;
            panelJobMain.Controls.Add(customerView);
            customerView.BringToFront();
            customerView.Show();
        }

        private void Pending_Button_Click_Handle(object sender, EventArgs e)
        {
            JobViewPending pendingView = new JobViewPending(_customerDto);
            pendingView.TopLevel = false;
            panelJobMain.Controls.Add(pendingView);
            pendingView.BringToFront();
            pendingView.Show();
        }

        private void Declined_Job_Click_Handle(object sender, EventArgs e)
        {
            var jobAdView = new JobAcceptedDeclined(_customerDto, Status.DECLINED);
            jobAdView.TopLevel = false;
            panelJobMain.Controls.Add(jobAdView);
            jobAdView.BringToFront();
            jobAdView.Show();
        }

        private void Completed_Job_Click_Handle(object sender, EventArgs e)
        {
            var jobAdView = new JobAcceptedDeclined(_customerDto, Status.ACCEPTED);
            jobAdView.TopLevel = false;
            panelJobMain.Controls.Add(jobAdView);
            jobAdView.BringToFront();
            jobAdView.Show();

        }
    }
}
