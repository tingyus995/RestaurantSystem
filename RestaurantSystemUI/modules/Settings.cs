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
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace RestaurantSystemUI.modules
{
    public partial class Settings : UserControl, IThemeable, IAdminView
    {
        public event EventHandler ShopInfoUpdated;

        ThemeSelector themeSelector;
        Image logo;
        
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tbShopName.textBox.Text = ShopManager.ShopName;
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
            ShopManager.ShopName = tbShopName.textBox.Text;

            if (logo != null)
            {
                ShopManager.ShopLogo = Utility.ImageToBase64(logo);
            }

            ShopInfoUpdated?.Invoke(this, new EventArgs());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            logo = Utility.GetImageFromUser();

            ImageCropper cropper = new ImageCropper(logo);
            Utility.ShowFullSpaceDialog(this, cropper);

            cropper.SubmitButtonClicked += Cropper_SubmitButtonClicked;
        }

        private void Cropper_SubmitButtonClicked(object sender, EventArgs e)
        {
            ImageCropper cropper = sender as ImageCropper;
            logo = cropper.CroppedImage;
            pictureBox1.Image = cropper.CroppedImage;
            Controls.Remove(cropper);
        }

        private void AddFoods_Click(object sender, EventArgs e)
        {
            BatchFoodImportTool tool = new BatchFoodImportTool();
            tool.ShowDialog();
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if(oldPwd.textBox.Text == "")
            {
                MessageBox.Show("請輸入舊密碼。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (newPwd.textBox.Text == "")
            {
                MessageBox.Show("請輸入新密碼。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(vertPwd.textBox.Text == "")
            {
                MessageBox.Show("請輸入確認密碼。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(vertPwd.textBox.Text != newPwd.textBox.Text)
            {
                MessageBox.Show("確認密碼不符合。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
            if (Utility.Sha1Hash(oldPwd.textBox.Text) == ShopManager.ShopPassword)
            {

                ShopManager.ShopPassword = Utility.Sha1Hash(newPwd.textBox.Text);
                MessageBox.Show("新密碼設定完成。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldPwd.textBox.Text = "";
                newPwd.textBox.Text = "";
                vertPwd.textBox.Text = "";
            }
            else
            {
                MessageBox.Show("舊密碼錯誤。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oldPwd.textBox.Text = "";                    
            }
            
        }       
        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;

            foreach(TabPage tc in tabControl1.TabPages)
            {
                tc.BackColor = theme.ContentPanel;
            }
            // panels used to hide borders of tab control
            panel1.BackColor = theme.ContentPanel; // left
            panel2.BackColor = theme.ContentPanel; // right
            panel3.BackColor = theme.ContentPanel; // bottom

            // background of theme selector
            themeSelector.BackColor = theme.ContentPanel;

            // flat text boxes
            tbShopName.BackColor = theme.ContentPanel;
            oldPwd.BackColor = theme.ContentPanel;
            newPwd.BackColor = theme.ContentPanel;
            vertPwd.BackColor = theme.ContentPanel;
        }
        private void btnApplyTheme_Click(object sender, EventArgs e)
        {
            ShopManager.ShopThemeName = themeSelector.SelectedThemeName;

            MessageBox.Show("主題已變更成功！將在程式重新啟動後套用。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if ( DialogResult.Yes ==  MessageBox.Show("該功能將會清除系統內所有的資料且無法被復原，您確定要繼續嗎？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                ConfirmWindow confirmWindow = new ConfirmWindow();
                confirmWindow.ShowDialog();

                if (confirmWindow.Confirmed)
                {
                    File.Delete("data.db");
                    Application.Restart();
                }
            }
        }
    }
}
