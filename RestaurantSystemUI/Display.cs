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
    public partial class Display : Form
    {
        private int speed = 3;
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
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }

        private void tmQueueScroll_Tick(object sender, EventArgs e)
        {

            Control lastElement = fpnQueuingList.Controls[fpnQueuingList.Controls.Count - 1];

            //if (lastElement.Right >= flowLayoutPanel1.Width)
            {
                //fpnQueuingList.HorizontalScroll.Value += 1;
            }
        }
    }
}
