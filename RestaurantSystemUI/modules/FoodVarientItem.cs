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
    public partial class FoodVarientItem : UserControl
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



        public FoodVarientItem()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            PlusButtonClicked.Invoke(this, new EventArgs());
        }
    }
}
