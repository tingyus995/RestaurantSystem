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
    public partial class OrderViewFoodItem : UserControl
    {
        public event EventHandler FoodAmountChanged;
        private Food food;

        private Bitmap thumbnail;

        private bool showRemoveIcon = false;

        public bool ShowRemoveIcon
        {
            get { return showRemoveIcon; }
            set {
                showRemoveIcon = value;

                btnRemove.Visible = showRemoveIcon;            
            }
        }



        public Food Food
        {
            get { return food; }
            set { food = value; 
                lbFoodName.Text = Food.Name;
                lbVarientName.Text = Food.Varients[Food.SelectedVarientIndex].Name;
                lbPrice.Text = (Food.BasePrice + Food.Varients[Food.SelectedVarientIndex].delta).ToString();
                lbAmount.Text = Food.Amount.ToString() + "x ";
                Amount = food.Amount;
                thumbnail = Utility.BytesToImage(Food.Varients[Food.SelectedVarientIndex].image);

                if(thumbnail == null)
                {
                    thumbnail = Utility.BytesToImage(Food.Image);
                }

                if(thumbnail == null)
                {
                    thumbnail = Properties.Resources.DefaultFoodImage;
                }

                pictureBox1.Image = thumbnail;

            }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value;
                lbAmount.Text = Amount.ToString() + "x ";
                food.Amount = amount;
            }
        }


        public OrderViewFoodItem()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Amount -= 1;
            FoodAmountChanged?.Invoke(this, new EventArgs());
            
            if(Amount == 0)
            {
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
