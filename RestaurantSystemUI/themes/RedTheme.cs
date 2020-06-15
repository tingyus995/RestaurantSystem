using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.themes
{
    class RedTheme : ColorTheme
    {
        public RedTheme(){
            // name
            name = "熱情紅";

            // accent colors
            mainAccent = Color.FromArgb(231, 76, 60);
            mainAcceintDerivative = Color.FromArgb(192, 57, 43);
        }
    }
}
