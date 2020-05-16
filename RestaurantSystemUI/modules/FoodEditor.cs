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
    public partial class FoodEditor : UserControl, IThemeable
    {


        public event EventHandler EditorExited;

        private List<FoodVarientEditor> fvs = new List<FoodVarientEditor>();
        
        private Bitmap foodImage;
        private Food food;
        
        
        public FoodEditor()
        {
            InitializeComponent();
            // new food
            food = new Food(){                
                SelectedVarientIndex = -1
            };

            pbFoodImage.Image = Properties.Resources.DefaultFoodImage;
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
            
            FoodVarientEditor fv = new FoodVarientEditor();
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
            
            pbFoodImage.Image = foodImage;
            
            if(foodImage == null)
            {
                pbFoodImage.Image = Properties.Resources.DefaultFoodImage;
            }
        }

        private void FoodEditor_Load(object sender, EventArgs e)
        {
            addAnotherVarient();
            ApplyTheme();
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

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
            tagInput1.BackColor = BackColor;

            // textboxes
            ftbBasePrice.BackColor = BackColor;
            ftbName.BackColor = BackColor;

           

        }
    }
}