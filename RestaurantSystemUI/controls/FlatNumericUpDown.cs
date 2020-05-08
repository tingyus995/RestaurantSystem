using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    public partial class FlatNumericUpDown : UserControl
    {

        private int  maximum = 10;

        public int  Maximum
        {
            get { return maximum; }
            set { maximum = value; CapValue(); }
        }
        private int minimum = 0;

        public int Minimum
        {
            get { return minimum; }
            set { minimum = value; CapValue(); }
        }

        private int _value = 0;

        public int Value
        {
            get { return _value; }
            set { _value = value; lbNumber.Text = Value.ToString(); }
        }

        private void CapValue()
        {
            if (Value > Maximum) Value = Maximum;
            if (Value < Minimum) Value = Minimum;            
        }





        public FlatNumericUpDown()
        {
            InitializeComponent();
        }



        private void FlatNumericUpDown_Load(object sender, EventArgs e)
        {
            lbNumber.Text = Value.ToString();
        }

        private void ibtnPlus_Click(object sender, EventArgs e)
        {
            if (Value < Maximum) Value = Value + 1;
        }

        private void ibtnMinus_Click(object sender, EventArgs e)
        {
            if (Value > Minimum) Value = Value - 1;
        }
    }
}
