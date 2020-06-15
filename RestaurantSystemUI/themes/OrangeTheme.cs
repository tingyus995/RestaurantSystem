using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.themes
{
    class OrangeTheme : ColorTheme
    {
        public OrangeTheme(){
            // name
            name = "落日橘";

            // accent colors
            mainAccent = Color.FromArgb(230, 126, 34);
            mainAcceintDerivative = Color.FromArgb(211, 84, 0);
        }
    }
}
