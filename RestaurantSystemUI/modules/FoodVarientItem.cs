using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI.modules
{
    public partial class FoodVarientItem : UserControl, IThemeable
    {

        private string varientName;
        public event EventHandler PlusButtonClicked;

        public string VarientName
        {
            get { return varientName; }
            set { varientName = value; lbVarientName.Text = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; lbPrice.Text = price.ToString();  }
        }

        private bool showPlusButton = true;

        public bool ShowPlusButton
        {
            get { return showPlusButton; }
            set { showPlusButton = value; btnPlus.Visible = value; }
        }

        public FoodVarientItem()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            PlusButtonClicked.Invoke(this, new EventArgs());
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.FoodItemVarient;
        }

        private void FoodVarientItem_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }
    }
}
