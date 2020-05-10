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
    public partial class FoodVarientEditor : UserControl
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

                try
                {

                    varient.Name = ftbName.textBox.Text;
                    varient.delta = int.Parse(ftbDelta.textBox.Text.Trim());
                    varient.image = Utility.ImageToBytes(foodImage);

                    return varient;

                }
                catch
                {
                    return null;
                }
            
            }
            set { varient = value; updateUI(); }
        }
        
        public FoodVarientEditor()
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
            ftbDelta.textBox.KeyPress += handleKeyPress;
            ftbDelta.LostFocus += FtbDelta_LostFocus;
            //flatTbName.Focus();
        }

        private void FtbDelta_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void setSign(char sign)
        {
            TextBox tb = ftbDelta.textBox;
            int idx = tb.SelectionStart;
            
            if (tb.Text.Length == 0)
            {
                tb.Text = sign.ToString();
                tb.SelectionStart = 1;
                return;
            }

            if (!Char.IsDigit(tb.Text[0]))
            {
                tb.Text = sign.ToString() + tb.Text.Substring(1);
                tb.SelectionStart = idx;
                return;
            }
            else { 
                tb.Text = sign.ToString() + tb.Text;
                tb.SelectionStart = (idx + 1);
            }
        }

        private void handleKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            
            if (Char.IsDigit(e.KeyChar))
            {
                if (tb.Text.Length == 1 && !Char.IsDigit(tb.Text[0])) tb.SelectionStart = 1;
                return;
            }
            if (Char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }
        private void handleKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {   
                case Keys.Enter:
                    RequireAnotherVarient?.Invoke(this, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true; // avoid that ding sound
                    return;
                
                case Keys.Add: // handle plus
                case Keys.Oemplus:
                    setSign('+');
                    e.Handled = true;
                    return;                    
                case Keys.Subtract: // handle minus
                case Keys.OemMinus:
                    setSign('-');
                    e.Handled = true;
                    return;
            }
        }
    }
}