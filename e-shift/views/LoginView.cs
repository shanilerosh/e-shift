using e_shift.controller;
using e_shift.dto;
using e_shift.utility;
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

                UserDto loggedUser = new LoginController().LoginUser(userDto);

                if (null != loggedUser)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_LOGGED_IN, username));

                    MainPanelView panl = new MainPanelView(userDto);
                    panl.Show();
                    Hide();

                }
                else {
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

       
        private void ClearFields() {
        

        }

        private void ConductDefaultResets() {

            //change button txt and flag
        
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
    }
}  
