using e_shift.controller;
using e_shift.dto;
using e_shift.utility;

namespace e_shift.views
{
    public partial class LoginView : Form
    {

        public LoginView()
        {
            InitializeComponent();


            //default resets
            ConductDefaultResets();


        }





        /*Handle Submit Button click*/
        private void btnSubmit_onClick(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                UserDto userDto = UserDto.Builder()
                      .WithUserName(username).WithPassword(password).Build();

                UserDto loggedUser = new LoginController().LoginUser(userDto
                    ,radioAdmin.Checked);

                if (null != loggedUser)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_LOGGED_IN, username));

                    MainPanelView panl = new MainPanelView(userDto);
                    panl.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }


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


        private void ClearFields()
        {


        }

        private void ConductDefaultResets()
        {

            btnCreate.Hide();

        }


        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void handle_customer_radio_chane(object sender, EventArgs e)
        {
            if (radioCustomer.Checked) {
                btnCreate.Show();
            }
        }

        private void Hanlde_radio_admin_change(object sender, EventArgs e)
        {
            if (radioAdmin.Checked) { 
                btnCreate.Hide();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.Show();

            this.Hide();
        }
    }
}
