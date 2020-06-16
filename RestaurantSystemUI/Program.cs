using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    static class Program
    {

        internal static MainWindow mainWindow = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            // check if data.db exists

            if (!File.Exists("data.db"))
            {
                Application.Run(new OOBE());
            }
            else
            {
                mainWindow = new MainWindow();
                Application.Run(mainWindow);
            }



        }
    }
}
