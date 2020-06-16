using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemCore;

namespace RestaurantSystemUI.OOBE_pages
{
    public partial class FinalInstructions : UserControl
    {
        public FinalInstructions()
        {
            InitializeComponent();
        }

        private void btnStartSystem_Click(object sender, EventArgs e)
        {
            // restart the app
            Application.Restart();
        }
    }
}
