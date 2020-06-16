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
using Markdig;
using System.IO;



namespace RestaurantSystemUI.modules
{
    public partial class Report : UserControl, IThemeable
    {
        DateTime CurrentDate;
        Dictionary<string, int> myDic = new Dictionary<string, int>();

        public Report()
        {
            InitializeComponent();
        }
        string html;
        private void Report_Load(object sender, EventArgs e)
        {
            CurrentDate = DateTime.Now;

            DateTime startDate = new DateTime(2000, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            List<string> cblist = new List<string>();
            while (DateTime.Compare(startDate, endDate) <= 0)
            {
                cblist.Add(startDate.Year.ToString());
                //comboBox1.Items.Add(startDate.Year);
                startDate = startDate.AddYears(1);
            }
            cblist.Reverse();
            string[] cbArray = cblist.ToArray();
            comboBox1.Items.AddRange(cbArray);
            comboBox1.SelectedIndex = comboBox1.FindString(DateTime.Now.Year.ToString());//default
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
            }
            
            comboBox2.SelectedIndex = comboBox2.FindString(DateTime.Now.Month.ToString());
            //MessageBox.Show("debug");

            btnSave.Visible = false;
        }

        private int getTotal(Order ord)
        {
            int total = 0;
            foreach(Food food in ord.Foods)
            {
                total += food.Amount*(food.BasePrice + food.Varients[food.SelectedVarientIndex].delta);
            }

            return total;
        }
        private string getMealList(Order ord) {
            string meal = "";

            List<string> mealList = new List<string>();
            foreach (Food f in ord.Foods) {
                string key = f.Name + " (" + f.Varients[f.SelectedVarientIndex].Name + ") " +(f.BasePrice + f.Varients[f.SelectedVarientIndex].delta).ToString() + "元";
                if (myDic.ContainsKey(key))
                {
                    myDic[key] += f.Amount;
                }
                else {
                    myDic.Add(key, f.Amount);
                }
                myDic.ContainsKey(f.Name + " (" + f.Varients[f.SelectedVarientIndex].Name + ") ");
                mealList.Add("<li>"+f.Name +" (" + f.Varients[f.SelectedVarientIndex].Name +") " + (f.BasePrice + f.Varients[f.SelectedVarientIndex].delta).ToString()+"元 "+ f.Amount.ToString() + "個 </li>");
            }
            meal = string.Join("", mealList);
            
            return meal;

        }

        private int getWage(DateTime startTime, DateTime endTime, int CurrentWage) 
        {
            TimeSpan timeSpan = endTime.Subtract(startTime);
            return CurrentWage*(int)(timeSpan.TotalMinutes / 60.0);

        }
        private void btnMonth_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("請選擇報表年分");
                return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("請選擇報表月分");
                return;
            }
            int year = int.Parse(comboBox1.SelectedItem.ToString());
            int month = int.Parse(comboBox2.SelectedItem.ToString());
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            Employee[] employeeList = EmployeeManager.GetEmployees("clerk");
            List<Employee> MonthEmployeeList = new List<Employee>();
            List<Holder> holders = new List<Holder>();
            Order[] orderList = OrderManager.GetAllOrders();
            List<Order> MonthOrderList = new List<Order>();
            foreach (Employee employee in employeeList)
            {
                if (employee.workTime != null)
                    foreach (WorkTime t in employee.workTime)
                    {
                        if (t.StartTime >= startDate && t.StartTime < endDate)
                        {
                            if (MonthEmployeeList.Contains(employee) == false)
                                MonthEmployeeList.Add(employee);
                            holders.Add(new Holder(t, employee));
                        }

                    }

            }
            MonthEmployeeList = MonthEmployeeList.OrderBy(x => x.Name).ToList();
            //MonthEmployeeList.Sort();
            // get orders in this month;
            foreach (Order order in orderList)
            {
                if (order.CreatedAt >= startDate && order.CreatedAt < endDate)
                {
                    MonthOrderList.Add(order);
                }
            }
            //sort orders
            MonthOrderList.Sort((x, y) => DateTime.Compare(x.CreatedAt, y.CreatedAt));
            

            string md = string.Format("# {0}年{1}月營業報表  \n", comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());


