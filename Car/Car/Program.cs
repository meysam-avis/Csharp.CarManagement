using System;
using System.Windows.Forms;
using Car.Models;
using Car.Shared;
using Car.Views;

namespace Car
{
    static class Program
    {
        public static string AppName { get; } = "Sabt.Car";
        public static User User { get; set; }
        public static string Version { get; } = "0.0.5";
        public static string AesKey = "meysam.avis@sabt";
        public static string ConnectionString = $"Server=your_ip;Database=car;User ID=your_user;Password=yourpassword;MultipleActiveResultSets=true;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm fLogin = new LoginForm();


            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainFrom());
            }


        }
    }
}
