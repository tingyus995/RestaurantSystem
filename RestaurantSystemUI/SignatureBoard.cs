using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    public partial class SignatureBoard : Form
    {
        public SignatureBoard()
        {
            InitializeComponent();
        }

        bool submitted = false;

        public bool Authenticated { get
            {
                return submitted;
            }
        }



        private Color penColor;

        public Color PenColor
        {
            get { return penColor; }
            set { penColor = value; pen.Color = value; brush = new SolidBrush(value); fixedPen.Color = value; }
        }

        private int point; //筆的粗細

        public int Point
        {
            get { return point; }
            set { point = value; pen.Width = value; }            
        }

        Pen pen;
        Pen fixedPen; // for border
        Brush brush;
        internal double length = 0;



        internal Bitmap bmp = new Bitmap(667, 379);
        Bitmap display;
        int oldX;
        int oldY;

        private void SignatureBoard_Load(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            canvas.Image = bmp;
            CurrentColor.BackColor = Color.Black;

            // initialize
            pen = new Pen(PenColor, point);
            fixedPen = new Pen(PenColor, 1);
            brush = new SolidBrush(PenColor);
            Thickness.Value = 10;
            Point = Thickness.Value;

            PenColor = Color.Black;
            Submit.Visible = false;
            
        }

        private void CurrentColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if(colorDialog1.Color.R>200 && colorDialog1.Color.G > 200 && colorDialog1.Color.B > 200)
                {
                    MessageBox.Show("您選擇的顏色太淺");
                }
                else
                {
                    CurrentColor.BackColor = colorDialog1.Color;
                    PenColor = colorDialog1.Color;
                }
                
            }
        }

        private void Thickness_Scroll(object sender, EventArgs e)
        {
            Point = Thickness.Value;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

            int half = point / 2;
            if (e.Button == MouseButtons.Left)
            {
                
                Graphics g = Graphics.FromImage(bmp);
                length += Distance(e.X-oldX, e.Y-oldY);

                // draw eclipse at beginning and end, connect them with line to mitigate weird "crayon effect" ;)                

                g.FillEllipse(brush, oldX - half, oldY - half, point, point);
                g.DrawLine(pen, oldX, oldY, e.X, e.Y);
                g.FillEllipse(brush, e.X - half, e.Y - half, point, point);

                canvas.Image = bmp;


                if (length >= 200)
                {
                    Submit.Visible = true;
                }
                // update old location
                oldX = e.X;
                oldY = e.Y;
                
            }
            else
            {
                
                // if not drawing, we put a circle to indicate it's a drawing pen
                display = (Bitmap) bmp.Clone();

                Graphics g = Graphics.FromImage(display);

               
                g.DrawEllipse(fixedPen , e.X - half, e.Y - half, point, point);

                // update image
                canvas.Image = display;

                
                
            }
        }

        private void canvas_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void canvas_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            submitted = true;
            this.Close();
        }
        private double Distance(int dx, int dy)
        {
            double squared = Math.Pow(dx, 2) + Math.Pow(dy, 2);
            return Math.Sqrt(squared);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            Submit.Visible = false;
            length = 0;            
            //g.FillRectangle(Brushes.White, 0, 0, 667, 379);
            canvas.Image = bmp;
        }
    }
}
