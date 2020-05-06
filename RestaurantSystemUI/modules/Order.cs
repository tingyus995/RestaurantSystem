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
using RestaurantSystemCore.models;

namespace RestaurantSystemUI
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {   
            cbFood.Items.AddRange(new string[] {"A", "B", "C" });

            FoodManager fm = new FoodManager();
            Category[] cats = fm.GetCategories();

            foreach(var c in cats)
            {
                fpCategories.Controls.Add(new CategoryItem(c));
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
