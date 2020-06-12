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
using RestaurantSystemCore;
using RestaurantSystemUI.controls;

namespace RestaurantSystemUI.modules
{
    public partial class EmployeeList : UserControl, IThemeable
    {
        
        private string selectedCategoryName;
        private const string ALL_CATEGORIES = "全部分類";
        TextBox password;
        Panel LoginPanel;
        public EmployeeList()
        {
            InitializeComponent();
        }

        

        private void activateCategory(CategoryItem c)
        {
            foreach(CategoryItem cat in fpnCategories.Controls)
            {
                cat.Active = false;
            }
            c.Active = true;
        }

        private void loadData()
        {

            fpnCategories.Controls.Clear();
            fpnEmployeeItems.Controls.Clear();

            // all category
            CategoryItem allCats = new CategoryItem() {
                Category = new Category()
                {
                    Name = ALL_CATEGORIES,
                    Amount = -1
                }
            };

            allCats.CategoryItemClicked += CategoryItem_Click;
            fpnCategories.Controls.Add(allCats);


            Category[] categories = EmployeeManager.GetCategories();
            foreach (Category cat in categories)
            {
                CategoryItem item = new CategoryItem(false, true, "employee") { Category = cat };
                item.CategoryItemClicked += CategoryItem_Click;
                /*item.CategoryNameUpdated += (object _s, EventArgs _e) => {
                    if( EmployeeManager.EditCategory())
                }*/
                fpnCategories.Controls.Add(item);
            }

            if(selectedCategoryName != null)
            {
                loadCategory(selectedCategoryName);
            }
        }

        private void loadCategory(string cat)
        {
            foreach(CategoryItem item in fpnCategories.Controls)
            {
                if(item.Category.Name == cat)
                {
                    CategoryItem_Click(item, new EventArgs());

                    return;
                }
            }
        }
        public void Login()
        {
            LoginPanel = new Panel();
            this.Controls.Add(LoginPanel);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.BackColor = Color.Purple;
            LoginPanel.BringToFront();

            //controls in LoginPanel
            password = new TextBox();
            ThemedLabel hint = new ThemedLabel();
            ThemedIconTextButton submit = new ThemedIconTextButton();
            
            
            hint.Text = "請輸入密碼";
            hint.Top = this.Height / 2;
            hint.Left = this.Width / 2;
            password.Top = hint.Top + hint.Height*2;
            password.Left = hint.Left;
            submit.Text = "確認";
            submit.AutoSize = true;
            submit.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            submit.Top = password.Top + password.Height * 2;
            submit.Left = password.Left;
            submit.Click += Submit_Click;
            

            
            LoginPanel.Controls.Add(hint);
            LoginPanel.Controls.Add(password);
            LoginPanel.Controls.Add(submit);



        }

        private void Submit_Click(object sender, EventArgs e) {
            if(password.Text == "")
            {
                MessageBox.Show("登入成功");
                LoginPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("登入失敗");
            }

        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            Login();
            loadData();
            ApplyTheme();
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            CategoryItem item = sender as CategoryItem;
            activateCategory(item);

            selectedCategoryName = item.Category.Name;
            
            Employee[] employees;
            
            if (item.Category.Name == ALL_CATEGORIES)
                employees = EmployeeManager.GetEmployees();
            else
                employees = EmployeeManager.GetEmployees(item.Category.Name);

            fpnEmployeeItems.Controls.Clear();

            foreach(Employee f in employees)
            {
                EmployeeItem employeeItem = new EmployeeItem() { Employee = f };
                employeeItem.EditEmployeeClicked += (object _s, EventArgs _e) => {
                    //EmployeeItem it = _s as EmployeeItem;
                    EmployeeEditor editor = new EmployeeEditor(f);

                    editor.EditorExited += (object __s, EventArgs __e) =>
                    {
                        loadData();
                    };

                    Utility.ShowFullSpaceDialog(this, editor);
                    
                };

                employeeItem.DeleteEmployeeClicked += (object _s, EventArgs _e) =>
                {                    
                    EmployeeItem it = _s as EmployeeItem;

                    if(DialogResult.OK == MessageBox.Show(
                        String.Format("您確定要刪除{0}嗎? \n刪除後將無法復原。", it.Employee.Name), 
                        "警告", 
                        MessageBoxButtons.OKCancel, 
                        MessageBoxIcon.Warning
                    )){
                        EmployeeManager.DeleteEmployee(it.Employee);
                        loadData();
                    }                   

                };

                fpnEmployeeItems.Controls.Add(employeeItem);
            }
        }

        private void ibtnAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeEditor editor = new EmployeeEditor();
            
            editor.EditorExited += (object __s, EventArgs __e) =>
            {
                loadData();
            };
            Utility.ShowFullSpaceDialog(this, editor);
        }

        


        private void fpnEmployeeItems_Resize(object sender, EventArgs e)
        {

            /*Control pn = sender as Control;

            if (pn.Controls.Count == 0) return;

            int amount = pn.ClientSize.Width / (400 + 6);

            if (amount == 0) return;

            pn.SuspendLayout();
            foreach(Control c in fpnEmployeeItems.Controls)
            {
                c.MinimumSize = new Size((fpnEmployeeItems.ClientSize.Width / amount - (c.Margin.Left + c.Margin.Right)) - 10, c.Height);
            }
            pn.ResumeLayout();*/
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
        }
    }
}