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

        private string selectedCategoryName;
        private const string ALL_CATEGORIES = "全部分類";

        public FoodList()
        {
            InitializeComponent();
        }

        private void loadData()
        {

            fpnCategories.Controls.Clear();
            fpnFoodItems.Controls.Clear();

            // all category
            CategoryItem allCats = new CategoryItem() {
                Category = new Category()
                {
                    Name = ALL_CATEGORIES,
                    Amount = -1
                }
            };

            allCats.Click += CategoryItem_Click;
            fpnCategories.Controls.Add(allCats);


            Category[] categories = FoodManager.GetCategories();
            foreach (Category cat in categories)
            {
                CategoryItem item = new CategoryItem() { Category = cat };
                item.Click += CategoryItem_Click;
                fpnCategories.Controls.Add(item);
            }

            if(selectedCategoryName != null)
            {
                loadCategory(selectedCategoryName);
            }
        }

        private void loadCategory(string cat)
        {
            foreach(CategoryItem item in fpnCategories.Controls)
            {
                if(item.Category.Name == cat)
                {
                    CategoryItem_Click(item, new EventArgs());

                    return;
                }
            }
        }

        private void FoodList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            CategoryItem item = sender as CategoryItem;

            selectedCategoryName = item.Category.Name;
            
            Food[] foods;
            
            if (item.Category.Name == ALL_CATEGORIES)            
                foods = FoodManager.GetFoods();
            else
                foods = FoodManager.GetFoods(item.Category.Name);

            fpnFoodItems.Controls.Clear();

            foreach(Food f in foods)
            {
                FoodItem foodItem = new FoodItem() { Food = f };
                foodItem.EditFoodClicked += (object _s, EventArgs _e) => {
                    //FoodItem it = _s as FoodItem;
                    FoodEditor editor = new FoodEditor(f);

                    editor.EditorExited += (object __s, EventArgs __e) =>
                    {
                        loadData();
                    };

                    Utility.ShowFullSpaceDialog(this, editor);
                    
                };
                fpnFoodItems.Controls.Add(foodItem);
            }
        }
    }
}
