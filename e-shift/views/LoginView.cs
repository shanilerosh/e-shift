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
        private void BtnSubmit_onClick(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                UserDto userDto = UserDto.Builder()
                      .WithUserName(username).WithPassword(password).Build();

                UserDto loggedUser = new LoginController().LoginUser(userDto
                    ,radioAdmin.Checked);
                
                //user dto found from the db
                if (null != loggedUser)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_LOGGED_IN, username));

                    MainPanelView panel = new MainPanelView(loggedUser);
                    panel.Show();
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
            lblCreate.Hide();

            radioAdmin.Checked = true;
            radioCustomer.Checked = false;

        }


        

        private void Handle_customer_radio_chanel(object sender, EventArgs e)
        {
            if (radioCustomer.Checked)
            {
                btnCreate.Show();
                lblCreate.Show();
            }
            else {
                ConductDefaultResets();
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";

            ConductDefaultResets();
        }

        private void Btn_Create_Account_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.Show();

            this.Hide();
        }
    }
}
