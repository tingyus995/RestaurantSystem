using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemUI.modules;

namespace RestaurantSystemUI.OOBE_pages
{
    public partial class BasicInfo : UserControl, IOOBEPage
    {
        public BasicInfo()
        {
            InitializeComponent();
        }

        public void BeforeMount()
        {
            
        }

        public bool LeaveCheck()
        {

            List<string> errorMsg = new List<string>();
            

            if (flatTextbox1.textBox.Text.Trim().Length == 0)
            {
                errorMsg.Add("請輸入店家名稱。");
            }

            if(pictureBox1.Image == null)
            {
                errorMsg.Add("請選擇店家 logo。");
            }

            if(errorMsg.Count > 0)
            {
                MessageBox.Show(String.Join("\n", errorMsg.ToArray()), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            

            return true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Bitmap logo = Utility.GetImageFromUser();

            ImageCropper cropper = new ImageCropper(logo);            
            Utility.ShowFullSpaceDialog(this, cropper);

            cropper.SubmitButtonClicked += Cropper_SubmitButtonClicked;
            
        }

        private void Cropper_SubmitButtonClicked(object sender, EventArgs e)
        {
            ImageCropper cropper = sender as ImageCropper;
            pictureBox1.Image = cropper.CroppedImage;
            Controls.Remove(cropper);
        }
    }
}
