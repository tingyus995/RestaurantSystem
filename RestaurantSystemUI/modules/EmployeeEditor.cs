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
using RestaurantSystemUI;
using RestaurantSystemCore;
using System.Runtime.CompilerServices;

namespace RestaurantSystemUI.modules
{
    public partial class EmployeeEditor : UserControl, IThemeable
    {


        public event EventHandler EditorExited;

        
        
        private Bitmap employeeImage;
        private Employee employee;
        
        
        public EmployeeEditor()
        {
            InitializeComponent();
            //new employee
            employee = new Employee();
            

            pbEmployeeImage.Image = Properties.Resources.DefaultEmployeeImage;
        }

        public EmployeeEditor(Employee _employee)
        {
            InitializeComponent();
            // edit employee
            employee = _employee;
            updateUI();
        }


        


        private void updateUI()
        {
            // name
            ftbName.textBox.Text = employee.Name;
            // salary
            ftbSalary.textBox.Text = employee.Salary.ToString();
            // contactNumber
            ftbContactNumber.textBox.Text = employee.ContactNumber;
            // birthday
            ftbBirthday.textBox.Text = employee.Birthday.ToString("yyyy/MM/dd");
            
            // categories
            tagInput1.Tags = employee.Categories;
            

            // employee image
            //EmployeeImage = Utility.BytesToImage(employee.Image);
            employeeImage = Utility.BytesToImage(employee.Image);
            
            pbEmployeeImage.Image = employeeImage;
            
            if(employeeImage == null)
            {
                pbEmployeeImage.Image = Properties.Resources.DefaultEmployeeImage;
            }
        }

        private void EmployeeEditor_Load(object sender, EventArgs e)
        {

            ApplyTheme();
        }


        

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(ftbName.textBox.Text);

            // assign new value
            employee.Name = ftbName.textBox.Text;
            employee.Salary = int.Parse(ftbSalary.textBox.Text.Trim());
            employee.ContactNumber = ftbContactNumber.textBox.Text;
            employee.Birthday = Convert.ToDateTime(ftbBirthday.textBox.Text);
            //MessageBox.Show(Birthday.Day + " " + Birthday.Month + "  " + Birthday.Year);
       
            employee.Image = Utility.ImageToBytes(employeeImage);
            employee.Categories = tagInput1.Tags;

            EmployeeManager.UpdateOrSaveEmployee(employee);

            EditorExited?.Invoke(this, new EventArgs());
            this.Parent.Controls.Remove(this);
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            EditorExited?.Invoke(this, new EventArgs());
            Parent.Controls.Remove(this);
        }

        private void pbEmployeeImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Utility.GetSupportedImageFilter();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    employeeImage = new Bitmap(openFileDialog1.FileName);
                    pbEmployeeImage.Image = employeeImage;
                }catch
                {
                    MessageBox.Show("檔案開啟時發生錯誤。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flatTextbox1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void fpVarients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDatepicker_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.Opacity
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ftbBirthday.textBox.Text =  dateTimePicker1.Value.ToShortDateString();
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
            ftbName.BackColor = BackColor;
            ftbSalary.BackColor = BackColor;
            ftbContactNumber.BackColor = BackColor;
            ftbBirthday.BackColor = BackColor;
            tagInput1.BackColor = BackColor;
        }
    }
}