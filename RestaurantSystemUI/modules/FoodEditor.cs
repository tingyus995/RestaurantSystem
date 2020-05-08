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


        public event EventHandler EditorExited;

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

            // food image
            //FoodImage = Utility.BytesToImage(food.Image);
            foodImage = Utility.BytesToImage(food.Image);

            if(foodImage == null)
            {
                MessageBox.Show("food image is null.");
            }
            
            
            pbFoodImage.Image = foodImage;
            
            if(foodImage == null)
            {
                pictureBox1.Image = Properties.Resources.DefaultFoodImage;
            }
        }

        private void FoodEditor_Load(object sender, EventArgs e)
        {
            addAnotherVarient();
            //pbFoodImage.Image = Properties.Resources.
            //pbFoodImage.Image = Properties.Resources.DefaultFoodImage;
            //pbFoodImage.InitialImage = Properties.Resources.DefaultFoodImage;
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
                if(fv.Varient != null)
                    varients.Add(fv.Varient);
            }

            // assign new value
            food.Name = ftbName.textBox.Text;
            food.BasePrice = int.Parse(ftbBasePrice.textBox.Text.Trim());
            food.Varients = varients.ToArray();
            food.Image = Utility.ImageToBytes(foodImage);
            food.Categories = tagInput1.Tags;

            FoodManager.UpdateOrSaveFood(food);

            EditorExited?.Invoke(this, new EventArgs());
            this.Parent.Controls.Remove(this);
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            EditorExited?.Invoke(this, new EventArgs());
            Parent.Controls.Remove(this);
        }

        private void pbFoodImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Utility.GetSupportedImageFilter();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foodImage = new Bitmap(openFileDialog1.FileName);
                    pbFoodImage.Image = foodImage;
                }catch
                {
                    MessageBox.Show("檔案開啟時發生錯誤。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}