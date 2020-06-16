using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    public partial class ConfirmWindow : Form
    {
     
        public bool Confirmed { get; private set; } = false;

        public ConfirmWindow()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }

        private void ConfirmWindow_Load(object sender, EventArgs e)
        {
            ftbConfirmWord.textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ftbConfirmWord.textBox.Text == "Yes")
            {
                btnConfirm.Visible = true;
            }
            else
            {
                btnConfirm.Visible = false;
            }
        }
    }
}
