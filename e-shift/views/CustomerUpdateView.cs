using e_shift.controller;
using e_shift.dto;
using e_shift.utility;

namespace e_shift.views
{
    public partial class CustomerUpdateView : Form
    {


        private CustomerDto _customerDto;
        private UserDto _userDto;

        public CustomerUpdateView(CustomerDto customerDto)
        {
            InitializeComponent();

            _customerDto = customerDto;
            

            SetUserData();

            ConductDefaultResets();

            SetDtoValuesToFields();
            
            Refresh();
        }

        private void SetUserData()
        {

            try
            {

                var userDto = new CustomerController().fetchUserByCustomerId(_customerDto.Cid);

                _userDto = userDto;
                
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

        private void ConductDefaultResets()
        {
            panelPassword.Visible = false;

            txtLastName.Enabled = true;
            txtFirstName.Enabled = true;
            txtAddress.Enabled = true;
            txtNic.Enabled = true;
            txtContactNumber.Enabled = true;

            txtUserName.Enabled = false;



        }

        private void Refresh()
        {
            try
            {
                var customer = new CustomerController().findCustomerByUserId(_userDto.Uid);
                _customerDto = customer;
                
                SetDtoValuesToFields();
            }
            catch (Exception e)
            {
                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        private void ReverseResets() {
            panelPassword.Visible = true;



            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtAddress.Enabled = false;
            txtNic.Enabled = false;
            txtContactNumber.Enabled = false;


        }

        private void SetDtoValuesToFields() {
            txtLastName.Text = _customerDto.LastName;
            txtFirstName.Text = _customerDto.Address;
            txtAddress.Text = _customerDto.Address;
            txtNic.Text= _customerDto.Nic;
            txtContactNumber.Text= _customerDto.ContactNumber;
            txtUserName.Text = _userDto.Username;

            lblCustId.Text = _customerDto.Cid;



        }
        

        /*Handle Submit Button click*/
        private void BtnSubmit_onClick(object sender, EventArgs e)
        {

            bool isSuccess = false;

            try
            {
                //change pass
                if (radioYes.Checked)
                {
                    var prePass = txtPrePass.Text;
                    var userName = txtUserName.Text;
                    var newPass = txtNewPass.Text;


                    var userDto = UserDto.Builder().WithUid(_userDto.Uid)
                        .WithRole(Role.CUSTOMER).WithUserName(userName).WithPassword(prePass).Build();
                
                    Assert.HasText(newPass, "New Password Cannot be empty");

                    var loginUser = new LoginController().LoginUser(userDto, false);
                
                    Assert.IsNull(loginUser, Constants.PRE_PASS_INVALID);

                    isSuccess = new LoginController().UpdatePassword(userName, newPass);
                
                }
                else
                {
                    //change user data
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string nic = txtNic.Text;
                    string address = txtAddress.Text;
                    string conactNumber = txtContactNumber.Text;
                
                    //Initialize dto with a builder
                    CustomerDto customerDto = CustomerDto.Builder()
                        .WithFirstName(firstName).WithLastName(lastName)
                        .WithNic(nic).WithAddress(address).WithContactNumber(conactNumber)
                        .Build();

                    isSuccess =new CustomerController().UpdateCustomer(customerDto, lblCustId.Text);
                }
            
                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_UPDATED, Constants.CUSTOMER));
                    this.Refresh();
                    ConductDefaultResets();
                    Refresh();
                }
                else {
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
                ConductDefaultResets();
            }
        }

        /*Handle reset Button click*/
        private void BtnReset_onClick(object sender, EventArgs e)
        {

            this.ClearFields();
        }

        /*Method to clear fields of the vie and load latestId*/
        private void ClearFields() {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNic.Text = "";
            txtAddress.Text = "";
            txtContactNumber.Text = "";
            

        }

        private void Btn_Back_To_Login_Handle(object sender, EventArgs e)
        {
            ShowLogin();
        }


        private void ShowLogin() {
            var loginView = new LoginView();
            loginView.Show();

            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerUpdateView_Load(object sender, EventArgs e)
        {

        }

        private void RadioYes_CheckedChanged(object sender, EventArgs e)
        {
            ReverseResets();
        }

        private void RadioNo_CheckedChanged(object sender, EventArgs e)
        {
            ConductDefaultResets();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}  
