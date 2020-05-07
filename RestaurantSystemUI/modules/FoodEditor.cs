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
using RestaurantSystemUI;
using RestaurantSystemCore;
using System.Runtime.CompilerServices;

namespace RestaurantSystemUI.modules
{
    public partial class FoodEditor : UserControl
    {

        private List<FoodVarient> fvs = new List<FoodVarient>();        
        private Bitmap foodImage;
        private Food food;
        
        
        public FoodEditor()
        {
            InitializeComponent();
            // new food
            food = new Food(){                
                SelectedVarient = -1
            };
        }

        public FoodEditor(Food _food)
        {
            InitializeComponent();
            // edit food
            food = _food;
            updateUI();
        }


        private void addAnotherVarient(Varient v = null)
        {
            
            FoodVarient fv = new FoodVarient();
            if (v != null) fv.Varient = v;
            
            fvs.Add(fv);
            fv.RequireAnotherVarient += Fv_RequireAnotherVarient;
            fpVarients.Controls.Add(fv);
            fv.ftbName.textBox.Focus();
        }


        private void updateUI()
        {
            // name
            ftbName.textBox.Text = food.Name;
            // base price
            ftbBasePrice.textBox.Text = food.BasePrice.ToString();            
            // categories
            tagInput1.Tags = food.Categories;
            // varients
            foreach(Varient v in food.Varients)
            {
                addAnotherVarient(v);
            }            
        }

        private void FoodEditor_Load(object sender, EventArgs e)
        {
            addAnotherVarient();
        }


        private void Fv_RequireAnotherVarient(object sender, EventArgs e)
        {
            addAnotherVarient();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<Varient> varients = new List<Varient>();

            foreach(var fv in fvs)
            {
                varients.Add(fv.Varient);
            }

            // assign new value
            food.Name = ftbName.textBox.Text;
            food.BasePrice = int.Parse(ftbBasePrice.textBox.Text.Trim());
            food.Varients = varients.ToArray();
            food.Image = Utility.ImageToBytes(foodImage);
            food.Categories = tagInput1.Tags;

            FoodManager.UpdateOrSaveFood(food);
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}