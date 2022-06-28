using e_shift.controller;
using e_shift.db;
using e_shift.dto;
using System.Data.SqlClient;

namespace e_shift
{
    public partial class Form1 : Form
    {

        private LoginController loginController = new LoginController();

        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnLogin_click(object sender, EventArgs e)
        {
            String text = txtUsername.Text;
            String password = txtPassword.Text;

            MessageBox.Show("Clicked");

        }
    }
}