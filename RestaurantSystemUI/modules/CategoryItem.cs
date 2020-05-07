using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemCore.models;

namespace RestaurantSystemUI
{
    public partial class CategoryItem : UserControl
    {
        public Category Category {get; set; }
        public CategoryItem()
        {   
            InitializeComponent();
        }

        private void CategoryItem_Load(object sender, EventArgs e)
        {
            label1.Text = Category.Name;
        }
    }
}
