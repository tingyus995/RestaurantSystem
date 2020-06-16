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

namespace RestaurantSystemUI
{
    public partial class Status : UserControl, IThemeable
    {
        public Status()
        {
            InitializeComponent();
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
            ftbAnnouncement.BackColor = theme.ContentPanel;
        }

        private void btnShowDisplay_Click(object sender, EventArgs e)
        {
            MainWindow win = Utility.GetMainWindow();
            if( win.display == null)
            {
                win.display = new Display();
                win.display.FormClosed += Display_FormClosed;
                win.display.Show();
            }           
        }

        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow win = Utility.GetMainWindow();
            win.display = null;
        }

        private void Status_Load(object sender, EventArgs e)
        {
            ftbAnnouncement.textBox.Text = ShopManager.ShopAnnouncement;
        }

        private void btnSetText_Click(object sender, EventArgs e)
        {

            ShopManager.ShopAnnouncement = ftbAnnouncement.textBox.Text;

            MainWindow win = Utility.GetMainWindow();
            if (win.display != null)
            {
                win.display.lbAnnouncement.Text = ftbAnnouncement.textBox.Text;                
            }
        }
    }
}
