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
    public partial class FoodList : UserControl, IThemeable
    {

        private string selectedCategoryName;
        private const string ALL_CATEGORIES = "全部分類";

        public FoodList()
        {
            InitializeComponent();
        }

        private void activateCategory(CategoryItem c)
        {
            foreach(CategoryItem cat in fpnCategories.Controls)
            {
                cat.Active = false;
            }
            c.Active = true;
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
                },
                Editable = false
            };

            allCats.CategoryItemClicked += CategoryItem_Click;
            fpnCategories.Controls.Add(allCats);


            Category[] categories = FoodManager.GetCategories();
            foreach (Category cat in categories)
            {
                CategoryItem item = new CategoryItem() { Category = cat };
                item.CategoryItemClicked += CategoryItem_Click;
                /*item.CategoryNameUpdated += (object _s, EventArgs _e) => {
                    if( FoodManager.EditCategory())
                }*/
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
            activateCategory(item);

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

                foodItem.DeleteFoodClicked += (object _s, EventArgs _e) =>
                {                    
                    FoodItem it = _s as FoodItem;

                    if(DialogResult.OK == MessageBox.Show(
                        String.Format("您確定要刪除{0}嗎? \n刪除後將無法復原。", it.Food.Name), 
                        "警告", 
                        MessageBoxButtons.OKCancel, 
                        MessageBoxIcon.Warning
                    )){
                        FoodManager.DeleteFood(it.Food);
                        loadData();
                    }                   

                };

                fpnFoodItems.Controls.Add(foodItem);
            }
        }

        private void ibtnAddFood_Click(object sender, EventArgs e)
        {
            FoodEditor editor = new FoodEditor();
            
            editor.EditorExited += (object __s, EventArgs __e) =>
            {
                loadData();
            };
            Utility.ShowFullSpaceDialog(this, editor);
        }

        


        private void fpnFoodItems_Resize(object sender, EventArgs e)
        {

            /*Control pn = sender as Control;

            if (pn.Controls.Count == 0) return;

            int amount = pn.ClientSize.Width / (400 + 6);

            if (amount == 0) return;

            pn.SuspendLayout();
            foreach(Control c in fpnFoodItems.Controls)
            {
                c.MinimumSize = new Size((fpnFoodItems.ClientSize.Width / amount - (c.Margin.Left + c.Margin.Right)) - 10, c.Height);
            }
            pn.ResumeLayout();*/
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
        }
    }
}