using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI.controls
{
    public partial class ThemePreviewItem : UserControl
    {
        private ColorTheme theme;
        public ThemePreviewItem(ColorTheme c)
        {
            InitializeComponent();
            theme = c;
        }

        private void ThemePreviewItem_Load(object sender, EventArgs e)
        {
            pnContentArea.BackColor = theme.ContentPanel;
            pnLeftMenu.BackColor = theme.MainMenuBar;
            pnTitleBar.BackColor = theme.TitleBar;
        }
    }
}
