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
        public enum CardStatus
        {
            Future,
            OnTime,
            Late,
            Missing
        }

        private CardStatus status;

        public CardStatus Status
        {
            get { return status; }
            set {

                ColorTheme theme = ThemeProvider.GetTheme();

                status = value;

                switch (status)
                {
                    case CardStatus.Future:
                        //pnCardStatus.BackColor = 
                        break;
                    case CardStatus.Late:
                        pnCardStatus.BackColor = theme.LateCard;
                        break;

                    case CardStatus.Missing:
                        pnCardStatus.BackColor = theme.MissingCard;
                        break;

                    case CardStatus.OnTime:
                        pnCardStatus.BackColor = theme.OnTimeCard;
                        break;
                    
                }

            }
        }

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
            // propagate children's events
            pnCardStatus.MouseDown += fireMouseDown;
            lbName.MouseDown += fireMouseDown;
        }

        private void fireMouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }
    }
    
}
