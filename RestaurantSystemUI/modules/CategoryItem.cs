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

namespace RestaurantSystemUI
{

    public partial class CategoryItem : UserControl
    {

        Color normal = Color.FromArgb(52, 73, 94);
        Color normalLeft = Color.FromArgb(66, 93, 119);

        Color activated = Color.FromArgb(243, 156, 18); 
        Color activatedLeft = Color.FromArgb(241, 196, 15);


        public event EventHandler CategoryItemClicked;

        private bool editable = true;

        public bool Editable
        {
            get { return editable; }
            set { 
                editable = value;
                ibtnEdit.Visible = editable;            
            }
        }

        private bool active = false;
        
        public bool Active
        {
            get { return active; }
            set { 
                active = value;

                if (active)
                {
                    BackColor = activated;
                    pnDecoration.BackColor = activatedLeft;
                    ibtnEdit.BackColor = activated;
                }
                else
                {
                    BackColor = normal;
                    pnDecoration.BackColor = normalLeft;
                    ibtnEdit.BackColor = normal;
                }
            
            }
        }

        
        public Category Category {get; set; }
        public CategoryItem()
        {   
            InitializeComponent();
        }

        private void CategoryItem_Load(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
            lbCatName.Text = Category.Name;
        }

        private void ibtnEdit_Click(object sender, EventArgs e)
        {

            FlatTextbox ftb = new FlatTextbox();
            ftb.textBox.Text = Category.Name;
            Controls.Add(ftb);
            ftb.Left = 10;
            ftb.Top = 10;

            ftb.BringToFront();


            ftb.textBox.LostFocus += (object _s, EventArgs _e) =>
            {

                TextBox tb = _s as TextBox;

                string text = tb.Text.Trim();


                if (text.Length >= 0)
                {
                    if(!FoodManager.EditCategory(Category.Name, text))
                    {
                        MessageBox.Show("同名稱的類別已經存在。", "改名失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Category.Name = text;
                        lbCatName.Text = Category.Name;
                    }
                    
                }

                Controls.Remove(ftb);
            };
        }

        private void handleClick()
        {
            CategoryItemClicked?.Invoke(this, new EventArgs());
        }

        private void pnDecoration_Click(object sender, EventArgs e)
        {
            handleClick();
        }

        private void lbCatName_Click(object sender, EventArgs e)
        {
            handleClick();
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            handleClick();
        }
    }
}
