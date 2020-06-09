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

namespace RestaurantSystemUI.controls
{
    public partial class TagInput : UserControl
    {
        private List<string> tags = new List<string>();

        public string[] Tags {
            get {
                return tags.ToArray();
            }

            set
            {
                foreach(string tag in value)
                {
                    AddTag(tag);
                }
            }
        }

        public TagInput()
        {
            InitializeComponent();
        }

        private void TagInput_Load(object sender, EventArgs e)
        {
            ThemedIconButton plusBtn = new ThemedIconButton();
            plusBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            flatTextbox1.Controls.Add(plusBtn);
            plusBtn.Left = flatTextbox1.Width - plusBtn.Width;
            plusBtn.Top = flatTextbox1.Height - plusBtn.Height / 2;
            plusBtn.Click += handlePlusButton;

            flatTextbox1.textBox.KeyDown += handleKeyDown;
            flatTextbox1.Height = new CategoryItem().Height;
        }

        private void AddTag(string tagText)
        {
            if (tags.IndexOf(tagText) >= 0)
            {
                MessageBox.Show("分類名稱重複。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tags.Add(tagText);

            flowLayoutPanel1.Controls.Add(new CategoryItem()
            {
                Category = new Category()
                {
                    Name = tagText
                }
            });

            flowLayoutPanel1.Controls.SetChildIndex(flatTextbox1, flowLayoutPanel1.Controls.Count - 1);

            flowLayoutPanel1.ScrollControlIntoView(flatTextbox1);
        }

        private void handlePlusButton(object sender, EventArgs e)
        {
            string tagText = flatTextbox1.textBox.Text.Trim();

            if (tagText.Length == 0) return;

            AddTag(tagText);

            flatTextbox1.textBox.Text = "";
        }


       

        private void handleKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                string tagText = flatTextbox1.textBox.Text.Trim();

                if (tagText.Length == 0) return;

                AddTag(tagText);
                    
                flatTextbox1.textBox.Text = "";

                e.Handled = true;
                e.SuppressKeyPress = true;
                
            }

            else if (e.KeyCode == Keys.Back && flatTextbox1.textBox.Text.Length == 0)
            {
                if(flowLayoutPanel1.Controls.Count >= 2) { 
                    int lastIndex = flowLayoutPanel1.Controls.Count -2;
                    tags.RemoveAt(lastIndex);
                    flowLayoutPanel1.Controls.RemoveAt(lastIndex);
                }
            }
        }

        private void TagInput_BackColorChanged(object sender, EventArgs e)
        {
            flatTextbox1.BackColor = BackColor;
        }
    }
}
