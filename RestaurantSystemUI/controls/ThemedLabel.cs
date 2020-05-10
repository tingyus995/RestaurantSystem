using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI.controls
{
    class ThemedLabel : Label
    {
        public ThemedLabel()
        {
            ForeColor = Color.White;
            Font = new Font("Microsoft JhengHei UI", 16f,FontStyle.Bold);
            AutoSize = true;
        }
    }
}
