using FontAwesome.Sharp;
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
        private Color menuActive;
        private Color menuNormal;

        private List<Page> pages;


        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            pnActiveIndicator.Visible = false;

            lbTitle.Text = "";

            pages = new List<Page>() { 
                new Page(ibOrder, new Order()),
                new Page(iconButton1, new OrderList()),
                new Page(iconButton2, new Status()),
                new Page(iconButton3, new Personnel()),
            };

            menuActive = pages[0].menuButton.FlatAppearance.MouseOverBackColor;
            menuNormal = pages[0].menuButton.BackColor;

            foreach (Page p in pages)
            {
                p.menuButton.Click += onMenuItemClick;
            }
        }

        private void onMenuItemClick(object sender, EventArgs e)
        {
            foreach (Page b in pages)
            {
                b.menuButton.BackColor = menuNormal;
            }

            IconButton btn = sender as IconButton;
            btn.BackColor = menuActive;
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
