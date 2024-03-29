﻿using FontAwesome.Sharp;
using RestaurantSystemCore;
using RestaurantSystemUI.modules;
using RestaurantSystemUI.themes;
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
        public ColorTheme theme;

        internal Display display = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyTheme(ColorTheme theme)
        {
            // main areas
            pnMenuBar.BackColor = theme.MainMenuBar; // menubar panel
            pnContainer.BackColor = theme.ContentPanel;
            pnTitleBar.BackColor = theme.TitleBar;

            // menu items
            foreach (Page p in pages)
            {
                p.menuButton.Click += onMenuItemClick;
                p.menuButton.BackColor = theme.MainMenuItem;
                p.menuButton.FlatAppearance.MouseOverBackColor = theme.MainMenuItemMouseOver;
                p.menuButton.FlatAppearance.MouseDownBackColor = theme.MainMenuItemMouseDown;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            //theme = new ColorTheme();
            theme = ThemeProvider.GetTheme();            

            pnActiveIndicator.Visible = false;

            Settings setting_page = new Settings();

            setting_page.ShopInfoUpdated += (Object _sender, EventArgs _e) =>
            {
                lbShopName.Text = ShopManager.ShopName;
                pictureBox1.Image = Utility.Base64ToImage(ShopManager.ShopLogo);
            };

            pages = new List<Page>() {
                new Page(ibOrder, new AddOrder()),
                new Page(iconButton1, new OrderList()),
                new Page(iconButton2, new Status()),
                new Page(iconButton4, setting_page),                
                new Page(iconButton6, new FoodList()),
                new Page(iconButton5, new EmployeeList()),
                new Page(iconButton7, new Shift()),
                new Page(iconButton3, new Attendance()),
                new Page(iconButton9, new Report()),

            };



            
            lbShopName.Text = ShopManager.ShopName;

            string logo_base64 = ShopManager.ShopLogo;
            if (logo_base64.Length > 0)
            {
                pictureBox1.Image = Utility.Base64ToImage(logo_base64);
            }

            ApplyTheme(theme);

        }
        #region borderless window
        // for borderless window
        // this is the best solution we have found.
        // https://stackoverflow.com/questions/32310319/resize-a-borderless-form-that-has-controls-everywhere-no-empty-space


        // Other solutions we've tried:
        // 1. https://stackoverflow.com/questions/17748446/custom-resize-handle-in-border-less-form-c-sharp
        // Due to the lack of empty space of the main form, the solution above require the form to have a padding, which causes some tearing when resizing very fast.
        // https://stackoverflow.com/questions/21249955/is-this-possible-to-change-or-set-the-padding-color-of-a-windows-form
        // Normally, padding is not transparent. In order to hide the padding, we also try to override the OnPaintBackground() method and draw nothing, but it cause some tearing bugs.
        // 2. https://stackoverflow.com/questions/2575216/how-to-move-and-resize-a-form-without-a-border
        // This solution which implements resizing by listening for mouse event and set window's width and height, cause some of the controls not being shown when resizing very fast, which can be annoying.

        private int tolerance = 15;
        // some Windows API's constant
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;

        // size of the grip rectangle at the bottom right corner
        private Rectangle sizeGripRectangle;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            Brush brush = new SolidBrush(theme.ContentPanel);

            e.Graphics.FillRectangle(brush, sizeGripRectangle);
            
            //ControlPaint.DrawSizeGrip(e.Graphics, sizeGripRectangle); // not modern style

            brush = new SolidBrush(theme.MainMenuItemSelected);
            e.Graphics.FillPolygon(brush, new Point[] {
                new Point(sizeGripRectangle.X, sizeGripRectangle.Y + tolerance),
                new Point(sizeGripRectangle.X + tolerance, sizeGripRectangle.Y + tolerance),
                new Point(sizeGripRectangle.X + tolerance, sizeGripRectangle.Y)
                });
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnContentWrapper.Region = region;
            this.Invalidate();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        // title bar drag window
        // https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        
        // some Windows API constants
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // import some functions of user32.dll
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void lbProgramName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // close button
        private void ibtnCloseWindow_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable; // for closing animation
            Close();
            //Application.Exit();
        }
        // maximize button
        private void ibtnMaximizeWindow_Click(object sender, EventArgs e)
        {
            WindowState =
                (WindowState == FormWindowState.Maximized) ?
                FormWindowState.Normal :
                FormWindowState.Maximized;
        }
        // minimize button
        private void ibtnMinimizeWindow_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable; // for minimizing animation
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.None;
        }
        #endregion

        private void onMenuItemClick(object sender, EventArgs e)
        {
            // set to original background color
            foreach (Page b in pages)
            {
                b.menuButton.BackColor = theme.MainMenuItem;
            }
            // set active background color
            IconButton btn = sender as IconButton;
            btn.BackColor = theme.MainMenuItemSelected;
            pnActiveIndicator.Visible = true;
            pnActiveIndicator.Top = btn.Top;
            //lbTitle.Text = btn.Text;

            foreach (Page p in pages)
            {
                if (p.menuButton == btn)
                {
                    pnContainer.Controls.Add(p.page);
                    p.page.Dock = DockStyle.Fill;
                    p.page.BringToFront();
                    if (p.page is IThemeable)
                        ((IThemeable)p.page).ApplyTheme();
                    if(p.page is IAdminView)
                    {
                        // check if there's already a lock screen in place
                        
                        bool hasLockScreen = false;

                        foreach(Control c in p.page.Controls)
                        {
                            if( c is LockScreen)
                            {
                                hasLockScreen = true;
                                break;
                            }
                        }
                        if (!hasLockScreen) {
                            LockScreen ls = new LockScreen();
                            ls.ApplyTheme();
                            Utility.ShowFullSpaceDialog(p.page, ls);
                        }
                    }

                    if (p.page is ISubmodule)
                        ((ISubmodule)p.page).BeforeMounted();
                    
                    
                    break;
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBProvider.GetDatabase().Dispose();
        }

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {

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
