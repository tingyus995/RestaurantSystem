using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    static class Program
    {
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
                Application.Run(new MainWindow());
            }



        }
    }
}
