using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI
{
    public static class ThemeProvider
    {
		private static ColorTheme colorTheme = new ColorTheme();

        public static ColorTheme GetTheme() { return colorTheme; }

        public static void ChangeTheme(ColorTheme theme)
        {
            colorTheme = theme;
        }
	}
}
