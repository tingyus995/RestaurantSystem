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
using System.Security.Cryptography;

namespace RestaurantSystemUI.OOBE_pages
{
    public partial class AdminPassword : UserControl, IOOBEPage
    {
        public AdminPassword()
        {
            InitializeComponent();
        }

        public void BeforeMount()
        {
            //throw new NotImplementedException();
        }

        public bool LeaveCheck()
        {
            if(flatTextbox1.textBox.Text.Length == 0)
            {
                MessageBox.Show("密碼不能為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(flatTextbox1.textBox.Text != flatTextbox2.textBox.Text)
            {
                MessageBox.Show("確認密碼不符。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            ShopManager.ShopPassword = Utility.Sha1Hash(flatTextbox1.textBox.Text);

            return true;
            
        }
    }
}
