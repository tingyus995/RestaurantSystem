﻿using System;
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
using System.Threading;
using System.Threading.Tasks;
namespace RestaurantSystemUI
{
    public partial class AttendanceState : UserControl
    {
        //time
        DateTime CurrentDate;
        DateTime CurrentWeekStart;
        DateTime CurrentWeekEnd;
        //tableLayoutPanel
        TableLayoutPanel tableLayoutPanel;

        EmployeeItemCompact activeControl;
        Point previousPosition;
        Panel hoverCell;
        private Employee[] employeeList;
        public AttendanceState()
        {
            InitializeComponent();
        }

        

        private void AttendanceState_Load(object sender, EventArgs e)
        {
            CurrentDate = DateTime.Now;
            CurrentWeekStart = CurrentDate.AddDays(-(int)CurrentDate.DayOfWeek);
            CurrentWeekEnd = CurrentWeekStart.AddDays(6);
            
            

            SetUpAttendanceState();

            loadAttendanceStateData();


        }
        private void onEmployeeItemMouseDown(object sender, MouseEventArgs e) {

            activeControl = (EmployeeItemCompact)sender;//sender as EmployeeItem;
            Bitmap bitmap = new Bitmap(activeControl.Width, activeControl.Height);
            activeControl.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));

            //previousPosition = e.Location;
            //Cursor = Cursors.Hand;
            Cursor cursor = new Cursor(bitmap.GetHicon());
            Cursor.Current = cursor;
            this.DoDragDrop(activeControl.Name, DragDropEffects.Move);
        }
        
        
       

        private void cellDragOver(object sender, EventArgs e) {
            hoverCell = sender as TimeSlotFlowPanel;
            hoverCell.BackColor = Color.Brown;
        }

        private void cellDragLeave(object sender, EventArgs e)
        {
            TimeSlotFlowPanel cell = sender as TimeSlotFlowPanel;
            cell.BackColor = Color.Aquamarine;
        }
        private void cellDragDrop(object sender, EventArgs e)
        {
            EmployeeItemCompact item = new EmployeeItemCompact() {
                Employee = activeControl.Employee
            };
            
            hoverCell.Controls.Add(item);
            hoverCell.BackColor = Color.Aquamarine;
            item.BringToFront();
            
        }
        private void cellDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void SetUpAttendanceState()
        {
            CurrentWeekButton.Text = CurrentWeekStart.ToLongDateString()+"~"+ CurrentWeekEnd.ToLongDateString();

            //employee
            employeeList = EmployeeManager.GetEmployees("clerk");
            flowLayoutPanel1.SuspendLayout();
            foreach (Employee employee in employeeList)
            {
                EmployeeItemCompact item = new EmployeeItemCompact()
                {
                    Employee = employee
                };

                flowLayoutPanel1.Controls.Add(item);
                item.MouseDown += new MouseEventHandler(onEmployeeItemMouseDown);
            }
            flowLayoutPanel1.ResumeLayout();



            //table
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.AutoScroll = true;
            panel5.Controls.Add(tableLayoutPanel);

            int year = CurrentWeekStart.Year;
            int month = CurrentWeekStart.Month;
            int day = CurrentWeekStart.Day;
            //int dayOfWeek = (int)CurrentDate.DayOfWeek;
            int startHourOfDay = 9;
            int startMinuteOfDay = 30;
            int endHourOfDay = 17;
            int endMinuteOfDay = 30;
            int duration = 60;

            // calculate how many row tablelayoutpanel need and prepare detail time
            DateTime teststart = new DateTime(year, month, day, startHourOfDay, startMinuteOfDay, 0);
            DateTime testend = new DateTime(year, month, day, endHourOfDay, endMinuteOfDay, 0);
            int rowcount = 0;
            List<string> detailTime = new List<string>();
            while (DateTime.Compare(teststart, testend) < 0)
            {
                detailTime.Add(teststart.ToShortTimeString());
                teststart = teststart.AddMinutes(60);
                rowcount++;
            }

            rowcount++; // for display weekdays


            string[] weekdays = { "日", "一", "二", "三", "四", "五", "六" };
            tableLayoutPanel.ColumnCount = 8;//seven days in a week +  for detailtime
            tableLayoutPanel.RowCount = rowcount;

            //prepare column styles
            for (int i = 0; i < tableLayoutPanel.ColumnCount - 1; ++i)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100f / 7)));
            }



            DateTime drawCell = new DateTime(year, month, day, startHourOfDay, startMinuteOfDay, 0);
            //Console.WriteLine((int)drawCell.DayOfWeek);
            //if ((int)drawCell.DayOfWeek != 0) // sunday equal to 0
            //{
            //    drawCell = drawCell.AddDays(-(int)drawCell.DayOfWeek);
            //}


            
            tableLayoutPanel.SuspendLayout();
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.RowCount; j++)
                {
                    if (i == 0 && j == 0) { continue; }
                    if (i == 0)
                    {
                        //add detail time 
                        tableLayoutPanel.Controls.Add(new Label()
                        {
                            Text = detailTime[j - 1],
                            //Text = i.ToString()+ " "+ j.ToString(),
                            BackColor = Color.Aquamarine,
                            ForeColor = Color.Purple
                        }, i, j);
                        continue;

                    }
                    if (j == 0)
                    {
                        // add weekdays                        

                        tableLayoutPanel.Controls.Add(new Label()
                        {
                            Text = weekdays[i - 1],
                            //Text = weekdays[i-1] + i.ToString() + j.ToString(),
                            BackColor = Color.Aquamarine,
                            ForeColor = Color.Purple
                        }, i, j);
                        continue;

                    }

                    // draw cell
                    TimeSlotFlowPanel myPanel = new TimeSlotFlowPanel();
                    //myPanel.AutoScroll = true;                
                    myPanel.MinimumSize = new Size(100, 50);
                    myPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
                    myPanel.AutoSize = true;

                    // time
                    myPanel.Date = drawCell.Date;
                    myPanel.BeginTime = drawCell;
                    myPanel.EndTime = drawCell.AddMinutes(duration);

                    drawCell = myPanel.EndTime;

                    myPanel.Controls.Add(new Label()
                    {
                        Text = string.Format("{0} to {1}", myPanel.BeginTime.ToString(), myPanel.EndTime.ToShortTimeString()),
                        AutoSize = true

                    });

                    myPanel.BackColor = Color.Aquamarine;
                    tableLayoutPanel.Controls.Add(myPanel, i, j);


                    //myPanel.Dock = DockStyle.Fill;
                    myPanel.AllowDrop = true;
                    myPanel.DragOver += cellDragOver;
                    myPanel.DragLeave += cellDragLeave;
                    myPanel.DragDrop += cellDragDrop;
                    myPanel.DragEnter += cellDragEnter;
                }

                if (i != 0) 
                {
                    drawCell = drawCell.AddDays(1);
                }

                drawCell = new DateTime(drawCell.Year, drawCell.Month, drawCell.Day, startHourOfDay, startMinuteOfDay, 0);
            }

            tableLayoutPanel.ResumeLayout();
        }

        private void PreviousWeekButton_Click(object sender, EventArgs e)
        {
            CurrentWeekStart = CurrentWeekStart.AddDays(-7);
            CurrentWeekEnd = CurrentWeekEnd.AddDays(-7);
            panel5.Controls.Remove(tableLayoutPanel);
            SetUpAttendanceState();
            loadAttendanceStateData();
        }
        private void NextWeekButton_Click(object sender, EventArgs e)
        {
            CurrentWeekStart = CurrentWeekStart.AddDays(7);
            CurrentWeekEnd = CurrentWeekEnd.AddDays(7);
            panel5.Controls.Remove(tableLayoutPanel);
            SetUpAttendanceState();
            loadAttendanceStateData();
        }

       

        private void loadAttendanceStateData()
        {
            Employee[] employees = EmployeeManager.GetEmployees("clerk");

            

            foreach (Control c in tableLayoutPanel.Controls)
            {
                if (c is TimeSlotFlowPanel)
                {
                    TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;


                    foreach (Employee employee in employees)
                    {
                        // check if we should put compact
                        if(employee.workTime != null) { 
                            foreach(WorkTime t in employee.workTime)
                            {
                                if(t.StartTime == slot.BeginTime && t.EndTime == slot.EndTime)
                                {
                                    slot.Controls.Add(new EmployeeItemCompact()
                                    {
                                        Employee = employee
                                    });
                                }
                            }
                        }
                    }






                }

            }
        }


        private void deleteAllWorkingTimes()
        {
            Employee[] employees = EmployeeManager.GetEmployees();
            //MessageBox.Show(employees.Length.ToString());
            foreach (Employee employee in employees)
            {
                employee.workTime = null;
                EmployeeManager.UpdateOrSaveEmployee(employee);
                
            }
           
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            foreach(Control c in tableLayoutPanel.Controls)
            {
                if(c is TimeSlotFlowPanel)
                {
                    TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;
                    // check if anyone is here
                    foreach (Control _c in slot.Controls)
                    {
                        if(_c is EmployeeItemCompact) {
                            EmployeeItemCompact compact = _c as EmployeeItemCompact;
                            // we found employee                            

                            List<WorkTime> workingTimes;

                            if (compact.Employee.workTime != null) workingTimes = compact.Employee.workTime.ToList();
                            else workingTimes = new List<WorkTime>();

                            // before we add, let's check if there's already one

                            bool found = false;
                            foreach(WorkTime t in workingTimes)
                            {
                                if(t.StartTime == slot.BeginTime && t.EndTime == slot.EndTime)
                                {
                                    found = true;
                                    break;
                                }
                            }
                            if (!found) {
                                //MessageBox.Show("debug");
                                workingTimes.Add(new WorkTime()
                                {
                                    StartTime = slot.BeginTime,
                                    EndTime = slot.EndTime
                                });
                            }

                            compact.Employee.workTime = workingTimes.ToArray();
                            EmployeeManager.UpdateOrSaveEmployee(compact.Employee);
                        }
                    }
                }

            }
            /*for (int i = 0; i < tableLayoutPanel.ColumnCount; i++) {
                for (int j = 0; j < tableLayoutPanel.RowCount; j++) {
                    
                    
                    
                    
                    if (tableLayoutPanel.GetControlFromPosition(i, j) == null) continue;// i=0, j=0 is null
                    if (tableLayoutPanel.GetControlFromPosition(i, j).GetType() == typeof(TimeSlotFlowPanel)) {//timeslotpanel filter
                        foreach (Control control in tableLayoutPanel.GetControlFromPosition(i, j).Controls) {
                            if (control.GetType() == typeof(EmployeeItemCompact)) {
                                //Employee em = control.GetType().GetProperty("Employee").GetValue(control);
                                Console.WriteLine(control);
                                Console.WriteLine(tableLayoutPanel.GetControlFromPosition(i, j).GetType().GetProperty("Date").GetValue(tableLayoutPanel.GetControlFromPosition(i, j)));
                                Console.WriteLine(tableLayoutPanel.GetControlFromPosition(i, j).GetType().GetProperty("BeginTime").GetValue(tableLayoutPanel.GetControlFromPosition(i, j)));
                                Console.WriteLine(tableLayoutPanel.GetControlFromPosition(i, j).GetType().GetProperty("EndTime").GetValue(tableLayoutPanel.GetControlFromPosition(i, j)));
                                //EmployeeManager.UpdateOrSaveEmployee()
                                Console.WriteLine(control.GetType().GetProperty("Employee").GetValue(control).GetType());
                                Console.WriteLine(control.GetType().GetProperty("Employee").GetType());
                            }   

                        }

                    }

                }

            }*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("您確定要清除所有排班嗎?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                deleteAllWorkingTimes();
            }
            panel5.Controls.Remove(tableLayoutPanel);
            SetUpAttendanceState();
            loadAttendanceStateData();

        }
    }
}