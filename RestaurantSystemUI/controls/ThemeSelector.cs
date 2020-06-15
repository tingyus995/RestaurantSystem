using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig.Extensions.Tables;
using RestaurantSystemCore;

namespace RestaurantSystemUI.controls
{
    public partial class ThemeSelector : UserControl
    {

        public string SelectedThemeName { get; set; } = "";
        private List<RadioButton> radioButtons = new List<RadioButton>();
        public ThemeSelector()
        {
            InitializeComponent();
        }

        private void ThemeSelector_Load(object sender, EventArgs e)
        {
            ColorTheme[] themes = ThemeProvider.GetAllThemes();
            string currentTheme = ShopManager.ShopThemeName;

            foreach (ColorTheme theme in themes)
            {

                Panel item = new Panel();
                RadioButton rb = new RadioButton() { 
                    Text = theme.Name, 
                    ForeColor = Color.White, 
                    Font = new Font("Microsoft JhengHei UI", 16f, FontStyle.Bold), 
                    AutoSize=true
                };
                radioButtons.Add(rb);
                rb.CheckedChanged += Rb_CheckedChanged;
                ThemePreviewItem pi = new ThemePreviewItem(theme);

                item.Controls.Add(rb);
                item.Controls.Add(pi);

                pi.Top += rb.Height + 5;

                item.Height = pi.Top + pi.Height + 5;
                item.Width = pi.Width + 5;

                //item.BackColor = Color.Red;

                flowLayoutPanel1.Controls.Add(item);

                if (theme.name == currentTheme) rb.Checked = true;
                
            }
            
            if(currentTheme == "")
            {
                RadioButton rb = (RadioButton)flowLayoutPanel1.Controls[0].Controls[0];
                rb.Checked = true;
            }

        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                SelectedThemeName = rb.Text;

                foreach(RadioButton r in radioButtons)
                {
                    if(r != rb)
                    {
                        r.Checked = false;
                    }
                }

            }
            
        }
    }
}
