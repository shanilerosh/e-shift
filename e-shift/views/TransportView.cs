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
    public partial class TransportView : Form
    {
        private bool _isUpdate = false;

        public TransportView()
        {
            InitializeComponent();

            //load data to the grid
            LoadTransportUnitData();
            //load latest id
            SetTransportId();
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

            searchCombo.Items.Add(firstNameItem);
            searchCombo.Items.Add(lstNameItem);
            searchCombo.Items.Add(nicItem);
            
            searchCombo.SelectedIndex = 0;
        }


        public void SetValueVehicleTypeCombo()
        {


            ComboBoxItem firstNameItem = new ComboBoxItem();
            firstNameItem.Text = "First Name";
            firstNameItem.Value = "firstname";

            ComboBoxItem lstNameItem = new ComboBoxItem();
            lstNameItem.Text = "Last Name";
            lstNameItem.Value = "lastname";

            ComboBoxItem nicItem = new ComboBoxItem();
            nicItem.Text = "NIC";
            nicItem.Value = "nic";

            searchCombo.Items.Add(firstNameItem);
            searchCombo.Items.Add(lstNameItem);
            searchCombo.Items.Add(nicItem);

            searchCombo.SelectedIndex = 0;
        }



        //Get the values from the controller and set to the datagrid
        public void LoadTransportUnitData() {
            try
            {
                //set values to the data grid
                gridTransportUnit.DataSource = new TransportUnitController().GetAllTransportUnits();

                ChangeHeaderNames();
                
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        private void ChangeHeaderNames()
        {
            gridTransportUnit.Columns[0].HeaderText = "TID";
            gridTransportUnit.Columns[1].HeaderText = "Vehicle Type";
            gridTransportUnit.Columns[2].HeaderText = "Model";
            gridTransportUnit.Columns[3].HeaderText = "Vehicle No";
            gridTransportUnit.Columns[4].HeaderText = "Capacity";
        }

        public void SetTransportId()
        {
            try
            {
                //set values to the data grid
                string tid = new TransportUnitController().GetTransportUnitId();
                lblTransportId.Text = tid;
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /*Handle Submit Button click*/
        private void btnSubmit_onClick(object sender, EventArgs e)
        {

            string vehicleType = ((ComboBoxItem) comboVehicleType.SelectedItem).Value;
            string vehicleNo= txtVehicleNo.Text;
            string model = txtModel.Text;
            int capacity = (int) txtCapacity.Value;
            string remark = txtRemark.Text;
            


            try
            {
                //Initialize dto with a builder
                TransportUnitDto transportUnitDto = TransportUnitDto.Builder()
                        .WithCapacity(capacity).WithRemark(remark).WithModel(model)
                        .WithRemark(vehicleType).WithVehicleNo(vehicleNo).build();

                bool isSuccess;

                if (!this._isUpdate) {
                    isSuccess = new TransportUnitController().SaveTransportUnit(transportUnitDto);
                } else {
                    isSuccess = new TransportUnitController().UpdateTransportUnit(transportUnitDto, lblTransportId.Text);
                }

                //after submit 
                if (isSuccess)
                {
                    MessageBox.Show(string.Format(!this._isUpdate ? Constants.SUCCESSFULLY_CREATED
                        : Constants.SUCCESSFULLY_UPDATED, Constants.TRANSPORT_UNIT));

                    LoadTransportUnitData();
                }
                else {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }

                this.ClearFields();
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

        /*Handle reset Button click*/
        private void btnReset_onClick(object sender, EventArgs e)
        {

            this.ClearFields();
        }

        /*Method to clear fields of the vie and load latestId*/
        private void ClearFields() {
            comboVehicleType.Items.Clear();
            txtVehicleNo.Text = "";
            txtModel.Text = "";
            txtRemark.Text = "";
            txtCapacity.Text = "";

            //generae custId
            SetTransportId();


            ConductDefaultResets();

        }

        private void ConductDefaultResets() {

            //change button txt and flag
            btnSubmit.Text = "Create";
            this._isUpdate = false;

            //disable delete btn
            btnDelete.Enabled = false;
            gridTransportUnit.ClearSelection();

            txtSearch.Text = "";
        }

       

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {

            
            btnSubmit.Text = "Update";
            this._isUpdate = true;

            btnDelete.Enabled = true;
            


            int selectedRowCount = gridTransportUnit
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount)
            {
               
                string? custId = gridTransportUnit.SelectedRows[0].Cells[0].Value.ToString();
                string? firstName = gridTransportUnit.SelectedRows[0].Cells[1].Value.ToString();
                string? lastName = gridTransportUnit.SelectedRows[0].Cells[2].Value.ToString();
                string? nic = gridTransportUnit.SelectedRows[0].Cells[3].Value.ToString();
                string? address = gridTransportUnit.SelectedRows[0].Cells[4].Value.ToString();
                string? contactNumber = gridTransportUnit.SelectedRows[0].Cells[5].Value.ToString();


                comboVehicleType.Text = firstName;
                txtVehicleNo.Text = lastName;
                txtModel.Text = nic;
                txtRemark.Text = address;
                txtCapacity.Text = contactNumber;

                lblTransportId.Text = custId;
            }
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = new CustomerController().DeleteCustomer(lblTransportId.Text);


                if (isSuccess)
                {
                    MessageBox.Show(string.Format(Constants.SUCCESSFULLY_DELETED, Constants.CUSTOMER));
                    LoadTransportUnitData();
                }
                else
                {
                    MessageBox.Show(Constants.SYSTEM_ERROR);
                }

                LoadTransportUnitData();
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }

            this.ClearFields();
        }

        private void txtsearch_Change(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            string type = ((ComboBoxItem) searchCombo.SelectedItem).Value;

            DataTable dataTable = new CustomerController().SearchCustomers(type, text);

            gridTransportUnit.DataSource = dataTable;

            ChangeHeaderNames();
        }

    }
}  
