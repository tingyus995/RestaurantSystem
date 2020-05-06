using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI.controls
{
    public partial class TagInput : UserControl
    {
        List<string> tags = new List<string>();

        public TagInput()
        {
            InitializeComponent();
        }

        private void TagInput_Load(object sender, EventArgs e)
        {

            flatTextbox1.textBox.KeyDown += handleKeyDown;
            flatTextbox1.Height = new CategoryItem(new RestaurantSystemCore.models.Category()).Height;
        }

        private void handleKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                string tagText = flatTextbox1.textBox.Text.Trim();

                if (tagText.Length == 0) return;

                if (tags.IndexOf(tagText) >= 0)
                {
                    MessageBox.Show("分類名稱重複。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                
                
                tags.Add(tagText);

                flowLayoutPanel1.Controls.Add(new CategoryItem(new RestaurantSystemCore.models.Category()
                {
                    Name = tagText
                }));

                flatTextbox1.textBox.Text = "";

                flowLayoutPanel1.Controls.SetChildIndex(flatTextbox1, flowLayoutPanel1.Controls.Count - 1);

                flowLayoutPanel1.ScrollControlIntoView(flatTextbox1);


                
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
    }
}
