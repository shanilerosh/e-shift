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
    public partial class CustomerAdminView : Form
    {
        private bool _isUpdate = false;

        public CustomerAdminView()
        {
            InitializeComponent();

            //load data to the grid
            LoadCustomerByStatus();
            //default resets
            ConductDefaultResets();
            //set values to search compbo
            SetValueToSearchCombo();
        }

        public void SetValueToSearchCombo() {


            ComboBoxItem firstNameItem = new ComboBoxItem();
            firstNameItem.Text = "First Name";
            firstNameItem.Value = "firstname";

            ComboBoxItem lstNameItem = new ComboBoxItem();
            lstNameItem.Text = "Last Name";
            lstNameItem.Value = "lastname";

            ComboBoxItem nicItem = new ComboBoxItem();
            nicItem.Text = "NIC";
            nicItem.Value = "nic";

            ComboBoxItem statis = new ComboBoxItem();
            nicItem.Text = "Approve Status";
            nicItem.Value = "customerStatus";

            searchCombo.Items.Add(firstNameItem);
            searchCombo.Items.Add(lstNameItem);
            searchCombo.Items.Add(nicItem);
            
            searchCombo.SelectedIndex = 0;
        }
        
        //Get the values from the controller and set to the datagrid
        public void LoadCustomerByStatus() {
            try
            {
                //set values to the data grid
                gridCustomer.DataSource = new CustomerController()
                    .GetAllCustomers();

            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }
        
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        /*Handle reset Button click*/
        private void btnReset_onClick(object sender, EventArgs e)
        {

            this.ClearFields();
        }

        private void ApproveDiscardCustomer(CustomerStatus status)
        {
            try
            {
                bool isSucess = new CustomerController()
                    .UpdateCustomerStatus(status, lblCustomerId.Text);
            
            
                if (isSucess)
                {
                    MessageBox.Show(Constants.SUCCESSFULLY_CUSTOMER_UPDATED);
                    LoadCustomerByStatus();
                    ClearFields();
                    
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
                this.ClearFields();
            }
        }

        /*Method to clear fields of the vie and load latestId*/
        private void ClearFields() {
            lblCustomerId.Text = "";
            txtFirstName.Text = "";
            txtNic.Text = "";
            txtLastName.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";

            lblCustomerId.Text = "";
            
            ConductDefaultResets();
        }

        private void ConductDefaultResets() {
            btnApprove.Hide();
            btnDiscard.Hide();
        }
        
        private void ReverseResets() {
            btnApprove.Show();
            btnDiscard.Show();
        }

       

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {

            

            ReverseResets();
            


            int selectedRowCount = gridCustomer
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount)
            {
               
                string? custId = gridCustomer.SelectedRows[0].Cells[0].Value.ToString();
                string? firstName = gridCustomer.SelectedRows[0].Cells[1].Value.ToString();
                string? lastName = gridCustomer.SelectedRows[0].Cells[2].Value.ToString();
                string? nic = gridCustomer.SelectedRows[0].Cells[3].Value.ToString();
                string? address = gridCustomer.SelectedRows[0].Cells[4].Value.ToString();
                string? contactNumber = gridCustomer.SelectedRows[0].Cells[5].Value.ToString();
                
                var custStatus = (CustomerStatus)Enum.
                    Parse(typeof(CustomerStatus), gridCustomer.SelectedRows[0].Cells[6].Value.ToString());

                if (custStatus.Equals(CustomerStatus.APPROVED))
                {
                    btnApprove.Hide();
                }
                else
                {
                    btnDiscard.Hide();
                }

                lblCustomerId.Text = custId;
                txtFirstName.Text = firstName;
                txtNic.Text = nic;
                txtLastName.Text = lastName;
                txtContactNumber.Text = contactNumber;
                txtAddress.Text = address;
                
            }
        }

        private void btnDelete_click(object sender, EventArgs e)
        {

        }

        private void txtsearch_Change(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            string type = ((ComboBoxItem) searchCombo.SelectedItem).Value;

            DataTable dataTable = new CustomerController().SearchCustomers(type, text);

            gridCustomer.DataSource = dataTable;
        }

        private void CustomerAdminView_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Approve_Click(object sender, EventArgs e)
        {
            ApproveDiscardCustomer(CustomerStatus.APPROVED);
        }

        private void Btn_Discard_Click(object sender, EventArgs e)
        {
            ApproveDiscardCustomer(CustomerStatus.NOT_APPROVED);
        }
    }
}  
