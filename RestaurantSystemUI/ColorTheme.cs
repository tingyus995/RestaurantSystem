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

        //private static Color mainAccent = Color.FromArgb(26, 188, 156);
        //private static Color mainAcceintDerivative = Color.FromArgb(22, 160, 133);
        private static Color mainAccent = Color.FromArgb(155, 89, 182);
        private static Color mainAcceintDerivative = Color.FromArgb(142, 68, 173);

        private static Color secondary = Color.FromArgb(155, 89, 182);
        private static Color secondaryDerivative = Color.FromArgb(142, 68, 173);

        private static Color Normal = Color.FromArgb(46, 204, 113);
        private static Color Dangerous = Color.FromArgb(231, 76, 60);
        private static Color Warning = Color.FromArgb(230, 126, 34);


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


            if (r > 255) r = 255;
            if (g > 255) g = 255;
            if (b > 255) b = 255;

            return Color.FromArgb(a, r, g, b);
        }

        // menu-related

        public Color MainMenuBar = mainAccent;        
        public Color MainMenuItem = mainAccent;
        public Color MainMenuItemMouseOver = Lighten(mainAccent, 20);
        public Color MainMenuItemMouseDown = Darken(mainAccent, 20);
        public Color MainMenuItemSelected = Lighten(mainAccent, 20);
        public Color TitleBar = Darken(mainAcceintDerivative, 10);

        // content

        public Color ContentPanel = mainAcceintDerivative;

        // category item
        public Color CategoryItem = mainAccent;
        public Color CategoryItemDecoration = Lighten(mainAccent, 20);
        public Color CategoryItemActive = secondary;
        public Color categoryItemActiveDecoration = Lighten(secondary, 20);

        // order view title
        public Color OrderViewTitle = secondary;
        public Color OrderViewBottom = secondaryDerivative;

        public Color OrderViewItemEven = Darken(secondaryDerivative, 10);
        public Color OrderViewItemOdd = Darken(secondaryDerivative, 20);

        

        //public Color OrderViewTitle = 

        // controls

        // flatTextbox

        public Color Placeholder = Darken(Color.White, 50);

        // shift
        public Color LateCard = Warning;
        public Color OnTimeCard = Normal;
        public Color MissingCard = Dangerous;

        public Color TimeSlotBackground = Darken(mainAccent, 40);
        public Color TimeSlotHover = mainAccent;










    }
}
