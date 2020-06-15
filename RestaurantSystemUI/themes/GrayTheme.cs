using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.themes
{
    class GrayTheme : ColorTheme
    {
        public GrayTheme(){
            // name
            name = "時尚灰";

            // accent colors
            mainAccent = Color.FromArgb(149, 165, 166);
            mainAcceintDerivative = Color.FromArgb(127, 140, 141);
        }
    }
}
