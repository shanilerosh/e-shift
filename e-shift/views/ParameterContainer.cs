using e_shift.dto;
using e_shift.utility;

namespace e_shift.views
{
    public partial class ParameterContainer : Form

    {

        private UserDto _userDto;

        public ParameterContainer(UserDto user)
        {
            
            _userDto = user;

            InitializeComponent();

        }


        private void Item_Param_Btn_Click(object sender, EventArgs e)
        {
            ItemView itemView = new ItemView();
            itemView.TopLevel = false;
            panelParamMain.Controls.Add(itemView);
            itemView.BringToFront();
            itemView.Show();
        }
        
    }
}
