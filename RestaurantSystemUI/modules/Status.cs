﻿using System;
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
    public partial class Status : UserControl
    {
        public Status()
        {
            InitializeComponent();
        }

        private void btnShowDisplay_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
        }
    }
}
