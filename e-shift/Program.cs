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

            Customer customer = new Customer("C-001", "sad", "dsad", "asd", "asd","sad");
            Application.Run(new JobView(customer));
        }
    }
}