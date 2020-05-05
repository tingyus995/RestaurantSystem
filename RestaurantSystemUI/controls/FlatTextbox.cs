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
    public partial class FlatTextbox : UserControl, IThemeable
    {
        //ColorTheme theme;
        public string PlaceHolder { get; set; }
        public ColorTheme Theme { get; set; }


        public FlatTextbox()
        {

            InitializeComponent();
        }

        public void ApplyTheme()
        {
            /*BackColor = theme.ContentPanel;
            lbPlaceholder.BackColor = theme.Placeholder;
            pnUnderline.BackColor = theme.Contrast;*/

        }

        private void FlatTextbox_Load(object sender, EventArgs e)
        {
            lbPlaceholder.Text = PlaceHolder;

            // when anything is clicked
            lbPlaceholder.Click += handleClick;
            Click += handleClick;
            pnUnderline.Click += handleClick;

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox.Text.Length > 0)
            {
                lbPlaceholder.Visible = false;
            }
            else
            {
                lbPlaceholder.Visible = true;
            }
        }

        

        private void handleClick(object sender, EventArgs e)
        {
            textBox.Focus();            
        }
    }
}
