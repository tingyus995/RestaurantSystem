using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI.modules
{
    public partial class ImageCropper : UserControl
    {

        public event EventHandler SubmitButtonClicked;

        public Image CroppedImage { get { return pbPreview.Image; } }
        public ImageCropper()
        {
            InitializeComponent();
        }

        public ImageCropper(Image image)
        {

            InitializeComponent();
            imageCropperBox1.PreviewImageChanged += ImageCropperBox1_PreviewImageChanged;
            imageCropperBox1.Image = image;
        }

        private void ImageCropperBox1_PreviewImageChanged(object sender, PreviewImageChangedArgs e)
        {
            pbPreview.Image = e.PreviewImage;
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SubmitButtonClicked?.Invoke(this, new EventArgs());
        }
    }
}
