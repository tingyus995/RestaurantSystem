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

namespace RestaurantSystemUI
{

    public partial class CategoryItem : UserControl, IThemeable
    {

        Color normal = Color.FromArgb(52, 73, 94);
        Color normalLeft = Color.FromArgb(66, 93, 119);

        Color activated = Color.FromArgb(243, 156, 18);
        Color activatedLeft = Color.FromArgb(241, 196, 15);


        public event EventHandler CategoryItemClicked;
        public event EventHandler RemoveButtonClicked;
        public event EventHandler EditButtonClicked;

        private FlatTextbox ftb;

        private bool editable = true;
        private ColorTheme theme = ThemeProvider.GetTheme();

        public bool Editable
        {
            get { return editable; }
            private set
            {
                editable = value;
                ibtnEdit.Visible = editable;
            }
        }
        private bool removable = false;
        public bool Removable
        {
            get
            {
                return removable;
            }
            private set
            {
                removable = value;
                ibtnDelete.Visible = removable;
                ibtnDelete.Top = 0;
            }
        }

        private bool active = false;

        private static string[] supportedTargetManager = { "none", "food", "employee" };

        private string targetManager;


        public bool Active
        {
            get { return active; }
            set
            {
                active = value;


                if (active)
                {
                    BackColor = theme.CategoryItemActive;
                    pnDecoration.BackColor = theme.categoryItemActiveDecoration;
                }
                else
                {
                    BackColor = theme.CategoryItem;
                    pnDecoration.BackColor = theme.CategoryItemDecoration;
                }

            }
        }


        public Category Category { get; set; }
        public CategoryItem(bool _removeBtn = false, bool _editBtn = false, string _targetManager = "none")
        {
            InitializeComponent();

            if (_removeBtn && _editBtn)
            {
                throw new System.ArgumentException("There's only one space for action button. You enabled both.");
            }
            else
            {
                Removable = _removeBtn;
                Editable = _editBtn;

                if (Removable || Editable)
                {
                    if (Array.IndexOf(supportedTargetManager, _targetManager) < 0)
                    {
                        throw new System.ArgumentException("Target Manager unsupported.");
                    }
                    else if (_targetManager == "none")
                    {
                        throw new System.ArgumentException("You must specify target manager when either removable or editable is enabled.");
                    }
                    else
                    {
                        targetManager = _targetManager;
                    }

                }
            }

        }

        private void CategoryItem_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            updateUI();

        }

        private void updateUI()
        {
            lbCatName.Text = Category.Name;
        }

        private void ibtnEdit_Click(object sender, EventArgs e)
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            if(ftb == null) { 

                ftb = new FlatTextbox();
                ftb.textBox.Text = Category.Name;
                ftb.BackColor = theme.ContentPanel;
            
                Controls.Add(ftb);
                ftb.Left = 10;
                ftb.Top = 10;

                ftb.BringToFront();
            
                
                ftb.textBox.LostFocus += TextBox_LostFocus;
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            HandleEditComplete(tb);

        }

        private void HandleEditComplete(TextBox tb)
        {  

            string text = tb.Text.Trim();

            if (text.Length >= 0)
            {

                switch (targetManager)
                {
                    case "food":
                        if (!FoodManager.EditCategory(Category.Name, text))
                        {
                            MessageBox.Show("同名稱的類別已經存在。", "改名失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Category.Name = text;
                            lbCatName.Text = Category.Name;
                        }
                        
                        break;
                    case "employee":
                        if (!EmployeeManager.EditCategory(Category.Name, text))
                        {
                            MessageBox.Show("同名稱的職位已經存在。", "改名失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Category.Name = text;
                            lbCatName.Text = Category.Name;
                        }
                        break;
                    default:
                        Console.Write("default");
                        break;

                }

                Controls.Remove(ftb);
                ftb = null;

            }
            
        }

        private void handleClick()
        {
            CategoryItemClicked?.Invoke(this, new EventArgs());
        }

        private void pnDecoration_Click(object sender, EventArgs e)
        {
            handleClick();
        }

        private void lbCatName_Click(object sender, EventArgs e)
        {
            handleClick();
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            handleClick();
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.CategoryItem;
            pnDecoration.BackColor = theme.CategoryItemDecoration;
        }
    }
}
