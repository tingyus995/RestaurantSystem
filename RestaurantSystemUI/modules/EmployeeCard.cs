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

namespace RestaurantSystemUI.modules
{
    public partial class EmployeeCard : UserControl
    {
        private Employee employee;

        private int index; // so that we know which worktime to deal with
        public Employee Employee
        {

            get { return employee; }
            set { employee = value;
                if (employee.Image != null) pictureBox1.Image = Utility.BytesToImage(employee.Image);
                lbName.Text = employee.Name;
                if (employee.workTime[index].ActualStart != null){
                    lbActualStart.Text = employee.workTime[index].ActualStart.Value.ToLongTimeString();
                }
                if (employee.workTime[index].ActualEnd != null)
                {
                    lbActualEnd.Text = employee.workTime[index].ActualEnd.Value.ToLongTimeString();
                    btnNext.Visible = false;
                }



            }
            
        }


        public EmployeeCard(int _index)
        {
            InitializeComponent();
            index = _index;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            EmployeeCard card = (EmployeeCard)((Control)sender).Parent;
            Console.WriteLine(card);

            // modify employee.workingTime[index].StartTime and save
            if (card.lbActualStart.Text == "尚未打上班卡") {
                if (MessageBox.Show("您確定要打上班卡嗎？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SignatureBoard signatureBoard = new SignatureBoard();
                    signatureBoard.ShowDialog();
                    //card.Employee.workTime[card.index].ActualStart = DateTime.Now;
                    card.Employee.workTime[card.index].ActualStart = Attendance.SystemClock;
                    EmployeeManager.UpdateOrSaveEmployee(card.Employee);
                    card.lbActualStart.Text = card.Employee.workTime[card.index].ActualStart.Value.ToLongTimeString();
                    card.btnNext.Text = "下班打卡";


                    Bitmap map = signatureBoard.bmp;
                    card.Employee.workTime[card.index].CheckInSignature = Utility.ImageToBytes(map);
                }
               
            }

            // modify employee.workingTime[index].EndtTime and save
            else if (card.lbActualStart.Text != "尚未打上班卡") {
                if (MessageBox.Show("您確定要打下班卡嗎？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SignatureBoard signatureBoard = new SignatureBoard();
                    signatureBoard.ShowDialog();
                    //card.Employee.workTime[card.index].ActualEnd = DateTime.Now;
                    card.Employee.workTime[card.index].ActualEnd = Attendance.SystemClock;
                    EmployeeManager.UpdateOrSaveEmployee(card.Employee);
                    card.lbActualEnd.Text = card.Employee.workTime[card.index].ActualEnd.Value.ToLongTimeString();
                    card.btnNext.Visible = false;

                    Bitmap map = signatureBoard.bmp;
                    card.Employee.workTime[card.index].CheckOutSignature = Utility.ImageToBytes(map);
                }
            }
        }
    }
}
