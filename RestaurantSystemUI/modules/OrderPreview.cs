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
    public partial class OrderView : UserControl
    {
        //private List<Food> foods = new List<Food>();
        public int Total { get; set; } = 0;

        private void AddOrUpdateFoodItem(Food f, int amount)
        {
            foreach (OrderPreviewFoodItem item in fpnFoodItems.Controls)
            {
                if (item.Food.Id == f.Id && item.Food.SelectedVarient == f.SelectedVarient)
                {
                    item.Amount += amount;
                    return;
                }
            }

            OrderPreviewFoodItem it = new OrderPreviewFoodItem()
            {
                Food = f,
                Amount = amount
            };

            it.FoodAmountChanged += (object _s, EventArgs _e) =>
            {
                updateTotal();
            };

            fpnFoodItems.Controls.Add(it);
        }

        public void AddFood(Food f, int amount = 1)
        {
            AddOrUpdateFoodItem(f, amount);
            updateTotal();
        }

        void updateTotal()
        {
            int result = 0;
            foreach(OrderPreviewFoodItem item in fpnFoodItems.Controls)
            {
                result += (item.Food.BasePrice + item.Food.Varients[item.Food.SelectedVarient].delta) * item.Amount;
                
            }

            Total = result;
            lbTotal.Text = string.Format("共{0} 元", Total.ToString());
        }
        
        
        public OrderView()
        {
            InitializeComponent();
        }

    }
}
