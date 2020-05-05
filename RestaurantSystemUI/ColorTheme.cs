using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI
{
    public class ColorTheme
    {
        //private static Color mainColor = Color.FromArgb(52, 73, 94);
        //private static Color mainColorDark = Color.FromArgb(29, 42, 54);


        //26,188,156

        private static Color mainColor = Color.FromArgb(26, 188, 156);
        private static Color mainColorDark = Color.FromArgb(22, 160, 133);
        public Color Contrast = Color.White;

        private static Color Darken(Color c, int amount)
        {

            int a = c.A;
            int r = c.R - amount;
            int g = c.G - amount;
            int b = c.B - amount;


            if (r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;

            return Color.FromArgb(a, r, g, b);
        }

        private static Color Lighten(Color c, int amount)
        {

            int a = c.A;
            int r = c.R + amount;
            int g = c.G + amount;
            int b = c.B + amount;


            if (r > 255) r = 0;
            if (g > 255) g = 0;
            if (b > 255) b = 0;

            return Color.FromArgb(a, r, g, b);
        }

        // menu-related

        public Color MainMenuBar = mainColor;
        
        public Color MainMenuItem = mainColor;
        public Color MainMenuItemMouseOver = Lighten(mainColor, 20);
        public Color MainMenuItemMouseDown = Darken(mainColor, 20);
        public Color MainMenuItemSelected = Lighten(mainColor, 20);

        // content

        public Color ContentPanel = mainColorDark;

        // controls

        // flatTextbox

        public Color Placeholder = Darken(Color.White, 50);







    }
}
