using System;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreenForm splashScreen = new SplashScreenForm();
            splashScreen.ShowDialog();
            Application.Run(new LoginForm());
        }
    }
}