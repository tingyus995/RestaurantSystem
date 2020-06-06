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
using RestaurantSystemCore.models;

namespace RestaurantSystemUI.modules
{
    public partial class Attendance : UserControl, IThemeable, ISubmodule
    {

        class BeginTimeHolder : IComparable<BeginTimeHolder>
        {
            public DateTime BeginTime { get; set; }
            public string BeginTimeText {
                get {

                    string result = BeginTime.ToLongDateString() + BeginTime.ToLongTimeString();

                    TimeSpan span = DateTime.Now - BeginTime;

                    if (span.TotalSeconds >= 60 * 10) // more than 10 mins
                    {
                        result += "（補打卡）";
                    }
                    else
                    {
                        result += "（正常打卡）";
                    }

                    return result;


                    
                }
            }

            public int CompareTo(BeginTimeHolder other)
            {
                return DateTime.Compare(BeginTime, other.BeginTime);
            }
        }
        private Employee[] employeeList;
        public static DateTime SystemClock = new DateTime(2020, 5, 26, 10, 31, 0);
        DateTime CurrentShiftStart;
        DateTime CurrentShiftEnd;
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

            // for debug
            //List<DateTime> startTimes = new List<DateTime>();
            SortedSet<BeginTimeHolder> startTimes = new SortedSet<BeginTimeHolder>();

            // clear combobox first
            CBSelect.DataSource = null;
            // add possible time slots
            Employee[] employees = EmployeeManager.GetEmployees("clerk");
            foreach(Employee employee in employees)
            {
                if(employee.workTime != null)
                    foreach (WorkTime slot in employee.workTime)
                    {
                        Console.WriteLine(slot.StartTime.ToString() + "~" + slot.EndTime.ToShortTimeString());
                        // add to combobox
                        //CBSelect.Items.Add(slot.StartTime);
                        //CBSelect.Items.Add(slot.StartTime);
                        startTimes.Add(new BeginTimeHolder() {
                            BeginTime = slot.StartTime
                        });
                    }
            }

            List<BeginTimeHolder> holders = startTimes.ToList();

            CBSelect.DisplayMember = "BeginTimeText";
            CBSelect.ValueMember = "BeginTime";
            CBSelect.DataSource = holders;


        }
        //public void SetUpAttendance() {

        //    if (GetCurrentShift() == null)
        //    {
        //        lbCurrentShift.Text = "no";
        //    }
        //    else {
        //        lbCurrentShift.Text = GetCurrentShift().Item1.ToLongTimeString() + GetCurrentShift().Item2.ToLongTimeString();
        //    }

        //}


        ////getCurrentShift
        //public Tuple<DateTime, DateTime> GetCurrentShift()
        //{
        //    bool found = false;
        //    Employee[] employees = EmployeeManager.GetEmployees();
        //    foreach (Employee employee in employees)
        //    {
        //        if (employee.workTime != null)
        //        {
        //            foreach (WorkTime time in employee.workTime)
        //            {
        //                int result1 = DateTime.Compare(time.StartTime, SystemClock);
        //                int result2 = DateTime.Compare(time.EndTime, SystemClock);
        //                if (result1 <= 0 && result2 > 0)
        //                {
        //                    CurrentShiftStart = time.StartTime;
        //                    CurrentShiftEnd = time.EndTime;
        //                    found = true;
        //                    goto Outside;
        //                }

        //            }
        //        }
                
        //    }

        //    Outside:
        //    if (found != true) {
        //        return null;
        //    }
        //    return Tuple.Create(CurrentShiftStart, CurrentShiftEnd);
        //}


        //system time
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbSystemTime.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            SystemClock = new DateTime(int.Parse(ftbYear.textBox.Text), int.Parse(ftbMonth.textBox.Text), int.Parse(ftbDay.textBox.Text), int.Parse(ftbHour.textBox.Text), int.Parse(ftbMin.textBox.Text), 0);
            //DateTime testend = new DateTime(year, month, day, endHourOfDay, endMinuteOfDay, 0);
            lbSystemTime.Text = SystemClock.ToLongDateString() + SystemClock.ToLongTimeString();
            //SetUpAttendance();
        }

        private bool IsTimeInRange(DateTime target, DateTime begin, DateTime end)
        {
            return (DateTime.Compare(target, begin) >= 0) && (DateTime.Compare(target, end) < 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add possible time slots
            if(CBSelect.SelectedValue != null) { 
                CurrentShiftStart = (DateTime)CBSelect.SelectedValue;
                CurrentShiftEnd = CurrentShiftStart.AddMinutes(60);
            }

            pnEmployeeList.Controls.Clear();
            Employee[] employees = EmployeeManager.GetEmployees();
            foreach (Employee employee in employees)
            {
                if (employee.workTime != null)
                    //foreach (WorkTime slot in employee.workTime)
                    for(int i = 0; i < employee.workTime.Length; ++i)
                    {
                        WorkTime slot = employee.workTime[i];
                        
                        //if( slot.StartTime <= CurrentShiftStart && slot.EndTime  <= CurrentShiftEnd)
                        if(IsTimeInRange(slot.StartTime, CurrentShiftStart, CurrentShiftEnd))
                        {
                            //MessageBox.Show(employee.Name);
                            EmployeeCard compact = new EmployeeCard(i)
                            {
                                Employee = employee
                                
                            };

                            pnEmployeeList.Controls.Add(compact);

                            //compact.Click += (object _s, EventArgs _e) =>
                            //{
                            //    EmployeeCard item = _s as EmployeeCard;
                            //    Employee emp = item.Employee;
                            //    if (MessageBox.Show("您確定要打卡嗎？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            //    {
                            //        // write to db
                            //        foreach(WorkTime t in emp.workTime)
                            //        {
                            //            if(IsTimeInRange(t.StartTime, CurrentShiftStart, CurrentShiftEnd))
                            //            {
                            //                // we found it
                            //                //st.ActualStart=DateTime.Nows


                            //                break;
                            //            }
                            //        }

                            //        //EmployeeManager.UpdateOrSaveEmployee();
                            //    }
                            //};


                        }
                    }
            }
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
        }

        public void BeforeMounted()
        {
            Attendance_Load(this, new EventArgs());
            //SignatureBoard s = new SignatureBoard();
            //s.ShowDialog();

            //Bitmap map = s.bmp;


        }
    }
}
