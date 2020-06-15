using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.themes
{
    class GreenTheme : ColorTheme
    {
        public GreenTheme(){
            // name
            name = "松柏綠";

            // accent colors
            mainAccent = Color.FromArgb(26, 188, 156);
            mainAcceintDerivative = Color.FromArgb(22, 160, 133);
        }
    }
}
