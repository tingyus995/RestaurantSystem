using RestaurantSystemCore;
using RestaurantSystemUI.themes;
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
        private static ColorTheme colorTheme = null;
        private static ColorTheme[] themes =  {
            new ColorTheme(), 
            new PurpleTheme(), 
            new BlueTheme(), 
            new EmraldTheme(),
            new GreenTheme(),
            new YelloTheme(),
            new OrangeTheme(),
            new RedTheme(),
            new GrayTheme()
        };

        public static ColorTheme GetTheme() {

            if (colorTheme != null) return colorTheme;             
            
            string name = ShopManager.ShopThemeName;
            
            foreach(ColorTheme theme in themes)
            {
                if(theme.Name == name)
                {
                    colorTheme = theme;
                    return colorTheme;
                }
            }            

            return themes[0];

        }

        public static void ChangeTheme(ColorTheme theme)
        {
            colorTheme = theme;
        }

        public static ColorTheme[] GetAllThemes()
        {
            return themes;
        }
	}
}
