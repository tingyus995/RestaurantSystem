using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    public partial class OrderItem : UserControl
    {
        Color queuing = Color.FromArgb(230, 126, 34);
        Color preparing = Color.FromArgb(241, 196, 15);
        Color ready = Color.FromArgb(39, 174, 96);
        Color finished = Color.FromArgb(149, 165, 166);

        State state;

        DateTime createdAt;

        public enum State
        {
            Queuing,
            Preparing,
            Ready,
            Finished
        }
        private string foodName;

        private Color darken(Color c, int amount)
        {

            int a = c.A;
            int r = c.R - amount;
            int g = c.G - amount;
            int b = c.B - amount;

            
            if (r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;
            
            return Color.FromArgb(a, r, g, b);
        }


        private void updateUI()
        {

            lbFoodName.Text = foodName;

            // lbStatus
            switch (state)
            {
                case State.Queuing:
                    lbStatus.Text = "排隊中";
                    lbStatus.BackColor = queuing;

                    break;
                case State.Preparing:
                    lbStatus.Text = "製作中";
                    lbStatus.BackColor = preparing;
                    break;
                case State.Ready:
                    lbStatus.Text = "可取餐";
                    lbStatus.BackColor = ready;
                    break;
                case State.Finished:
                    lbStatus.Text = "訂單完成";
                    lbStatus.BackColor = finished;
                    break;
            }
            // btn next
            switch (state)
            {
                case State.Queuing:
                    btnNext.Text = "設為製作中";
                    btnNext.BackColor = darken(preparing, 30);

                    break;
                case State.Preparing:
                    btnNext.Text = "設為可取餐";
                    btnNext.BackColor = darken(ready, 30);
                    break;
                case State.Ready:
                    btnNext.Text = "設為訂單完成";
                    btnNext.BackColor = darken(finished, 30);
                    break;
                case State.Finished:
                    btnNext.Visible = false;
                    break;
            }

            if (state == State.Finished) tmWaitTimeUpdate.Enabled = false;
        }

        public OrderItem(string _foodName, State s, DateTime t)
        {
            foodName = _foodName;
            createdAt = t;
            state = s;
            
            InitializeComponent();
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {            
            updateUI();
        }

        private void tmWaitTimeUpdate_Tick(object sender, EventArgs e)
        {
            lbWaitTime.Text = "已等候時間：" +  (DateTime.Now - createdAt).ToString(@"hh\:mm\:ss");
        }
    }
     
}
