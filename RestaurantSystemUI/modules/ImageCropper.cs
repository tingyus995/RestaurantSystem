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

        private bool isDragging = false;
        int orgX;
        int orgY;

        public ImageCropper()
        {
            InitializeComponent();
        }

        public ImageCropper(Bitmap bmp)
        {
            InitializeComponent();
            pictureBox1.Image = bmp;
        }

        private void ImageCropper_Load(object sender, EventArgs e)
        {

        }
    }
}
