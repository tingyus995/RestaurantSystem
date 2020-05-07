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

namespace RestaurantSystemUI.modules
{
    public partial class FoodItem : UserControl
    {

        private Food food;


        public event EventHandler EditFoodClicked;
        public event EventHandler DeleteFoodClicked;

        public Food Food
        {
            get { return food; }
            set { food = value; updateUI(); }
        }

        private void updateUI()
        {
            lbFoodName.Text = Food.Name;
            lbPrice.Text = Food.BasePrice.ToString();
        }

        public FoodItem()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditFoodClicked?.Invoke(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFoodClicked?.Invoke(sender, e);
        }
    }
}
