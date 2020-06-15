using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemCore;
using RestaurantSystemUI.controls;

namespace RestaurantSystemUI.modules
{
    public partial class Settings : UserControl, IThemeable
    {
        public event EventHandler ShopInfoUpdated;

        ThemeSelector themeSelector;
        Bitmap logo;
        
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            flatTextbox1.textBox.Text = ShopManager.ShopName;
            string logo_base64 = ShopManager.ShopLogo;
            if (logo_base64.Length > 0)
            {
                logo = Utility.Base64ToImage(logo_base64);
                pictureBox1.Image = logo;
            }


            themeSelector = new ThemeSelector();
            tabChangeTheme.Controls.Add(themeSelector);

            int topPad = btnApplyTheme.Top + btnApplyTheme.Height + 10;
            themeSelector.Location = new Point(0, topPad);
            themeSelector.Height = tabChangeTheme.Height - topPad;
            themeSelector.Width = tabChangeTheme.Width;
            themeSelector.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left;
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            ShopManager.ShopName = flatTextbox1.textBox.Text;
            
            if(ShopInfoUpdated != null)
            {
                ShopInfoUpdated(this, new EventArgs());
            }

            if(logo != null)
            {
                ShopManager.ShopLogo = Utility.ImageToBase64(logo);
            }
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if( DialogResult.OK == openFileDialog1.ShowDialog())
            {
                logo = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = logo;
                
            }
        }

        private void AddFoods_Click(object sender, EventArgs e)
        {
            BatchFoodImportTool tool = new BatchFoodImportTool();
            tool.ShowDialog();
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if (newPwd.textBox.Text != "")
            {

                if (oldPwd.textBox.Text == ShopManager.ShopPassword)
                {

                    ShopManager.ShopPassword = newPwd.textBox.Text;
                    MessageBox.Show("新密碼設定完成");
                    oldPwd.textBox.Text = "";
                    newPwd.textBox.Text = "";
                }
                else
                {
                    MessageBox.Show("無法設置新密碼");
                    oldPwd.textBox.Text = "";
                    newPwd.textBox.Text = "";
                }
            }
        }

        private void tabChangeTheme_Layout(object sender, LayoutEventArgs e)
        {
            
            
            
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;

            foreach(TabPage tc in tabControl1.TabPages)
            {
                tc.BackColor = theme.ContentPanel;
            }
            // borders
            panel1.BackColor = theme.ContentPanel;
            panel2.BackColor = theme.ContentPanel;
            panel3.BackColor = theme.ContentPanel;

            themeSelector.BackColor = theme.ContentPanel;
        }

        private void Settings_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(Pens.Red, new Rectangle(0, 0, 15, 15));
        }

        private void btnApplyTheme_Click(object sender, EventArgs e)
        {
            ShopManager.ShopThemeName = themeSelector.SelectedThemeName;

            MessageBox.Show("主題已變更成功！將在程式重新啟動後套用。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
