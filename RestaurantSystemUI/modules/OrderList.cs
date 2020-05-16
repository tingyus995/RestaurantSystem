using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemCore.models;
using RestaurantSystemCore;
using RestaurantSystemUI.modules;

namespace RestaurantSystemUI
{
    public partial class OrderList : UserControl, ISubmodule, IThemeable
    {
        public OrderList()
        {
            InitializeComponent();
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
        }

        public void BeforeMounted()
        {
            init();
        }

        private void init()
        {
            flowLayoutPanel1.SuspendLayout();

            flowLayoutPanel1.Controls.Clear();
            /*foreach (Control control in flowLayoutPanel1.Controls)
                control.Dispose();*/

            Order[] orders = OrderManager.GetAllOrders();
            //MessageBox.Show(orders.Length.ToString());
            foreach (Order ord in orders)
            {
                OrderView ordView = new OrderView(ord);

                flowLayoutPanel1.Controls.Add(new OrderView(ord));
            }

            flowLayoutPanel1.ResumeLayout();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            /*ImageList imageList = new ImageList();
            imageList.Images.Add(new Bitmap("C:\\Users\\TingYuYan\\Desktop\\test.jpg"));


            ListViewItem item1 = new ListViewItem("test food");
            item1.SubItems.Add(DateTime.Now.ToString());
            item1.ImageIndex = 0;

            ListViewItem item2 = new ListViewItem("test food 2");
            item2.SubItems.Add(DateTime.Now.ToString());
            item2.ImageIndex = 0;

            listView1.LargeImageList = imageList;
            
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);*/

            // put some dummpy data

            /*DateTime d = DateTime.Now;


            flowLayoutPanel1.Controls.Add(new OrderItem("焗烤麵", OrderItem.State.Preparing, d));
            flowLayoutPanel1.Controls.Add(new OrderItem("麻醬麵", OrderItem.State.Queuing,d ));
            flowLayoutPanel1.Controls.Add(new OrderItem("培根鐵板麵", OrderItem.State.Finished, d));
            flowLayoutPanel1.Controls.Add(new OrderItem("義大利麵", OrderItem.State.Ready, d));
            flowLayoutPanel1.Controls.Add(new OrderItem("培根鐵板麵", OrderItem.State.Ready, d));*/

            init();

        }
    }
}
