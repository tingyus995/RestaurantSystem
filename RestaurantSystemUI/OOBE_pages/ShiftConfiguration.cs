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

namespace RestaurantSystemUI.OOBE_pages
{
    public partial class ShiftConfiguration : UserControl, IOOBEPage
    {
        public ShiftConfiguration()
        {
            InitializeComponent();
        }

        public void BeforeMount()
        {
            //throw new NotImplementedException();
        }

        public bool LeaveCheck()
        {            
            ShopManager.ShiftCb1StartTime = comboBox1.SelectedItem.ToString();
            ShopManager.ShiftCb2Interval = comboBox2.SelectedItem.ToString();
            ShopManager.ShiftCb3Amount = comboBox3.SelectedItem.ToString();

            return true;
        }

        private void ShiftConfiguration_Load(object sender, EventArgs e)
        {

            //comboBox1
            var item = DateTime.Today.AddHours(0); // 00:00:00
            while (item <= DateTime.Today.AddHours(23).AddMinutes(45))
            {
                this.comboBox1.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                item = item.AddMinutes(15);
            }

            if (ShopManager.ShiftCb1StartTime == "")//for the first time
            {
                comboBox1.SelectedIndex = 32;//08:00
            }
            else
            {
                comboBox1.SelectedIndex = comboBox1.FindString(ShopManager.ShiftCb1StartTime);
            }


            //comboBox2
            DateTime startTime = DateTime.Parse(comboBox1.SelectedItem.ToString());
            DateTime endTime = DateTime.Today.AddHours(24).AddMinutes(0);
            Console.WriteLine(startTime.ToString());

            TimeSpan span = endTime.Subtract(startTime);
            Console.WriteLine("Time Difference (minutes): " + span.TotalMinutes);
            if ((int)span.TotalMinutes >= 15)
            {
                comboBox2.Items.Add(15 + "分鐘");
            }
            if ((int)span.TotalMinutes >= 30)
            {
                comboBox2.Items.Add(30 + "分鐘");
            }
            if ((int)span.TotalMinutes >= 45)
            {
                comboBox2.Items.Add(45 + "分鐘");
            }


            double interval = 60;
            while (interval <= span.TotalMinutes)
            {
                comboBox2.Items.Add(interval + "分鐘");
                interval += 60;
            }
            if (ShopManager.ShiftCb2Interval == "")//for the first time
            {
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                comboBox2.SelectedIndex = comboBox2.FindString(ShopManager.ShiftCb2Interval);
            }



            //cb 3
            string[] list = comboBox2.SelectedItem.ToString().Split('分');
            Console.WriteLine(list[0].ToString());
            int count = (int)span.TotalMinutes / int.Parse(list[0]);
            int i = 1;
            while (i <= count)
            {
                comboBox3.Items.Add(i);
                i++;
            }
            if (ShopManager.ShiftCb3Amount == "")
            {
                comboBox3.SelectedIndex = 0;
            }
            else
            {
                comboBox3.SelectedIndex = comboBox3.FindString(ShopManager.ShiftCb3Amount);
            }
        }
    }
}
