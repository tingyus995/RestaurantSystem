using RestaurantSystemCore;
using RestaurantSystemCore.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    public partial class Display : Form, IThemeable
    {
        private int speed = 3;
        private int currentIndex = 0;

        private List<string> readys = new List<string>();
        public Display()
        {
            InitializeComponent();
        }
        private void tmAnnouncementRoll_Tick(object sender, EventArgs e)
        {
            if(lbAnnouncement.Width > lbAnnouncement.Parent.Width)
            {
                lbAnnouncement.Left -= speed;

                if(lbAnnouncement.Left + lbAnnouncement.Width < 0)
                {
                    lbAnnouncement.Left = 0;
                }
            }
            else
            {
                lbAnnouncement.Left = 0;
            }
        }

        private void UpdateReadyList()
        {
            readys.Clear();

            Order[] orders = OrderManager.GetAllOrders();
            foreach(Order ord in orders)
            {
                if(ord.Status == Order.OrderStatus.Ready)
                {
                    readys.Add(ord.No.ToString());
                }
            }
        }

        private void Display_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            lbAnnouncement.Text = ShopManager.ShopAnnouncement;
        }

        private void tmShowReadyNum_Tick(object sender, EventArgs e)
        {
            UpdateReadyList();

            if (readys.Count > 0)
            {
                lbReadyNo.Text = readys[currentIndex];
                Console.WriteLine("Index: = " + currentIndex);
                currentIndex++;
                if(readys.Count == currentIndex)
                {
                    currentIndex = 0;
                }
            }
            else
            {
                lbReadyNo.Text = "";
            }
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
        }
    }
}
