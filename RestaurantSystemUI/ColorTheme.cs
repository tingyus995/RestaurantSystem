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


        public string name = "午夜藍";
        public string Name { get { return name;  } }


        protected Color mainAccent = Color.FromArgb(26, 188, 156);
        protected Color mainAcceintDerivative = Color.FromArgb(22, 160, 133);

        protected Color secondary = Color.FromArgb(155, 89, 182);
        protected Color secondaryDerivative = Color.FromArgb(142, 68, 173);

        private Color normal = Color.FromArgb(46, 204, 113);
        private Color dangerous = Color.FromArgb(231, 76, 60);
        private Color warning = Color.FromArgb(230, 126, 34);


        public Color Contrast = Color.White;

        protected static Color Darken(Color c, int amount)
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

        protected static Color Lighten(Color c, int amount)
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

        public Color MainMenuBar { get { return mainAccent; } }
        public Color MainMenuItem { get { return mainAccent; } }
        public Color MainMenuItemMouseOver { get { return Lighten(mainAccent, 20); } }
        public Color MainMenuItemMouseDown { get { return Darken(mainAccent, 20); } }
        public Color MainMenuItemSelected { get { return Lighten(mainAccent, 20); } }
        public Color TitleBar { get { return Darken(mainAcceintDerivative, 10); } }

        // content

        public Color ContentPanel { get { return mainAcceintDerivative; } }

        // category item
        public Color CategoryItem { get { return mainAccent; } }
        public Color CategoryItemDecoration { get { return Lighten(mainAccent, 20); } }
        public Color CategoryItemActive { get { return secondary; } }
        public Color categoryItemActiveDecoration { get { return Lighten(secondary, 20); } }

        // order view title
        public Color OrderViewTitle { get { return secondary; } }
        public Color OrderViewBottom { get { return secondaryDerivative; } }

        public Color OrderViewItemEven { get { return Darken(secondaryDerivative, 10); } }
        public Color OrderViewItemOdd { get { return Darken(secondaryDerivative, 20); } }

        // food item
        public Color FoodItem { get { return Darken(mainAcceintDerivative, 20); } }
        // food varient
        public Color FoodItemVarient { get { return Darken(mainAcceintDerivative, 40); } }

        //public Color OrderViewTitle = 

        // controls

        // flatTextbox

        public Color Placeholder { get { return Darken(Color.White, 50); } }

        // shift
        public Color LateCard { get { return warning; } }
        public Color OnTimeCard { get{ return normal; } }
        public Color MissingCard { get{ return dangerous; } }

        public Color TimeSlotBackground { get { return Darken(mainAccent, 40); } }
        public Color TimeSlotHover { get { return mainAccent; } }


    }
}
