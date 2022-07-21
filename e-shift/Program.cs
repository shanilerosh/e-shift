using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using e_shift.views;

namespace e_shift
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var customerDto = new CustomerDto();
            customerDto.Cid = "C001";

            var dto = new UserDto();
            dto.Uid = 11;
            dto.Username = "Shanil";
            dto.Role = Role.CUSTOMER;
            
             //Application.Run(new ItemView());
             //Application.Run(new MainPanelView(dto));
            //Application.Run(new AdminJobContainer(dto));
            //Application.Run(new JobView(customerDto));
           Application.Run(new LoginView());
        }
    }
}