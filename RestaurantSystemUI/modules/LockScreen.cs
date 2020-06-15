using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemCore;

namespace RestaurantSystemUI.modules
{
    public partial class LockScreen : UserControl
    {
        public LockScreen()
        {
            InitializeComponent();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            string pwd = flatTextbox1.textBox.Text;
            
            // check if the user entered password
            if(pwd.Length == 0)
            {
                MessageBox.Show("請輸入管理員密碼。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                       
            
            // check if password is correct
            
            if(Utility.Sha1Hash(pwd) == ShopManager.ShopPassword)
            {
                // remove lock screen if the user entered correct password
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("密碼錯誤。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
