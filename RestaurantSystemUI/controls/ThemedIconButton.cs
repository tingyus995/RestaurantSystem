using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystemUI.controls
{
    class ThemedIconButton : IconButton
    {
        public ThemedIconButton()
        {
            //this.Text = "";
            this.IconColor = Color.White;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconChar = IconChar.Heart;
            this.IconSize = 30;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Color.White;
            this.Font = new Font("Microsoft JhengHei UI", 14f, FontStyle.Bold);
            //this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimumSize = new Size(10, 10);

        }

    }
}
