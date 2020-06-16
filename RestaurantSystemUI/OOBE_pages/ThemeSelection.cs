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
using RestaurantSystemUI.controls;

namespace RestaurantSystemUI.OOBE_pages
{
    public partial class ThemeSelection : UserControl, IOOBEPage
    {

        ThemeSelector themeSelector1;
        public ThemeSelection()
        {
            InitializeComponent();
        }

        public void BeforeMount()
        {
            //throw new NotImplementedException();
        }

        public bool LeaveCheck()
        {
            if(themeSelector1.SelectedThemeName == null)
            {
                MessageBox.Show("something went wrong!");
            }

            ShopManager.ShopThemeName = themeSelector1.SelectedThemeName;
            return true;
        }

        private void ThemeSelection_Load(object sender, EventArgs e)
        {
            themeSelector1 = new ThemeSelector();
            themeSelector1.Location = new System.Drawing.Point(62, 99);
            themeSelector1.Size = new System.Drawing.Size(508, 320);

            Controls.Add(themeSelector1);
        }
    }
}
