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
    public partial class EmployeeItemCompact : UserControl
    {
        //public string employName { get; set; }
        private Employee employee;

        public Employee Employee
        {
            get { return employee; }
            set { employee = value;
                lbName.Text = value.Name;
            }
        }

        public EmployeeItemCompact()
        {
            InitializeComponent();
        }

        

        private void EmployeeItemCompact_Load(object sender, EventArgs e)
        {
            
        }
        
    }
    
}
