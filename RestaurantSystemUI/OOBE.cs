using RestaurantSystemUI.OOBE_pages;
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
    public partial class OOBE : Form
    {

        List<UserControl> pages = new List<UserControl>();
        
        private int pageIndex = 0;
        public OOBE()
        {
            InitializeComponent();
        }

        private void pnPageIndicator_Paint(object sender, PaintEventArgs e)
        {

            Panel pn = sender as Panel;

            int startX = 0;
            int startY = 0;

            int deltaY = 10;
            int size = 10;

            int totalWidth = pages.Count * size + deltaY * (pages.Count - 1);
            startX = (pn.Width - totalWidth) / 2;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            
            
            for(int i = 0; i < pages.Count; ++i)
            {
                Brush brush;
                if (i == pageIndex) brush = Brushes.White;
                else brush = Brushes.Gray;

                g.FillEllipse(brush, startX, startY, size, size);
                startX += deltaY + size;
            }
        }

        private void UpdatePageIndicator()
        {            
            pnPageIndicator.Refresh();
        }

        private void LoadPage()
        {
            if(pnPageContainer.Controls.IndexOf(pages[pageIndex]) == -1)
            {
                pnPageContainer.Controls.Add(pages[pageIndex]);
            }

            pages[pageIndex].BringToFront();         
            UpdatePageIndicator();

            if (pageIndex == pages.Count - 1) btnNext.Visible = false;
            else btnNext.Visible = true;

            if (pageIndex == 0) btnPrev.Visible = false;
            else btnPrev.Visible = true;

        }

        bool NotifyPageChange()
        {
            UserControl page = pages[pageIndex];

            if(page is IOOBEPage)
            {
                IOOBEPage oobePage = page as IOOBEPage;
                return oobePage.LeaveCheck();                
            }

            return true;
        }

        private void NextPage()
        {
            if (NotifyPageChange())
            {
                ++pageIndex;
                LoadPage();
            }

        }

        private void PreviousPage()
        {
            
            --pageIndex;
            LoadPage();
            
        }

        private void OOBE_Load(object sender, EventArgs e)
        {
            // register pages
            pages.Add(new Welcome());
            pages.Add(new BasicInfo());
            pages.Add(new ShiftConfiguration());
            pages.Add(new AdminPassword());
            pages.Add(new FinalInstructions());
            

            LoadPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }
    }
}
