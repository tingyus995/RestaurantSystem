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
using RestaurantSystemUI.modules;
using RestaurantSystemUI.controls;

namespace RestaurantSystemUI
{
    public partial class Shift : UserControl, IThemeable, ISubmodule
    {
        const int longPressTime = 1000;
        System.Windows.Forms.Timer _Timer = new Timer() { Interval = longPressTime };
        //time
        DateTime SystemClock = new DateTime(2020, 6, 9, 7, 30, 1);
        DateTime CurrentDate;
        DateTime CurrentWeekStart;
        DateTime CurrentWeekEnd;
        //tableLayoutPanel
        TableLayoutPanel tableLayoutPanel;

        EmployeeItemCompact activeControl;
        EmployeeItemCompact prepareDeleteControl;
        TimeSlotFlowPanel prepareDeleteControlCell;
        Point previousPosition;
        TimeSlotFlowPanel hoverCell;
        // for drag and drop effects
        Bitmap dragThumbnail;
        Cursor cursor;
        bool AlreadyShowDialog = false;

        private Employee[] employeeList;
        public Shift()
        {
            InitializeComponent();
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            LoadingScreen loading = new LoadingScreen();
            Utility.ShowFullSpaceDialog(this, loading);
            lbSystemTime.Text = SystemClock.ToLongDateString() + SystemClock.ToLongTimeString();
            CurrentDate = DateTime.Now;
            CurrentWeekStart = CurrentDate.AddDays(-(int)CurrentDate.DayOfWeek);
            CurrentWeekEnd = CurrentWeekStart.AddDays(6);

            // doing debug

            /*ConnectContinuousSlotDebug(new Employee()
            {
                Name = "Ddebug",
                workTime = new WorkTime[]
                {
                    new WorkTime()
                    {
                        StartTime = new DateTime(2020,5,18,10,30,0),
                        EndTime = new DateTime(2020,5,18,12,30,0)
                    },
                    new WorkTime()
                    {
                        StartTime = new DateTime(2020,5,18,13,30,0),
                        EndTime = new DateTime(2020,5,18,14,30,0)
                    }
                }
            });*/

            //comboBox1
            var item = DateTime.Today.AddHours(0); // 00:00:00
            while (item <= DateTime.Today.AddHours(23).AddMinutes(45))
            {
                this.comboBox1.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                item = item.AddMinutes(15);
            }

            if (ShopManager.ShiftCb1StartTime == "")//for the first time
            {
                comboBox1.SelectedIndex = 32;//08:00
            }
            else
            {
                comboBox1.SelectedIndex = comboBox1.FindString(ShopManager.ShiftCb1StartTime);
            }
            //if (comboBox1.FindString(ShopManager.ShiftCb1StartTime) >= 0)
            //{
            //    comboBox1.SelectedIndex = comboBox1.FindString(ShopManager.ShiftCb1StartTime);
            //}else{
            //    comboBox1.SelectedIndex = 32;//08:00
            //}



            //comboBox2
            DateTime startTime = DateTime.Parse(comboBox1.SelectedItem.ToString());
            DateTime endTime = DateTime.Today.AddHours(24).AddMinutes(0);
            Console.WriteLine(startTime.ToString());

            TimeSpan span = endTime.Subtract(startTime);
            Console.WriteLine("Time Difference (minutes): " + span.TotalMinutes);
            if ((int)span.TotalMinutes >= 15)
            {
                comboBox2.Items.Add(15 + "分鐘");
            }
            if ((int)span.TotalMinutes >= 30)
            {
                comboBox2.Items.Add(30 + "分鐘");
            }
            if ((int)span.TotalMinutes >= 45)
            {
                comboBox2.Items.Add(45 + "分鐘");
            }


            double interval = 60;
            while (interval <= span.TotalMinutes)
            {
                comboBox2.Items.Add(interval + "分鐘");
                interval += 60;
            }
            if (ShopManager.ShiftCb2Interval == "")//for the first time
            {
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                comboBox2.SelectedIndex = comboBox2.FindString(ShopManager.ShiftCb2Interval);
            }


            //comboBox3
            string[] list = comboBox2.SelectedItem.ToString().Split('分');
            Console.WriteLine(list[0].ToString());
            int count = (int)span.TotalMinutes / int.Parse(list[0]);
            int i = 1;
            while (i <= count)
            {
                comboBox3.Items.Add(i);
                i++;
            }
            if (ShopManager.ShiftCb3Amount == "")
            {
                comboBox3.SelectedIndex = 0;
            }
            else
            {
                comboBox3.SelectedIndex = comboBox3.FindString(ShopManager.ShiftCb3Amount);
            }

            SetUpShift();

            loadShiftData();
            ApplyTheme();
            _Timer.Tick += Timer_Tick;
            this.Controls.Remove(loading);
            

        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            DateTime startTime = DateTime.Parse(comboBox1.SelectedItem.ToString());
            DateTime endTime = DateTime.Today.AddHours(24).AddMinutes(0);
            Console.WriteLine(startTime.ToString());

            TimeSpan span = endTime.Subtract(startTime);
            //Console.WriteLine("Time Difference (minutes): " + span.TotalMinutes);
            if ((int)span.TotalMinutes >= 15)
            {
                comboBox2.Items.Add(15 + "分鐘");
            }
            if ((int)span.TotalMinutes >= 30)
            {
                comboBox2.Items.Add(30 + "分鐘");
            }
            if ((int)span.TotalMinutes >= 45)
            {
                comboBox2.Items.Add(45 + "分鐘");
            }



            double interval = 60;
            while (interval <= span.TotalMinutes)
            {
                comboBox2.Items.Add(interval + "分鐘");
                interval += 60;
            }
            //comboBox2.Items.Add(span.TotalMinutes+"分鐘");
            comboBox2.SelectedIndex = 0;

            
            //comboBox3.SelectedIndex = 0;// in case user do not select new value of combobox2 and box3 index out of range
            comboBox3.Items.Clear();
           
            string[] list = comboBox2.SelectedItem.ToString().Split('分');

            int count = (int)span.TotalMinutes / int.Parse(list[0]);
            int i = 1;
            while (i <= count)
            {
                comboBox3.Items.Add(i);
                i++;
            }
            comboBox3.SelectedIndex = 0;
        }
        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            DateTime startTime = DateTime.Parse(comboBox1.SelectedItem.ToString());
            DateTime endTime = DateTime.Today.AddHours(24).AddMinutes(0);

