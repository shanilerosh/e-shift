using e_shift.dto;
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

            UserDto userDto = new UserDto(1, "Shanil", Role.ADMIN);
            Application.Run(new LoginView());
        }
    }
}