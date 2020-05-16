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

namespace RestaurantSystemUI.modules
{
    public partial class EmployeeItem : UserControl
    {

        private Employee employee;

        public event EventHandler EditEmployeeClicked;
        public event EventHandler DeleteEmployeeClicked;
        public event EventHandler<EmployeeSelectedEventArgs> EmployeeSelected;

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; updateUI(); }
        }

        private void updateUI()
        {
            lbEmployeeName.Text = Employee.Name;
            //lbSalary.Text = Employee.Salary.ToString();//don't show employee's salary 
            
            pictureBox1.Image = Utility.BytesToImage(employee.Image);

            if(pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.DefaultEmployeeImage;
            }

            /*foreach(Varient v in employee.Varients)
            {
                EmployeeVarientItem item = new EmployeeVarientItem()
                {
                    VarientName = v.Name,
                    Price = employee.BasePrice + v.delta
                };
                
                fpnVarients.Controls.Add(item);

                item.PlusButtonClicked += (object _s, EventArgs _e) =>
                {
                    EmployeeVarientItem it = _s as EmployeeVarientItem;
                    employee.SelectedVarientIndex = fpnVarients.Controls.IndexOf(it);
                    EmployeeSelected?.Invoke(this, new EmployeeSelectedEventArgs(Employee));
                };
               
            }*/

        }

        public EmployeeItem()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditEmployeeClicked?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployeeClicked?.Invoke(this, e);
        }
    }
    
    public class EmployeeSelectedEventArgs : EventArgs
    {
        public EmployeeSelectedEventArgs(Employee f)
        {
            SelectedEmployee = f;        
        }

        public Employee SelectedEmployee { get; set; }
    }
}
