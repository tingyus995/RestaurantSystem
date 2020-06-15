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
    public partial class FoodItem : UserControl, IThemeable
    {

        private Food food;

        public event EventHandler EditFoodClicked;
        public event EventHandler DeleteFoodClicked;
        public event EventHandler<FoodSelectedEventArgs> FoodSelected;


        private bool showPlusButton = false;
        private bool showEditButton = false;


        public Food Food
        {
            get { return food; }
            set { food = value; updateUI(); }
        }

        private void updateUI()
        {
            lbFoodName.Text = Food.Name;
            lbPrice.Text = Food.BasePrice.ToString();
            pictureBox1.Image = Utility.BytesToImage(food.Image);

            if(pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.DefaultFoodImage;
            }

            foreach(Varient v in food.Varients)
            {
                FoodVarientItem item = new FoodVarientItem()
                {
                    VarientName = v.Name,
                    Price = food.BasePrice + v.delta,
                    ShowPlusButton = showPlusButton
                };
                
                fpnVarients.Controls.Add(item);

                item.PlusButtonClicked += (object _s, EventArgs _e) =>
                {
                    FoodVarientItem it = _s as FoodVarientItem;
                    food.SelectedVarientIndex = fpnVarients.Controls.IndexOf(it);
                    FoodSelected?.Invoke(this, new FoodSelectedEventArgs(food));
                };
               
            }

        }

        public FoodItem()
        {
            InitializeComponent();
        }

        public FoodItem(bool plusbtn, bool editBtn)
        {
            InitializeComponent();

            showPlusButton = plusbtn;
            showEditButton = editBtn;

            if (!showEditButton)
            {
                btnEdit.Visible = showEditButton;
                btnDelete.Visible = showEditButton;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditFoodClicked?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFoodClicked?.Invoke(this, e);
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.FoodItem;
        }

        private void FoodItem_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }
    }

    public class FoodSelectedEventArgs : EventArgs
    {
        public FoodSelectedEventArgs(Food f)
        {
            SelectedFood = f;        
        }

        public Food SelectedFood { get; set; }
    }
}