            TimeSpan span = endTime.Subtract(startTime);
            string[] list = comboBox2.SelectedItem.ToString().Split('分');

            int count = (int)span.TotalMinutes / int.Parse(list[0]);
            int i = 1;
            while (i <= count)
            {
                comboBox3.Items.Add(i);
                i++;
            }
            comboBox3.SelectedIndex = 0;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您確定要修改格式嗎？這將導致資料流失我們建議您先到報表列印歷史報表", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                ShopManager.ShiftCb1StartTime = comboBox1.SelectedItem.ToString();
                ShopManager.ShiftCb2Interval = comboBox2.SelectedItem.ToString();
                ShopManager.ShiftCb3Amount = comboBox3.SelectedItem.ToString();
                deleteAllWorkingTimes();

            }
            SetUpShift();
            loadShiftData();

        }


        private void onEmployeeItemMouseDown(object sender, MouseEventArgs e) {

            activeControl = (EmployeeItemCompact)sender;//sender as EmployeeItem;
            dragThumbnail = new Bitmap(activeControl.Width, activeControl.Height);
            activeControl.DrawToBitmap(dragThumbnail, new Rectangle(Point.Empty, dragThumbnail.Size));
            cursor = new Cursor(dragThumbnail.GetHicon());
            Cursor.Current = cursor;
            
            this.DoDragDrop(activeControl, DragDropEffects.Move);
        }

        private void cellDragOver(object sender, EventArgs e) {
            ColorTheme theme = ThemeProvider.GetTheme();
            hoverCell = sender as TimeSlotFlowPanel;
            hoverCell.BackColor = theme.TimeSlotHover;
        }

        private void cellDragLeave(object sender, EventArgs e)
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            TimeSlotFlowPanel cell = sender as TimeSlotFlowPanel;            
            cell.BackColor = theme.TimeSlotBackground;
        }
        
        private void cellDragDrop(object sender, EventArgs e)
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            EmployeeItemCompact item = new EmployeeItemCompact() {
                Employee = activeControl.Employee
            };
            foreach (Control c in hoverCell.Controls)
            {
                if(c is EmployeeItemCompact)
                {
                    EmployeeItemCompact compact = (EmployeeItemCompact)c;
                    if(item.Employee.Id == compact.Employee.Id)
                    {
                        MessageBox.Show("同個時段不能新增一樣的人");
                        return;
                    }

                }
            }
            hoverCell.Controls.Add(item);
            
            hoverCell.BackColor = theme.TimeSlotBackground;
            item.BringToFront();

            item.MouseDown += button_MouseDown;
            item.MouseUp += button_MouseUp;
            //MessageBox.Show(hoverCell.);
            //SaveThisDay(hoverCell.BeginTime.Date);
            SaveDay(hoverCell, activeControl.Employee);
            
        }

        public void button_MouseDown(object sender, EventArgs e)
        {
            prepareDeleteControl = (EmployeeItemCompact)sender;
            prepareDeleteControlCell = (TimeSlotFlowPanel)prepareDeleteControl.Parent;

            Console.WriteLine("click");
            //AlreadyShowDialog = true;
            //_Timer = new System.Windows.Forms.Timer();


            _Timer.Enabled = true;
            
            
            //_Timer.Interval = longPressTime;
            //_Timer.Start();
            
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            //_Timer.Stop();
            _Timer.Enabled = false;  // or timer1.Enabled = false;
            AlreadyShowDialog = false;
            if (!AlreadyShowDialog)
            {
                if (MessageBox.Show("您確定要刪除該時段嗎？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    //AlreadyShowDialog = true;
                    DeleteThisWorkTime(prepareDeleteControlCell, prepareDeleteControl);
                }

            }
            AlreadyShowDialog = false;
            //if (MessageBox.Show("您確定要刪除該時段嗎？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            //{
            //    //AlreadyShowDialog = true;
            //    DeleteThisWorkTime(prepareDeleteControlCell, prepareDeleteControl);
            //}


        }
        public void button_MouseUp(object sender, EventArgs e)
        {
            //_Timer.Stop();
            _Timer.Enabled = false;
            AlreadyShowDialog = true;
        }
        

        private void DeleteThisWorkTime(TimeSlotFlowPanel cell, EmployeeItemCompact deletecompact)
        {
            cell.Controls.Remove(deletecompact);

            int colIdx = tableLayoutPanel.GetColumn(cell);

            Employee employee = deletecompact.Employee;
            List<WorkTime> newWorkTimes = new List<WorkTime>();
            for (int i = 1; i < tableLayoutPanel.RowCount; ++i) // i = 0 is weekdays
            {
                Control c = tableLayoutPanel.GetControlFromPosition(colIdx, i);
                if (c is TimeSlotFlowPanel)
                {
                    TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;

                    foreach (Control _c in slot.Controls)
                    {
                        if (_c is EmployeeItemCompact)
                        {
                            EmployeeItemCompact compact = _c as EmployeeItemCompact;
                            if (compact.Employee.Id == employee.Id)

                                newWorkTimes.Add(new WorkTime()
                                {
                                    StartTime = slot.BeginTime,
                                    EndTime = slot.EndTime,
                                    CurrentWage = employee.Salary
                            });

                        }
                    }
                }
            }
            // merge

            //ConnectContinuousSlot(employee);
            int pivot = 0;

            while ((pivot + 1) < newWorkTimes.Count)
            {
                // still have worktimes after

                if (IsContinuous(newWorkTimes[pivot], newWorkTimes[pivot + 1]))
                {

                    // merge
                    newWorkTimes[pivot] = MergeTime(newWorkTimes[pivot], newWorkTimes[pivot + 1]);
                    // remove +1 one
                    newWorkTimes.RemoveAt(pivot + 1);
                }

                ++pivot;
            }

            employee.workTime = newWorkTimes.ToArray();
            EmployeeManager.UpdateOrSaveEmployee(employee);


        }
        
        private void SaveDay(TimeSlotFlowPanel cell, Employee employee)
        {
            // the day we're going to deal with
            int colIdx = tableLayoutPanel.GetColumn(cell);

            List<WorkTime> newWorkTimes = new List<WorkTime>();
            
            // filter out worktime of this day
            if(employee.workTime != null)
                foreach(WorkTime t in employee.workTime)
                {
                    if(t.StartTime.Date.CompareTo(cell.Date) != 0)
                    {
                        newWorkTimes.Add(t);
                    }
                }
            

            // read new worktimes
            for(int i = 1; i < tableLayoutPanel.RowCount; ++i) // i = 0 is weekdays
            {
                Control c = tableLayoutPanel.GetControlFromPosition(colIdx, i);
                if(c is TimeSlotFlowPanel)
                {
                    TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;

                    foreach(Control _c in slot.Controls)
                    {
                        if(_c is EmployeeItemCompact)
                        {
                            EmployeeItemCompact compact = _c as EmployeeItemCompact;
                            if (compact.Employee.Id == employee.Id)
                                //MessageBox.Show("ya");
                                newWorkTimes.Add(new WorkTime()
                                {
                                    StartTime = slot.BeginTime,
                                    EndTime = slot.EndTime,
                                    CurrentWage = employee.Salary
                                });

                        }
                    }                    
                }
                
            }
            // merge

            //ConnectContinuousSlot(employee);
            int pivot = 0;

            while((pivot + 1) < newWorkTimes.Count)
            {
                // still have worktimes after

                if(IsContinuous(newWorkTimes[pivot], newWorkTimes[pivot + 1])) {

                    // merge
                    newWorkTimes[pivot] = MergeTime(newWorkTimes[pivot], newWorkTimes[pivot + 1]);
                    // remove +1 one
                    newWorkTimes.RemoveAt(pivot + 1);
                }
                else
                {
                    ++pivot;
                }                
            }

            employee.workTime = newWorkTimes.ToArray();
            EmployeeManager.UpdateOrSaveEmployee(employee);

        }
        
        private void cellDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void SetUpShift()
        {
            CurrentWeekLabel.Text = CurrentWeekStart.ToLongDateString()+"~"+ CurrentWeekEnd.ToLongDateString();
            Console.WriteLine(CurrentWeekLabel.Text);
            //employee

            //employeeList = EmployeeManager.GetEmployees("clerk");
            employeeList = EmployeeManager.GetEmployees();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            foreach (Employee employee in employeeList)
            {
                EmployeeItemCompact item = new EmployeeItemCompact()
                {
                    Employee = employee
                };
                
                flowLayoutPanel1.Controls.Add(item);
                item.MouseDown += onEmployeeItemMouseDown;
            }
            flowLayoutPanel1.ResumeLayout();

            container.Controls.Remove(tableLayoutPanel);
            //table
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Padding = new Padding(15);
            
            
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.AutoScroll = true;
            //tableLayoutPanel.Margin = new Padding(0, 0, 0, 1000);
            container.Controls.Add(tableLayoutPanel);

            int year = CurrentWeekStart.Year;
            int month = CurrentWeekStart.Month;
            int day = CurrentWeekStart.Day;

            DateTime formatStartTime = Convert.ToDateTime(comboBox1.SelectedItem);
            //MessageBox.Show(formatTime.Hour.ToString()+" "+ formatTime.Minute.ToString());
            string[] list = comboBox2.SelectedItem.ToString().Split('分');
            int interval = int.Parse(list[0]);
            int amount = int.Parse(comboBox3.SelectedItem.ToString());
            //int amount = 1;
            DateTime formatEndTime = formatStartTime.AddMinutes(interval*amount);
            formatEndTime = formatEndTime.AddSeconds(-1);
            //MessageBox.Show(formatEndTime.ToString());
            int startHourOfDay = formatStartTime.Hour;
            int startMinuteOfDay = formatStartTime.Minute;
            int endHourOfDay = formatEndTime.Hour;
            int endMinuteOfDay = formatEndTime.Minute;
            int duration = interval;

            //int startHourOfDay = 9;
            //int startMinuteOfDay = 30;
            //int endHourOfDay = 17;
            //int endMinuteOfDay = 30;
            //int duration = 60;

            // calculate how many row tablelayoutpanel need and prepare detail time
            DateTime teststart = new DateTime(year, month, day, startHourOfDay, startMinuteOfDay, 0);
            DateTime testend = new DateTime(year, month, day, endHourOfDay, endMinuteOfDay, 0);
            testend.AddSeconds(-10);
            int rowcount = 0;
            List<string> detailTime = new List<string>();
            while (DateTime.Compare(teststart, testend) < 0)
            {
                detailTime.Add(teststart.ToShortTimeString());
                teststart = teststart.AddMinutes(interval);
                rowcount++;
            }

            rowcount++; // for display weekdays


            string[] weekdays = { "日", "一", "二", "三", "四", "五", "六" };
            tableLayoutPanel.ColumnCount = 8;//seven days in a week +  for detailtime
            tableLayoutPanel.RowCount = rowcount;

            //prepare column styles
            for (int i = 0; i < tableLayoutPanel.ColumnCount; ++i)
            {
                //tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100f / 7)));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5f));
            }
           
            DateTime drawCell = new DateTime(year, month, day, startHourOfDay, startMinuteOfDay, 0);
            DateTime temp = drawCell;
            //Console.WriteLine((int)drawCell.DayOfWeek);
            //if ((int)drawCell.DayOfWeek != 0) // sunday equal to 0
            //{
            //    drawCell = drawCell.AddDays(-(int)drawCell.DayOfWeek);
            //}
            ToolTip ShiftTimeToolTip = new ToolTip();
            SetTooltipStyleForCard(ShiftTimeToolTip, "時段", ToolTipIcon.Info);

            int minH = container.Height / tableLayoutPanel.RowCount;

            tableLayoutPanel.SuspendLayout();
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.RowCount; j++)
                {
                    if (i == 0 && j == 0) { continue; }
                    if (i == 0)
                    {
                        //add detail time
                        ThemedLabel lbDetailTime = new ThemedLabel()
                        {
                            Text = detailTime[j - 1]                            
                            //Text = i.ToString()+ " "+ j.ToString(),
                        };

                        lbDetailTime.Font = new Font(lbDetailTime.Font.FontFamily, 10f);

                        tableLayoutPanel.Controls.Add(lbDetailTime, i, j);
                        continue;

                    }
                    if (j == 0)
                    {
                        // add weekdays

                        ThemedLabel weekday = new ThemedLabel()
                        {
                            Text = weekdays[i - 1],
                            TextAlign = ContentAlignment.MiddleCenter
                            //Text = weekdays[i-1] + i.ToString() + j.ToString()

                        };
                        weekday.Dock = DockStyle.Fill;
                        tableLayoutPanel.Controls.Add(weekday, i, j);

                        continue;

                    }

                    // draw cell
                    TimeSlotFlowPanel myPanel = new TimeSlotFlowPanel();
                    //myPanel.AutoScroll = true;             
                    myPanel.MinimumSize = new Size(0, minH);
                    myPanel.Dock = DockStyle.Fill;
                    
                    myPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
                    myPanel.AutoSize = true;

                    // time
                    myPanel.Date = drawCell.Date;
                    myPanel.BeginTime = drawCell;
                    myPanel.EndTime = drawCell.AddMinutes(duration);

                    drawCell = myPanel.EndTime;
                    

                    /*myPanel.Controls.Add(new Label()
                    {
                        //Text = string.Format("{0}\n{1}\n~{2}",myPanel.BeginTime.ToShortDateString(), myPanel.BeginTime.ToShortTimeString(), myPanel.EndTime.ToShortTimeString()),
                        AutoSize = true

                    });*/
                    ShiftTimeToolTip.SetToolTip(myPanel, string.Format("{0}\n{1}\n~\n{2}", myPanel.BeginTime.ToShortDateString(), myPanel.BeginTime.ToShortTimeString(), myPanel.EndTime.ToShortTimeString()));

                    //myPanel.BackColor = Color.Aquamarine;
                    tableLayoutPanel.Controls.Add(myPanel, i, j);


                    //myPanel.Dock = DockStyle.Fill;

                    //no allow shift in pass
                    if (DateTime.Compare(myPanel.BeginTime, SystemClock) < 0 && cbGodMode.Checked == false)
                    {
                        myPanel.AllowDrop = false;
                    }
                    else {
                        myPanel.AllowDrop = true;
                        myPanel.DragOver += cellDragOver;
                        myPanel.DragLeave += cellDragLeave;
                        myPanel.DragDrop += cellDragDrop;
                        myPanel.DragEnter += cellDragEnter;
                        
                    }

                    // hover hint
                    myPanel.MouseEnter += cellMouseEnter;
                    myPanel.MouseLeave += cellMouseLeave;

                }

                //if (i != 0) 
                //{
                //    drawCell = drawCell.AddDays(1);
                //}

                //drawCell = new DateTime(drawCell.Year, drawCell.Month, drawCell.Day, startHourOfDay, startMinuteOfDay, 0);
                drawCell = temp.AddDays(i);
            }


            // set margin for things at last row
            int lastRow = tableLayoutPanel.RowCount - 1;
            for(int i = 0; i < tableLayoutPanel.ColumnCount; ++i)
            {
                Control c = tableLayoutPanel.GetControlFromPosition(i, lastRow);
                c.Padding = new Padding(0, 0, 0, 20);
            }

            tableLayoutPanel.ResumeLayout();
        }

        private void cellMouseLeave(object sender, EventArgs e)
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            Control control = sender as Control;
            control.BackColor = theme.TimeSlotBackground;
        }

        private void cellMouseEnter(object sender, EventArgs e)
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            Control control = sender as Control;
            control.BackColor = theme.TimeSlotHover;

        }

        private void PreviousWeekButton_Click(object sender, EventArgs e)
        {
            CurrentWeekStart = CurrentWeekStart.AddDays(-7);
            CurrentWeekEnd = CurrentWeekEnd.AddDays(-7);
            SetUpShift();
            loadShiftData();
        }
        private void NextWeekButton_Click(object sender, EventArgs e)
        {

            CurrentWeekStart = CurrentWeekStart.AddDays(7);
            CurrentWeekEnd = CurrentWeekEnd.AddDays(7);
            SetUpShift();
            loadShiftData();
        }
        private bool IsTimeInRange(DateTime target, DateTime begin, DateTime end)
        {
            return (DateTime.Compare(target, begin) >= 0) && (DateTime.Compare(target, end) <= 0);
        }

        private void SetTooltipStyleForCard(ToolTip t, string title, ToolTipIcon icon)
        {
            t.IsBalloon = true;
            t.ToolTipIcon = icon;
            t.ToolTipTitle = title;
        }

        private void loadShiftData()
        {
            Employee[] employees = EmployeeManager.GetEmployees("clerk");

            ToolTip OnTimeCardTooltip = new ToolTip();
            SetTooltipStyleForCard(OnTimeCardTooltip, "已打卡", ToolTipIcon.Info);

            ToolTip LateCardToolTip = new ToolTip();
            SetTooltipStyleForCard(LateCardToolTip, "打卡時間異常", ToolTipIcon.Warning);

            ToolTip MissingCardTooltip = new ToolTip();
            SetTooltipStyleForCard(MissingCardTooltip, "未打卡", ToolTipIcon.Error);

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
                                //if(t.StartTime == slot.BeginTime && t.EndTime == slot.EndTime)
                                if(IsTimeInRange(slot.BeginTime, t.StartTime, t.EndTime) &&
                                    IsTimeInRange(slot.EndTime, t.StartTime, t.EndTime)
                                )
                                {
                                    EmployeeItemCompact item = new EmployeeItemCompact() { Employee = employee };
                                    if (DateTime.Compare(slot.BeginTime, SystemClock) < 0 && cbGodMode.Checked == false)
                                    {

                                    }
                                    else
                                    {
                                        item.MouseDown += button_MouseDown;
                                        item.MouseUp += button_MouseUp;
                                    }
                                    
                                    slot.Controls.Add(item);
                                    if(c.AllowDrop == false) { // shift in pass
                                        DateTime slotStart = slot.BeginTime;
                                        DateTime bfslotStart = slotStart.AddMinutes(-10);
                                        DateTime slotEnd = slot.EndTime;
                                        DateTime afslotEnd = slotEnd.AddMinutes(10);
                                        ColorTheme theme = ThemeProvider.GetTheme();
                                        if (t.ActualStart == null || t.ActualEnd == null) {

                                            //item.BackColor = theme.MissingCard;
                                            item.Status = EmployeeItemCompact.CardStatus.Missing;
                                            MissingCardTooltip.SetToolTip(item, "請注意員工狀況");
                                            continue;
                                        }
                                        DateTime StartTime = t.StartTime;
                                        DateTime EndTime = t.EndTime;
                                        DateTime ActualStart = t.ActualStart.Value;
                                        DateTime ActualEnd = t.ActualEnd.Value;
                                        
                                        if (IsTimeInRange(ActualStart, bfslotStart, slotStart) && IsTimeInRange(ActualEnd, slotEnd, afslotEnd)){
                                            //item.BackColor = theme.OnTimeCard;                                            
                                            item.Status = EmployeeItemCompact.CardStatus.OnTime;
                                            OnTimeCardTooltip.SetToolTip(item, "已打卡");
                                        }
                                        else {
                                            //item.BackColor = theme.LateCard;                                            
                                            item.Status = EmployeeItemCompact.CardStatus.Late;
                                            TimeSpan timeSpan = ActualStart.Subtract(StartTime);

                                            TimeSpan timeSpan1 = EndTime.Subtract(ActualEnd);

                                            //DateTime test1 = new DateTime(2020, 6, 7, 9, 10, 0);
                                            //DateTime test2 = new DateTime(2020, 6, 7, 9, 5, 0);
                                            //TimeSpan testSpan = test2 - test1;
                                            //int count = (int)timeSpan.TotalMinutes;
                                            //MessageBox.Show(StartTime.ToString()+ ActualStart.ToString()+" "+  count.ToString());
                                            int count1 = (int)timeSpan.TotalMinutes;
                                            int count2 = (int)timeSpan1.TotalMinutes;
                                            Console.WriteLine(StartTime.ToString() + " " + ActualStart.ToString()+" "+ (int)timeSpan.TotalMinutes + " ");
                                            Console.WriteLine(EndTime.ToString() + " " + ActualEnd.ToString() + " " + count2 + " ");
                                            string StartlateMinutes = "";
                                            string EndearlyMinutes = "";
                                            if (count1 > 0)
                                            {
                                                StartlateMinutes = "(遲到"+count1.ToString()+"分鐘)";
                                            }
                                            if(count2 > 0)
                                            {
                                                EndearlyMinutes = "(早退"+count2.ToString()+"分鐘)";
                                            }
                                            LateCardToolTip.SetToolTip(item, String.Format("打卡上班時間:{0} {1}\n打卡下班時間:{2} {3}", 
                                                ActualStart.ToString("yyyy/M/d HH:mm"),
                                                StartlateMinutes,
                                                ActualEnd.ToString("yyyy/M/d HH:mm"),
                                                EndearlyMinutes));                                            
                                        }
                                    
                                        
                                    }
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

        private bool IsContinuous(WorkTime t1, WorkTime t2)
        {
            return (t1.EndTime == t2.StartTime);
        }

        private WorkTime MergeTime(WorkTime t1, WorkTime t2)
        {
            WorkTime result = new WorkTime();

            if (IsContinuous(t1, t2))
            {
                result.StartTime = t1.StartTime;
                result.EndTime = t2.EndTime;
                result.CurrentWage = t1.CurrentWage;
                return result;
            }

            return null;
        }

        private void ConnectContinuousSlot(Employee employee)
        {
            if (employee.workTime == null) return;
            if (employee.workTime.Length <= 1) return;

            List<WorkTime> original = new List<WorkTime>();
            List<WorkTime> newWorkTime = new List<WorkTime>();
            original.AddRange(employee.workTime);
            
            //original.Sort();

            for(int i = 1; i < original.Count; ++i)
            {                
                WorkTime merged = MergeTime(original[i-1], original[i]);

                if(merged != null)
                {
                    newWorkTime.Add(merged);
                }
                else
                {
                    newWorkTime.Add(original[i-1]);
                    if(i == original.Count - 1)
                    {
                        newWorkTime.Add(original[i]);
                    }
                }

            }

            employee.workTime = newWorkTime.ToArray();
            //EmployeeManager.UpdateOrSaveEmployee(employee);           
        }

        private void ConnectContinuousSlotDebug(Employee employee)
        {
            if (employee.workTime == null) return;
            if (employee.workTime.Length <= 1) return;

            List<WorkTime> original = new List<WorkTime>();
            List<WorkTime> newWorkTime = new List<WorkTime>();
            original.AddRange(employee.workTime);

            //original.Sort();

            for (int i = 1; i < original.Count; ++i)
            {
                WorkTime merged = MergeTime(original[i - 1], original[i]);

                if (merged != null)
                {
                    newWorkTime.Add(merged);
                }
                else
                {
                    newWorkTime.Add(original[i - 1]);
                    if (i == original.Count - 1)
                    {
                        newWorkTime.Add(original[i]);
                    }
                }

            }

            employee.workTime = newWorkTime.ToArray();

            string msg = "";
            foreach(var nwt in newWorkTime)
            {
                msg += string.Format("from {0} to {1}\n", nwt.StartTime, nwt.EndTime);
            }

            MessageBox.Show(msg, "DEBUGGGGGG", MessageBoxButtons.OK);
        }


        



        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("您確定要清除所有排班嗎?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                deleteAllWorkingTimes();
            }
            SetUpShift();
            loadShiftData();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lbSystemTime.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void cbGodMode_CheckedChanged(object sender, EventArgs e)
        {
            SetUpShift();
            loadShiftData();
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;

            flowLayoutPanel1.BackColor = theme.ContentPanel;

           // flatTextbox1.BackColor = BackColor;
            //flatTextbox2.BackColor = BackColor;
            //ftbName.BackColor = BackColor;
        }


        private void Shift_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
            Cursor.Current = cursor;
        }

        public void BeforeMounted()
        {
            Shift_Load(this, new EventArgs());

        }


        //private void _deprecated_btnSave_Click(object sender, EventArgs e)
        //{
        //    // delete all worktimes in employee

        //    /*Employee[] employees = EmployeeManager.GetEmployees();
        //    foreach(Employee employee in employees)
        //    {
        //        employee.workTime = null;
        //    }*/

        //    //deleteAllWorkingTimes();

        //    foreach(Control c in tableLayoutPanel.Controls)
        //    {
        //        if(c is TimeSlotFlowPanel)
        //        {
        //            TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;
        //            // check if anyone is here
        //            foreach (Control _c in slot.Controls)
        //            {
        //                if(_c is EmployeeItemCompact) {
        //                    EmployeeItemCompact compact = _c as EmployeeItemCompact;
        //                    // we found employee                            

        //                    List<WorkTime> workingTimes;

        //                    if (compact.Employee.workTime != null) workingTimes = compact.Employee.workTime.ToList();
        //                    else workingTimes = new List<WorkTime>();

        //                    // before we add, let's check if there's already one
        //                    bool found = false;
        //                    foreach(WorkTime t in workingTimes)
        //                    {
        //                        // check if there's already one
        //                        if(t.StartTime == slot.BeginTime && t.EndTime == slot.EndTime)                                
        //                        {
        //                            found = true;
        //                            break;
        //                        }
        //                    }

        //                    if (!found) {
        //                        //MessageBox.Show("debug");
        //                        workingTimes.Add(new WorkTime()
        //                        {
        //                            StartTime = slot.BeginTime,
        //                            EndTime = slot.EndTime
        //                        });
        //                    }

        //                    compact.Employee.workTime = workingTimes.ToArray();
        //                    EmployeeManager.UpdateOrSaveEmployee(compact.Employee);
        //                }

        //            }
        //        }

        //        foreach(Employee employee in EmployeeManager.GetEmployees())
        //        {
        //            ConnectContinuousSlot(employee);
        //        }

        //    }
        //    /*for (int i = 0; i < tableLayoutPanel.ColumnCount; i++) {
        //        for (int j = 0; j < tableLayoutPanel.RowCount; j++) {


        //            if (tableLayoutPanel.GetControlFromPosition(i, j) == null) continue;// i=0, j=0 is null
        //            if (tableLayoutPanel.GetControlFromPosition(i, j).GetType() == typeof(TimeSlotFlowPanel)) {//timeslotpanel filter
        //                foreach (Control control in tableLayoutPanel.GetControlFromPosition(i, j).Controls) {
        //                    if (control.GetType() == typeof(EmployeeItemCompact)) {
        //                        //Employee em = control.GetType().GetProperty("Employee").GetValue(control);
        //                        Console.WriteLine(control);
        //                        Console.WriteLine(tableLayoutPanel.GetControlFromPosition(i, j).GetType().GetProperty("Date").GetValue(tableLayoutPanel.GetControlFromPosition(i, j)));
        //                        Console.WriteLine(tableLayoutPanel.GetControlFromPosition(i, j).GetType().GetProperty("BeginTime").GetValue(tableLayoutPanel.GetControlFromPosition(i, j)));
        //                        Console.WriteLine(tableLayoutPanel.GetControlFromPosition(i, j).GetType().GetProperty("EndTime").GetValue(tableLayoutPanel.GetControlFromPosition(i, j)));
        //                        //EmployeeManager.UpdateOrSaveEmployee()
        //                        Console.WriteLine(control.GetType().GetProperty("Employee").GetValue(control).GetType());
        //                        Console.WriteLine(control.GetType().GetProperty("Employee").GetType());
        //                    }   

        //                }

        //            }

        //        }

        //    }*/
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    // delete all worktimes in employee

        //    /*Employee[] employees = EmployeeManager.GetEmployees();
        //    foreach(Employee employee in employees)
        //    {
        //        employee.workTime = null;
        //    }*/

        //    //deleteAllWorkingTimes();

        //    foreach (Control c in tableLayoutPanel.Controls)
        //    {
        //        if (c is TimeSlotFlowPanel)
        //        {
        //            TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;
        //            // check if anyone is here
        //            foreach (Control _c in slot.Controls)
        //            {
        //                if (_c is EmployeeItemCompact)
        //                {
        //                    EmployeeItemCompact compact = _c as EmployeeItemCompact;
        //                    // we found employee                            

        //                    List<WorkTime> workingTimes;

        //                    if (compact.Employee.workTime != null) workingTimes = compact.Employee.workTime.ToList();
        //                    else workingTimes = new List<WorkTime>();

        //                    // before we add, let's check if there's already one
        //                    bool found = false;
        //                    foreach (WorkTime t in workingTimes)
        //                    {
        //                        // check if there's already one
        //                        //if (t.StartTime == slot.BeginTime && t.EndTime == slot.EndTime)
        //                        /*if (IsTimeInRange(t.StartTime, slot.BeginTime, slot.EndTime) &&
        //                            IsTimeInRange(t.EndTime, slot.BeginTime, slot.EndTime))*/
        //                        if( (DateTime.Compare(t.StartTime, slot.BeginTime) <= 0) &&
        //                                (DateTime.Compare(slot.EndTime, t.EndTime) <= 0))
        //                        {
        //                            found = true;
        //                            break;
        //                        }
        //                    }

        //                    if (!found)
        //                    {
        //                        //MessageBox.Show("debug");
        //                        workingTimes.Add(new WorkTime()
        //                        {
        //                            StartTime = slot.BeginTime,
        //                            EndTime = slot.EndTime
        //                        });
        //                    }

        //                    compact.Employee.workTime = workingTimes.ToArray();
        //                    EmployeeManager.UpdateOrSaveEmployee(compact.Employee);
        //                }

        //            }
        //        }

        //        foreach (Employee employee in EmployeeManager.GetEmployees())
        //        {
        //            ConnectContinuousSlot(employee);
        //        }

        //    }

        //}

        /*private void SaveThisDay(DateTime time)
        {
            foreach (Control c in tableLayoutPanel.Controls)
            {
                if (c is TimeSlotFlowPanel)
                {
                    TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;
                    if (slot.BeginTime.Date == time) {
                        foreach (Control _c in slot.Controls)
                        {
                            if (_c is EmployeeItemCompact) {
                                EmployeeItemCompact compact = _c as EmployeeItemCompact;
                                List<WorkTime> workingTimes;
                                if (compact.Employee.workTime != null) workingTimes = compact.Employee.workTime.ToList();
                                else workingTimes = new List<WorkTime>();
                                if (compact.Employee.workTime != null) {
                                    foreach (WorkTime t in workingTimes) {
                                        if (t.StartTime == slot.BeginTime && t.EndTime == slot.EndTime) {
                                            workingTimes.Remove(t);
                                            break;
                                        }
                                    }
                                    compact.Employee.workTime = workingTimes.ToArray();
                                    EmployeeManager.UpdateOrSaveEmployee(compact.Employee);
                                }
                                

                            }
                        }   


                    }
                }
            }
            foreach (Control c in tableLayoutPanel.Controls)
            {
                if (c is TimeSlotFlowPanel)
                {
                    TimeSlotFlowPanel slot = c as TimeSlotFlowPanel;
                    if (slot.BeginTime.Date == time)
                    {
                        foreach (Control _c in slot.Controls)
                        {
                            if (_c is EmployeeItemCompact)
                            {
                                EmployeeItemCompact compact = _c as EmployeeItemCompact;
                                List<WorkTime> workingTimes;
                                if (compact.Employee.workTime != null) workingTimes = compact.Employee.workTime.ToList();
                                else workingTimes = new List<WorkTime>();

                                workingTimes.Add(new WorkTime()
                                {
                                    StartTime = slot.BeginTime,
                                    EndTime = slot.EndTime
                                });
                                compact.Employee.workTime = workingTimes.ToArray();
                                EmployeeManager.UpdateOrSaveEmployee(compact.Employee);
                            }
                        }
                    }
                }
            }
            foreach (Employee employee in EmployeeManager.GetEmployees())
            {
              ConnectContinuousSlot(employee);
            }

        }
        */

    }
}

