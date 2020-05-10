using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.controls
{
    class ThemedIconTextButton : IconButton
    {
        public ThemedIconTextButton(){            
            this.IconColor = Color.White;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconChar = IconChar.Heart;
            this.IconSize = 18;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.White;
            this.FlatAppearance.BorderSize = 1;
            this.ForeColor = Color.White;
            this.Font = new Font("Microsoft JhengHei UI", 14f, FontStyle.Bold);            
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimumSize = new Size(10, 10);            
        }
    }
}
