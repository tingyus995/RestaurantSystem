using FontAwesome.Sharp;
using RestaurantSystemCore;
using RestaurantSystemUI.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{

    public partial class MainWindow : Form
    {

        private List<Page> pages;
        ColorTheme theme;


        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            theme = new ColorTheme();

            // apply color theme
            panel1.BackColor = theme.MainMenuBar; // menubar panel
            pnContainer.BackColor = theme.ContentPanel;
            pnTitle.BackColor = theme.ContentPanel;

            
            pnActiveIndicator.Visible = false;

            lbTitle.Text = "";


            Settings setting_page = new Settings();

            setting_page.ShopInfoUpdated += (Object _sender, EventArgs _e) =>
            {
                lbShopName.Text = ShopManager.ShopName;
            };

            pages = new List<Page>() { 
                new Page(ibOrder, new Order()),
                new Page(iconButton1, new OrderList()),
                new Page(iconButton2, new Status()),
                new Page(iconButton3, new Personnel()),
                new Page(iconButton4, setting_page),
                new Page(iconButton5, new FoodEditor())
            };

            

            // theme

            foreach (Page p in pages)
            {
                p.menuButton.Click += onMenuItemClick;
                p.menuButton.BackColor = theme.MainMenuItem;
                p.menuButton.FlatAppearance.MouseOverBackColor = theme.MainMenuItemMouseOver;
                p.menuButton.FlatAppearance.MouseDownBackColor = theme.MainMenuItemMouseDown;
            }

            lbShopName.Text = ShopManager.ShopName;

            string logo_base64 = ShopManager.ShopLogo;
            if (logo_base64.Length > 0)
            { 
                pictureBox1.Image = Utility.Base64ToImage(logo_base64);
            }


        }

        private void onMenuItemClick(object sender, EventArgs e)
        {
            foreach (Page b in pages)
            {
                b.menuButton.BackColor = theme.MainMenuItem;
                
            }

            IconButton btn = sender as IconButton;
            btn.BackColor = theme.MainMenuItemSelected;
            pnActiveIndicator.Visible = true;
            pnActiveIndicator.Top = btn.Top;
            lbTitle.Text = btn.Text;

            foreach(Page p in pages)
            {
                if(p.menuButton == btn)
                {
                    pnContainer.Controls.Add(p.page);
                    p.page.Dock = DockStyle.Fill;
                    p.page.BringToFront();
                    break;
                }
            }
        }

    }

    class Page
    {
        public IconButton menuButton;
        public UserControl page;
        public Page(IconButton _menuBtn, UserControl _page)
        {
            menuButton = _menuBtn;
            page = _page;
        }
    }
}
