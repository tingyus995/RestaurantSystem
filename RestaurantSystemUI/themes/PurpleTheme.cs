using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RestaurantSystemUI.themes
{
    class PurpleTheme : ColorTheme
    {
        public PurpleTheme()
        {
            // name
            name = "高尚紫";

            // accent colors
            mainAccent = Color.FromArgb(155, 89, 182);
            mainAcceintDerivative = Color.FromArgb(142, 68, 173);

        }
    }
}
