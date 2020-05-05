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

namespace RestaurantSystemUI.modules
{
    public partial class Settings : UserControl
    {
        public event EventHandler ShopInfoUpdated;
        Bitmap logo;
        
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            flatTextbox1.textBox.Text = ShopManager.ShopName;
            string logo_base64 = ShopManager.ShopLogo;
            if (logo_base64.Length > 0)
            {
                logo = Utility.Base64ToImage(logo_base64);
                pictureBox1.Image = logo;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            ShopManager.ShopName = flatTextbox1.textBox.Text;
            
            if(ShopInfoUpdated != null)
            {
                ShopInfoUpdated(this, new EventArgs());
            }

            if(logo != null)
            {
                ShopManager.ShopLogo = Utility.ImageToBase64(logo);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if( DialogResult.OK == openFileDialog1.ShowDialog())
            {
                logo = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = logo;
                
            }
        }
    }
}
