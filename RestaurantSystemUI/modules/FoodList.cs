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

namespace RestaurantSystemUI.modules
{
    public partial class FoodList : UserControl
    {
        public FoodList()
        {
            InitializeComponent();
        }

        private void FoodList_Load(object sender, EventArgs e)
        {
            Category[] categories = FoodManager.GetCategories();
            foreach(Category cat in categories)
            {
                CategoryItem item = new CategoryItem() { Category = cat };
                item.Click += CategoryItem_Click;
                fpnCategories.Controls.Add(item);
            }
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            CategoryItem item = sender as CategoryItem;

            Food[] foods = FoodManager.GetFoods(item.Category.Name);

            fpnFoodItems.Controls.Clear();

            foreach(Food f in foods)
            {
                FoodItem foodItem = new FoodItem() { Food = f };
                foodItem.EditFoodClicked += (object _s, EventArgs _e) => {
                    //FoodItem it = _s as FoodItem;
                    FoodEditor editor = new FoodEditor(f);
                    Utility.ShowFullSpaceDialog(this, editor);
                    
                };
                fpnFoodItems.Controls.Add(foodItem);
            }
        }
    }
}
