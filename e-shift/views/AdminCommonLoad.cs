using System.ComponentModel;
using e_shift.controller;
using e_shift.dto;
using e_shift.utility;

namespace e_shift.views
{
    public partial class AdminCommonLoad : Form
    {
        private bool _isDelete = false;
        private string _selectedJob;
        private string _selectedItem;
        private string _selectedLoadVehicleNo;

        private BindingList<JobItemDto> _itemNameList;
        private BindingList<LoadItemDto> _loadItemList = new();
        private Status _status;

        public AdminCommonLoad(Status status)
        {
            _status = status;

            InitializeComponent();

            //get accepted/declined data
            FetchData();
            
            //set driver data to combo
            SetDriverData();
            
            //set Vehicle Data to combo
            SetVehicleData();
            
            //default resets
            ConductDefaultResets();
            
            
            SetColumnsLoadGrid();
            
        }

        private void SetColumnsLoadGrid()
        {
            gridLoad.Columns.Add("DriverName", "Driver Name");
            gridLoad.Columns.Add("VehicleNo", "Vehicle No");
            gridLoad.Columns.Add("Remark", "Remark");
            gridLoad.Columns.Add("loadDate", "Loading Date");
        }

        private void SetVehicleData()
        {
            try
            {
                var vehicles = new VehicleController().fetchVehicles();

                foreach (var item in vehicles) {
                    var comboItemType = new ComboBoxItem
                    {
                        Text = item.VehicleNo,
                        Value = item.Vid.ToString()
                    };

                    comboVehicleNo.Items.Add(comboItemType);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        private void SetDriverData()
        {
            try
            {
                var drivers = new DriverController().fetchDrivers();

                foreach (var item in drivers) {
                    var comboItemType = new ComboBoxItem
                    {
                        Text = item.DriverName,
                        Value = item.Did.ToString()
                    };

                    comboDriver.Items.Add(comboItemType);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }


        /**
         * Fetch Pending Job Data and set to the pending grid
         */
        private void FetchData()
        {
            try
            {
                //get accepted or declined data basing the view
                var dt = new JobController().FetchAdminJobData(_status);
                gridPending.DataSource = dt;
            }
            catch (InvalidDataException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

                MessageBox.Show(Constants.SYSTEM_ERROR);
            }
        }

        

        private void ChangeHeaderNames()
        {
            var heading = _status switch
            {
                Status.PENDING => "Pending Jobs",
                Status.ACCEPTED => "Accepted Jobs",
                _ => "Decline Jobs"
            };

            lblHeader.Text = heading;
        }
        

        private void ConductDefaultResets() {
            
            itemsGrid.ClearSelection();
            
            //hide item add panel & Form
            itemAddPanel.Hide();
            fromPanel.Hide();
            
            panelLoad.Hide();
            btnCompleteLoad.Hide();

            btnDeleteLoad.Hide();


        }

        private void ReverseResets()
        {
            lblJobId.Text = _selectedJob;
            itemAddPanel.Show();
            fromPanel.Show();
            
            panelLoad.Show();
            btnCompleteLoad.Show();



            try
            {
                var jobDto = new JobController().FetchJobDataWithItemsById(_selectedJob);
                _itemNameList = jobDto.ItemNameList;
                
                itemsGrid.DataSource = _itemNameList;
                itemsGrid.Refresh();

                txtLocation.Text = jobDto.Location;
                datePickerRequiredDate.Value = jobDto.RequiredDate;
                txtRemark.Text = jobDto.Remarks;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void On_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            int selectedRowCount = gridPending
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount && null != gridPending.SelectedRows[0].Cells[0])
            {
                
                _selectedJob = gridPending.SelectedRows[0].Cells[0].Value.ToString();
                
                ReverseResets();

            }
        }
        
        private void AdminCommonLoad_Load(object sender, EventArgs e)
        {

        }

        private void itemsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Load_Click_Handle(object sender, EventArgs e)
        {
            var remarkLoad = txtRemarkLoad.Text;
            var driver = comboDriver.Text;
            var vehicleNo = comboVehicleNo.Text;
            var loadD = loadDate.Value.Date;


            var selectedDriver = (ComboBoxItem) comboDriver.SelectedItem;
            var selectedVehicle = (ComboBoxItem) comboVehicleNo.SelectedItem;

            var itemDto = LoadItemDto.Builder().WithRemark(remarkLoad)
                .WithDriverName(driver).WithVehicle(vehicleNo).
                WithLoadDateTime(loadD).
                Build();

            //set the primary keys manually
            itemDto.Vid = int.Parse(selectedVehicle.Value);
            itemDto.Did = int.Parse(selectedDriver.Value);

            AddItemsToLoadTable(itemDto);
            

        }

        private void AddItemsToLoadTable(LoadItemDto itemDto)
        {
            var found = _loadItemList.ToList()
                .Find(obj => obj.VehicleNo.Equals(itemDto.VehicleNo));
            
            if (null != found)
            {
                MessageBox.Show("Error. A load with this vehicle number already exist");
                return;
            }
            
            _loadItemList.Add(itemDto);
            
            RefreshTable();
        }

        private void RefreshTable()
        {
            gridLoad.Rows.Clear();
            
            foreach (var loadItemDto in _loadItemList)
            {
                gridLoad.Rows.Add(loadItemDto.VehicleNo, loadItemDto.DriverName, loadItemDto.Remark, loadItemDto.LoadDate);
            }
            gridLoad.Refresh();
        }

        private void Btn_Delete_Load_Click_Handle(object sender, EventArgs e)
        {
            var loadItemDtos = _loadItemList.ToList()
                .FindAll(obj => obj.VehicleNo != _selectedLoadVehicleNo);

            _loadItemList = new BindingList<LoadItemDto>(loadItemDtos);
            
            RefreshTable();
            
            btnDeleteLoad.Hide();
        }

        private void Row_Click_Load_Grid(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowCount = gridLoad
              .Rows.GetRowCount(DataGridViewElementStates.Selected);

            //grab the selected rows
            if (1 == selectedRowCount && null != gridLoad.SelectedRows[0].Cells[0])
            {

                _selectedLoadVehicleNo = gridLoad.SelectedRows[0].Cells[0].Value.ToString();

                btnDeleteLoad.Show();

            }
        }

        private void btnCompleteLoad_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Assert.IsEmptyCollection( _loadItemList, "Load Cannot be created with No loads added");
                
                var isSucess = new LoadController().CreateLoad(_selectedJob, _loadItemList.ToList());

                if (isSucess)
                {
                    MessageBox.Show(Constants.SUCCESSFULLY_LOAD_CREATED);
                    FetchData();
                    ConductDefaultResets();
                }
                else
                {
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
            }
        }
    }
}  