            if (MonthEmployeeList.Count > 0)
            {
                md += "## 員工列表\n\n";
                List<string> lines = new List<string>
            {
            "| 員工 | 連絡電話   | 生日  |",
            "| :------: |:------:| :-----:|",
            };
                foreach (Employee em in MonthEmployeeList)
                {
                    lines.Add(string.Format("|{0}|{1}|{2}|", em.Name, em.ContactNumber, em.Birthday.ToShortDateString()));
                }

                md += string.Join("\n", lines);
                md += "\n\n";
            }
            else
            {
                md += "## 員工列表\n\n";
                md += "### 該月無資料\n\n";
            }

            if (holders.Count > 0)
            {
                md += "## 出勤狀況\n\n";
                List<string> tb = new List<string>
            {
            "| 名字 | 應到時間 | 應退時間   | 實際打卡上班時間 |上班簽名| 實際打卡下班時間 |下班簽名 |狀態 |時薪|工資|",
            "|:---: | :------: |:--------:| :--------------:|:-----:|:--------------:|:-------:|:---:|:--:|:--:|",
            };
                //sort by datetime
                holders.Sort((x, y) => DateTime.Compare(x.worktime.StartTime, y.worktime.StartTime));

                string status = "";
                string ActualStart = "";
                string ActualEnd = "";
                string CheckInSignature = "";
                string CheckOutSignature = "";
                string StartLateMinutes = "";
                string EndEarlyMinutes = "";
                
                TimeSpan timeSpan, timeSpan1;
                int count, count1;
                foreach (Holder holder in holders)
                {
                    if (holder.worktime.ActualStart == null || holder.worktime.ActualEnd == null)
                    {
                        if (holder.worktime.ActualStart == null)
                        {
                            status = "未打卡";
                            ActualStart = "未打上班卡";
                            CheckInSignature = "尚未上班簽名";
                        }
                        else
                        {
                            ActualStart = holder.worktime.ActualStart.Value.ToString("yyyy/M/d HH:mm");
                            CheckInSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckInSignature)) + ")";
                           
                        }
                        if (holder.worktime.ActualEnd == null)
                        {
                            status = "未打卡";
                            ActualEnd = "未打下班卡";
                            CheckOutSignature = "尚未下班簽名";
                        }
                        else
                        {
                            ActualEnd = holder.worktime.ActualEnd.Value.ToString("yyyy/M/d HH:mm");
                            CheckOutSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckOutSignature)) + ")";
                        }
                    }
                    else if (IsTimeInRange(holder.worktime.ActualStart.Value, holder.worktime.StartTime.AddMinutes(-10), holder.worktime.StartTime) && IsTimeInRange(holder.worktime.ActualEnd.Value, holder.worktime.EndTime, holder.worktime.EndTime.AddMinutes(10)))
                    {
                        status = "已打卡";
                        ActualStart = holder.worktime.ActualStart.Value.ToString("yyyy/M/d HH:mm");
                        ActualEnd = holder.worktime.ActualEnd.Value.ToString("yyyy/M/d HH:mm");
                        CheckInSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckInSignature)) + ")";
                        CheckOutSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckOutSignature)) + ")";

                    }
                    else
                    {
                        timeSpan = holder.worktime.ActualStart.Value.Subtract(holder.worktime.StartTime);
                        timeSpan1 = holder.worktime.EndTime.Subtract(holder.worktime.ActualEnd.Value);
                        count = (int)timeSpan.TotalMinutes;
                        count1 = (int)timeSpan1.TotalMinutes;
                        if (count > 0)
                        {
                            StartLateMinutes = "<br>(遲到" + count.ToString() + "分鐘)";
                        }
                        else
                        {
                            StartLateMinutes = "";
                        }
                        if (count1 > 0)
                        {
                            EndEarlyMinutes = "<br>(早退" + count1.ToString() + "分鐘)";
                        }
                        else
                        {
                            EndEarlyMinutes = "";
                        }
                        status = "打卡異常";
                        ActualStart = holder.worktime.ActualStart.Value.ToString("yyyy/M/d HH:mm")+StartLateMinutes;
                        ActualEnd = holder.worktime.ActualEnd.Value.ToString("yyyy/M/d HH:mm")+EndEarlyMinutes;
                        CheckInSignature = "![員工簽名圖檔](data:image/png;base64,"+Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckInSignature))+")";
                        CheckOutSignature = "![員工簽名圖檔](data:image/png;base64,"+Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckOutSignature))+")";
                    }
                    

                    tb.Add(string.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|",
                        holder.employee.Name.ToString(),
                        holder.worktime.StartTime.ToString("yyyy/M/d HH:mm"),
                        holder.worktime.EndTime.ToString("yyyy/M/d HH:mm"),
                        ActualStart,
                        CheckInSignature,
                        ActualEnd,
                        CheckOutSignature,
                        status,
                        holder.worktime.CurrentWage.ToString()+"元",
                        getWage(holder.worktime.StartTime, holder.worktime.EndTime, holder.worktime.CurrentWage)+"元"
                        ));
                }
                md += string.Join("\n", tb);
                md += "\n\n";
            }
            else
            {
                md += "## 出勤狀況\n\n";
                md += "### 該月無資料\n\n";
            }

            if (MonthEmployeeList.Count > 0)
            {

                md += "## 員工月薪\n\n";
                List<string> salary = new List<string>
                {
                "| 名字  |本月薪資 | ",
                "|:----:|:------:|",

                };

                int sum = 0; 
                foreach (Employee em in MonthEmployeeList)
                {
                    foreach(Holder holder in holders)
                    {
                        if(holder.employee == em)
                        {
                            sum += getWage(holder.worktime.StartTime, holder.worktime.EndTime, holder.worktime.CurrentWage);
                        }
                    }
                    salary.Add(string.Format("|{0}|{1}|", em.Name, sum.ToString()+"元"));
                    sum = 0;
                }

                md += string.Join("\n", salary);

                md += "\n\n";
            }
            else
            {
                md += "## 員工月薪\n\n";
                md += "### 該月無資料\n\n";
            }




            if (MonthOrderList.Count > 0)
            {
                md += "## 銷售訂單\n\n";

                List<string> myorder = new List<string>
            {
            "| 訂單 |開始時間   | 結束時間  | 餐點|金額 | ",
            "|:-----:|:-------:| :------:|---|:----: |",
            };
                int count = 0;
                int sum = 0;
                string FinishedAt = "";
                string mealist = "";
                string DicFriend = "";
                myDic.Clear();
                foreach (Order o in MonthOrderList)
                {
                    count++;
                    sum += getTotal(o);
                    mealist = getMealList(o);
                    if (o.Status != Order.OrderStatus.Finished)
                    {
                        FinishedAt = "訂單尚未完成";
                    }
                    else
                    {
                        FinishedAt = o.FinishedAt.ToString("yyyy/M/d HH:mm");
                    }
                    myorder.Add(string.Format("No.{0}|{1}|{2}|{3}|{4}元", 
                        count,
                        o.CreatedAt.ToString("yyyy/M/d HH:mm"),
                        FinishedAt,
                        mealist,
                        getTotal(o)));
                }
                md += string.Join("\n", myorder);
                md += "\n";



                var MyDic = myDic.OrderBy(x => x.Key).ToList();

                foreach (var item in MyDic)
                {
                    DicFriend += "<li>" + item.Key + " " + item.Value + "個</li>";
                }
                md += string.Format("共{0}筆訂單|||{1}|共{2}元", count, DicFriend, sum);
                md += "\n\n";
            }
            else
            {
                md += "## 銷售訂單\n\n";
                md += "### 該月無資料\n\n";
            }


            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            html = Markdig.Markdown.ToHtml(md, pipeline);

            //string style = "<style> body{ font-family: Arial Unicode MS; color:red;}</style>";

            // read template
            string template;
            using (StreamReader sr = new StreamReader("templates\\report.html"))
            {
                template = sr.ReadToEnd();
            }
            // read style sheets to use
            const string styleName = "github-markdown.css";
            string stylesheets;
            using (StreamReader sr = new StreamReader(String.Format("templates\\{0}", styleName)))
            {
                stylesheets = sr.ReadToEnd();
            }


            //MessageBox.Show(template);

            string fullHTML = template.Replace("{0}", html);
            fullHTML = fullHTML.Replace("{1}", stylesheets);
            // for debug purpose
            using (StreamWriter sw = new StreamWriter("debug.html"))
            {
                sw.Write(fullHTML);
            }

            webBrowser1.DocumentText = fullHTML;

            btnSave.Visible = true;
            webBrowser1.Visible = true;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            if (html == null)
            {
                MessageBox.Show("請先產生報表才能儲存");
                return;
            }

            webBrowser1.ShowPrintDialog();



            //SaveFileDialog save = new SaveFileDialog();
            //save.Filter = "PDF|*.pdf";
            //MessageBox.Show(html);
            //if (save.ShowDialog() == DialogResult.OK)
            {
                //FileStream fs = (FileStream)save.OpenFile();
                //PdfDocument pdf = PdfGenerator.GeneratePdf(html, PageSize.A4);
                
                
                //pdf.Save(fs);
                
                /*
                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "PDFSHARP测试";

                // Create an empty page
                PdfPage page = document.AddPage();

                // Get an XGraphics object for drawing
                XGraphics gfx = XGraphics.FromPdfPage(page);
                //gfx.MFEH = PdfFontEmbedding.Automatic;
                //XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

                System.Drawing.Text.PrivateFontCollection pfcFonts = new System.Drawing.Text.PrivateFontCollection();
                string strFontPath = @"C:/Windows/Fonts/msyh.ttf";//字体设置为微软雅黑
                //pfcFonts.AddFontFile(strFontPath);

                XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
                //XFont font = new XFont(pfcFonts.Families[0], 15, XFontStyle.Regular, options);

                // Create a font
                //XFont font = new XFont("Times New Roman", 20, XFontStyle.BoldItalic);
                //XFont font = new XFont("Arial Unicode MS", 12, XFontStyle.Regular, options);
                XFont font = new XFont("標楷體", 12, XFontStyle.Bold, options);
                // Draw the text
                //gfx.DrawString("你好", font, XBrushes.Black,
                //  new XRect(0, 0, page.Width, page.Height),
                //  XStringFormats.Center);
                gfx.DrawString(html, font, XBrushes.Black, 5f, 5f);
               
                // Save the document...
                string filename = "HelloWorld_1"+ ".pdf";
                document.Save(fs);*/


            }
        }
        private bool IsTimeInRange(DateTime target, DateTime begin, DateTime end)
        {
            return (DateTime.Compare(target, begin) >= 0) && (DateTime.Compare(target, end) <= 0);
        }


        private void btnHistory_Click(object sender, EventArgs e)
        {

            DateTime startDate = new DateTime(2000, 1, 1);
            DateTime endDate = new DateTime(2000, 1, DateTime.DaysInMonth(1, 1));
            
            DateTime thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            Employee[]employeeList = EmployeeManager.GetEmployees("clerk");
            Order[] orderArray = OrderManager.GetAllOrders();
            List<Order> HistoryOrderList= orderArray.OfType<Order>().ToList();
            //DateTime startDate = new DateTime(year, month, 1);

            string md = "";
            while(DateTime.Compare(startDate, thisMonth) <= 0)
            {
                
                List<Employee> MonthEmployeeList = new List<Employee>();
                List<Holder> holders = new List<Holder>();
                List<Order> MonthOrderList = new List<Order>();

                foreach (Employee employee in employeeList)
                {
                    if (employee.workTime != null)
                        foreach (WorkTime t in employee.workTime)
                        {
                            if (t.StartTime >= startDate && t.StartTime < endDate)
                            {
                                if (MonthEmployeeList.Contains(employee) == false)
                                    MonthEmployeeList.Add(employee);
                                holders.Add(new Holder(t, employee));
                            }

                        }

                }
                MonthEmployeeList = MonthEmployeeList.OrderBy(x => x.Name).ToList();
                foreach (Order order in orderArray)
                {
                    if (order.CreatedAt >= startDate && order.CreatedAt < endDate)
                    {
                        MonthOrderList.Add(order);
                    }
                }
                

                //sort orders
                MonthOrderList.Sort((x, y) => DateTime.Compare(x.CreatedAt, y.CreatedAt));

                Console.WriteLine(startDate.Year.ToString()+" "+ startDate.Month.ToString()+" "+MonthEmployeeList.Count().ToString()+" "+ MonthOrderList.Count.ToString());
                if (MonthEmployeeList.Count() == 0 && holders.Count == 0 && MonthOrderList.Count == 0 )
                {
                    
                }
                else
                {
                    md += string.Format("# {0}年{1}月營業報表  \n", startDate.Year.ToString(), startDate.Month.ToString());


                    if (MonthEmployeeList.Count > 0)
                    {
                        md += "## 員工列表\n\n";
                        List<string> lines = new List<string>
                    {
                    "| 員工 | 連絡電話   | 生日  |",
                    "| :------: |:------:| :-----:|",
                    };
                        foreach (Employee em in MonthEmployeeList)
                        {
                            lines.Add(string.Format("|{0}|{1}|{2}|", em.Name, em.ContactNumber, em.Birthday.ToShortDateString()));
                        }

                        md += string.Join("\n", lines);
                        md += "\n\n";
                    }
                    else
                    {
                        md += "## 員工列表\n\n";
                        md += "### 該月無資料\n\n";
                    }
                    if (holders.Count > 0)
                    {
                        md += "## 出勤狀況\n\n";
                        List<string> tb = new List<string>
                        {
                        "| 名字 | 應到時間 | 應退時間   | 實際打卡上班時間 |上班簽名| 實際打卡下班時間 |下班簽名 |狀態 |時薪|工資|",
                        "|:---: | :------: |:--------:| :--------------:| :---:|:--------------:|:-----:|:------:|:---:|:--:|",
                        };
                        //sort by datetime
                        holders.Sort((x, y) => DateTime.Compare(x.worktime.StartTime, y.worktime.StartTime));

                        string status = "";
                        string ActualStart = "";
                        string ActualEnd = "";
                        string CheckInSignature = "";
                        string CheckOutSignature = "";
                        string StartLateMinutes = "";
                        string EndEarlyMinutes = "";
                        TimeSpan timeSpan, timeSpan1;
                        int count, count1;
                        foreach (Holder holder in holders)
                        {
                            if (holder.worktime.ActualStart == null || holder.worktime.ActualEnd == null)
                            {
                                if (holder.worktime.ActualStart == null)
                                {
                                    status = "未打卡";
                                    ActualStart = "未打上班卡";
                                    CheckInSignature = "尚未上班簽名";
                                }
                                else
                                {
                                    ActualStart = holder.worktime.ActualStart.Value.ToString("yyyy/M/d HH:mm");
                                    CheckInSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckInSignature)) + ")";

                                }
                                if (holder.worktime.ActualEnd == null)
                                {
                                    status = "未打卡";
                                    ActualEnd = "未打下班卡";
                                    CheckOutSignature = "尚未下班簽名";
                                }
                                else
                                {
                                    ActualEnd = holder.worktime.ActualEnd.Value.ToString("yyyy/M/d HH:mm");
                                    CheckOutSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckOutSignature)) + ")";
                                }
                            }
                            else if (IsTimeInRange(holder.worktime.ActualStart.Value, holder.worktime.StartTime.AddMinutes(-10), holder.worktime.StartTime) && IsTimeInRange(holder.worktime.ActualEnd.Value, holder.worktime.EndTime, holder.worktime.EndTime.AddMinutes(10)))
                            {
                                status = "已打卡";
                                ActualStart = holder.worktime.ActualStart.Value.ToString("yyyy/M/d HH:mm");
                                ActualEnd = holder.worktime.ActualEnd.Value.ToString("yyyy/M/d HH:mm");
                                CheckInSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckInSignature)) + ")";
                                CheckOutSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckOutSignature)) + ")";

                            }
                            else
                            {
                                timeSpan = holder.worktime.ActualStart.Value.Subtract(holder.worktime.StartTime);
                                timeSpan1 = holder.worktime.EndTime.Subtract(holder.worktime.ActualEnd.Value);
                                count = (int)timeSpan.TotalMinutes;
                                count1 = (int)timeSpan1.TotalMinutes;
                                if (count > 0)
                                {
                                    StartLateMinutes = "<br>(遲到" + count.ToString() + "分鐘)";
                                }
                                else
                                {
                                    StartLateMinutes = "";
                                }
                                if (count1 > 0)
                                {
                                    EndEarlyMinutes = "<br>(早退" + count1.ToString() + "分鐘)";
                                }
                                else
                                {
                                    EndEarlyMinutes = "";
                                }
                                status = "打卡異常";
                                ActualStart = holder.worktime.ActualStart.Value.ToString("yyyy/M/d HH:mm") + StartLateMinutes; ;
                                ActualEnd = holder.worktime.ActualEnd.Value.ToString("yyyy/M/d HH:mm") + EndEarlyMinutes;
                                CheckInSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckInSignature)) + ")";
                                CheckOutSignature = "![員工簽名圖檔](data:image/png;base64," + Utility.ImageToBase64(Utility.BytesToImage(holder.worktime.CheckOutSignature)) + ")";
                            }
                            tb.Add(string.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|",
                                holder.employee.Name.ToString(),
                                holder.worktime.StartTime.ToString("yyyy/M/d HH:mm"),
                                holder.worktime.EndTime.ToString("yyyy/M/d HH:mm"),
                                ActualStart,
                                CheckInSignature,
                                ActualEnd,
                                CheckOutSignature,
                                status,
                                holder.worktime.CurrentWage.ToString()+"元",
                                getWage(holder.worktime.StartTime, holder.worktime.EndTime, holder.worktime.CurrentWage)+"元"

                                ));
                        }
                        md += string.Join("\n", tb);
                        md += "\n\n";
                    }
                    else
                    {
                        md += "## 出勤狀況\n\n";
                        md += "### 該月無資料\n\n";
                    }



                    if (MonthEmployeeList.Count > 0)
                    {

                        md += "## 員工月薪\n\n";
                        List<string> salary = new List<string>
                        {
                        "| 名字  |本月薪資 | ",
                        "|:----:|:------:|",

                        };

                        int sum = 0;
                        foreach (Employee em in MonthEmployeeList)
                        {
                            foreach (Holder holder in holders)
                            {
                                if (holder.employee == em)
                                {
                                    sum += getWage(holder.worktime.StartTime, holder.worktime.EndTime, holder.worktime.CurrentWage);
                                }
                            }
                            salary.Add(string.Format("|{0}|{1}|", em.Name, sum.ToString()+"元"));
                            sum = 0;
                        }

                        md += string.Join("\n", salary);

                        md += "\n\n";
                    }
                    else
                    {
                        md += "## 員工月薪\n\n";
                        md += "### 該月無資料\n\n";
                    }



                    if (MonthOrderList.Count > 0)
                    {
                        md += "## 銷售訂單\n\n";

                        //sort orders
                        MonthOrderList.Sort((x, y) => DateTime.Compare(x.CreatedAt, y.CreatedAt));
                        List<string> myorder = new List<string>
                        {
                        "| 訂單 |開始時間   | 結束時間  | 餐點|金額 | ",
                        "|:-----:|:-------:| :------:|---|:----: |",
                        };
                        int count = 0;
                        int sum = 0;
                        string FinishedAt = "";
                        string mealist = "";
                        string DicFriend = "";
                        myDic.Clear();
                        foreach (Order o in MonthOrderList)
                        {
                            count++;
                            sum += getTotal(o);
                            mealist = getMealList(o);
                            if (o.Status != Order.OrderStatus.Finished)
                            {
                                FinishedAt = "訂單尚未完成";
                            }
                            else
                            {
                                FinishedAt = o.FinishedAt.ToString("yyyy/M/d HH:mm");
                            }
                            myorder.Add(string.Format("No.{0}|{1}|{2}|{3}|{4}元", count,
                                o.CreatedAt.ToString("yyyy/M/d HH:mm"),
                                FinishedAt,
                                mealist,
                                getTotal(o)));
                        }
                        md += string.Join("\n", myorder);
                        md += "\n";
                        var MyDic = myDic.OrderBy(x => x.Key).ToList();
                        foreach (var item in MyDic)
                        {
                            DicFriend += "<li>" + item.Key + " " + item.Value + "個</li>";
                        }
                        md += string.Format("共{0}筆訂單|||{1}|共{2}元", count, DicFriend, sum);
                        md += "\n\n";
                    }
                    else
                    {
                        md += "## 銷售訂單\n\n";
                        md += "### 該月無資料\n\n";
                    }                    
                }

                startDate = startDate.AddMonths(1);
                endDate = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));
                
            }

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            html = Markdig.Markdown.ToHtml(md, pipeline);

            //string style = "<style> body{ font-family: Arial Unicode MS; color:red;}</style>";

            // read template
            string template;
            using (StreamReader sr = new StreamReader("templates\\report.html"))
            {
                template = sr.ReadToEnd();
            }
            // read style sheets to use
            const string styleName = "github-markdown.css";
            string stylesheets;
            using (StreamReader sr = new StreamReader(String.Format("templates\\{0}", styleName)))
            {
                stylesheets = sr.ReadToEnd();
            }


            //MessageBox.Show(template);

            string fullHTML = template.Replace("{0}", html);
            fullHTML = fullHTML.Replace("{1}", stylesheets);
            // for debug purpose
            using (StreamWriter sw = new StreamWriter("debug.html"))
            {
                sw.Write(fullHTML);
            }

            webBrowser1.DocumentText = fullHTML;
            btnSave.Visible = true;
            webBrowser1.Visible = true;

        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            
            BackColor = theme.ContentPanel;
            panel1.BackColor = theme.ContentPanel;
        }
    }

    class Holder
    {
        public WorkTime worktime;
        public Employee employee;
        public Holder(WorkTime _worktime, Employee _employee)
        {
            worktime = _worktime;
            employee = _employee;
        }
    }
}
