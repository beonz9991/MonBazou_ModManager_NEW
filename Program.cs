using System.Net;

namespace MonBazou_ModManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            /*
            using (WebClient client = new WebClient())
            {
                string disable = client.DownloadString("");
                if (disable == "disable")
                {
                    MessageBox.Show("Mod Manager currently unavailable! Check discord for more info.");
                }
                else
                {
                    Application.Run(new Form1());
                }
            }
            */
        }
    }
}