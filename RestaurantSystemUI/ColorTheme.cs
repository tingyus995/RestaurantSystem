﻿using System;
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

        public static string name = "預設主題（午夜藍）";

        protected static Color mainAccent = Color.FromArgb(26, 188, 156);
        protected static Color mainAcceintDerivative = Color.FromArgb(22, 160, 133);

        protected static Color secondary = Color.FromArgb(155, 89, 182);
        protected static Color secondaryDerivative = Color.FromArgb(142, 68, 173);


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

        // food item
        public Color FoodItem = Darken(mainAcceintDerivative, 20);
        // food varient
        public Color FoodItemVarient = Darken(mainAcceintDerivative, 40);

        

        //public Color OrderViewTitle = 

        // controls

        // flatTextbox

        public Color Placeholder = Darken(Color.White, 50);







    }
}
