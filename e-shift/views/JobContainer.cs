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
    public partial class JobContainer : Form

    {

        private CustomerDto _customerDto;

        public JobContainer(CustomerDto customerDto)
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelJobMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Create_Job_On_Click(object sender, EventArgs e)
        {
            JobView customerView = new JobView(_customerDto);
            customerView.TopLevel = false;
            panelJobMain.Controls.Add(customerView);
            customerView.BringToFront();
            customerView.Show();
        }
    }
}
