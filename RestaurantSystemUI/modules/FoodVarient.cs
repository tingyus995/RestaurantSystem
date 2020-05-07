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
    public partial class FoodVarient : UserControl
    {
        public event EventHandler RequireAnotherVarient;

        private Varient varient;
        private Bitmap foodImage;


        public Varient Varient
        {
            get {
                if(varient == null)
                {
                    varient = new Varient();
                }
                

                varient.Name = ftbName.textBox.Text;
                varient.delta = int.Parse(ftbDelta.textBox.Text.Trim());
                varient.image = Utility.ImageToBytes(foodImage);

                return varient;
            
            }
            set { varient = value; updateUI(); }
        }
        
        public FoodVarient()
        {
            InitializeComponent();
        }

        private void updateUI()
        {
            ftbName.textBox.Text = varient.Name;
            ftbDelta.textBox.Text = varient.delta.ToString();
            pictureBox1.Image = Utility.BytesToImage(varient.image);
        }

        private void FoodVarient_Load(object sender, EventArgs e)
        {
            ftbDelta.textBox.KeyDown += handleKeyDown;
            ftbDelta.LostFocus += FtbDelta_LostFocus;
            //flatTbName.Focus();
        }

        private void FtbDelta_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void handleKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                RequireAnotherVarient?.Invoke(this, new EventArgs());
            }
        }
    }
}
