using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.themes
{
    class EmraldTheme : ColorTheme
    {

        public EmraldTheme() { 
            // name
            name = "草地綠";

            // accent colors
            mainAccent = Color.FromArgb(46, 204, 113);
            mainAcceintDerivative = Color.FromArgb(39, 174, 96);
        }
    }
}
