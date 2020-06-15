using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.themes
{
    class YelloTheme : ColorTheme
    {
        public YelloTheme(){
            // name
            name = "陽光黃";

            // accent colors
            mainAccent = Color.FromArgb(241, 196, 15);
            mainAcceintDerivative = Color.FromArgb(243, 156, 18);
        }
    }
}
