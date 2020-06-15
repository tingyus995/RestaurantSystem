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
            // save all configurations to database and start form1

            //ShopManager.ShiftCb1StartTime = comboBox1.SelectedItem.ToString();
            //ShopManager.ShiftCb2Interval = comboBox2.SelectedItem.ToString();
            //ShopManager.ShiftCb3Amount = comboBox3.SelectedItem.ToString();
        }
    }
}
