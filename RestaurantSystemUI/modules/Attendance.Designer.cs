namespace RestaurantSystemUI.modules
{
    partial class Attendance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbSystemTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbCurrentShift = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnEmployeeList = new System.Windows.Forms.FlowLayoutPanel();
            this.ftbMonth = new RestaurantSystemUI.FlatTextbox();
            this.ftbYear = new RestaurantSystemUI.FlatTextbox();
            this.ftbDay = new RestaurantSystemUI.FlatTextbox();
            this.ftbMin = new RestaurantSystemUI.FlatTextbox();
            this.ftbHour = new RestaurantSystemUI.FlatTextbox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.lbSystemTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 100);
            this.panel1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(141, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(315, 26);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.lbSystemTime.Location = new System.Drawing.Point(11, 34);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(94, 18);
            this.lbSystemTime.TabIndex = 0;
            this.lbSystemTime.Text = "SystemTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ftbMonth);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.ftbYear);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.ftbDay);
            this.panel4.Controls.Add(this.btnSetTime);
            this.panel4.Controls.Add(this.ftbMin);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ftbHour);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(49, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1116, 57);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(187, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 41);
            this.label5.TabIndex = 17;
            this.label5.Text = "Month";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 41);
            this.label4.TabIndex = 15;
            this.label4.Text = "Year";
            // 
            // btnSetTime
            // 
            this.btnSetTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSetTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTime.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTime.ForeColor = System.Drawing.Color.White;
            this.btnSetTime.Location = new System.Drawing.Point(950, 3);
            this.btnSetTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(145, 48);
            this.btnSetTime.TabIndex = 13;
            this.btnSetTime.Text = "設置時間";
            this.btnSetTime.UseVisualStyleBackColor = false;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(744, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Min";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(557, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hour";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Day";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbCurrentShift);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(14, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(513, 61);
            this.panel5.TabIndex = 1;
            // 
            // lbCurrentShift
            // 
            this.lbCurrentShift.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCurrentShift.AutoSize = true;
            this.lbCurrentShift.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCurrentShift.ForeColor = System.Drawing.Color.White;
            this.lbCurrentShift.Location = new System.Drawing.Point(224, 17);
            this.lbCurrentShift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrentShift.Name = "lbCurrentShift";
            this.lbCurrentShift.Size = new System.Drawing.Size(132, 25);
            this.lbCurrentShift.TabIndex = 17;
            this.lbCurrentShift.Text = "目前上班時段";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "目前上班時段";
            // 
            // pnEmployeeList
            // 
            this.pnEmployeeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnEmployeeList.Location = new System.Drawing.Point(0, 300);
            this.pnEmployeeList.Name = "pnEmployeeList";
            this.pnEmployeeList.Size = new System.Drawing.Size(577, 489);
            this.pnEmployeeList.TabIndex = 4;
            // 
            // ftbMonth
            // 
            this.ftbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbMonth.Location = new System.Drawing.Point(314, 3);
            this.ftbMonth.Margin = new System.Windows.Forms.Padding(6);
            this.ftbMonth.Name = "ftbMonth";
            this.ftbMonth.PlaceHolder = "";
            this.ftbMonth.Size = new System.Drawing.Size(75, 50);
            this.ftbMonth.TabIndex = 18;
            // 
            // ftbYear
            // 
            this.ftbYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbYear.Location = new System.Drawing.Point(92, 5);
            this.ftbYear.Margin = new System.Windows.Forms.Padding(6);
            this.ftbYear.Name = "ftbYear";
            this.ftbYear.PlaceHolder = "";
            this.ftbYear.Size = new System.Drawing.Size(76, 50);
            this.ftbYear.TabIndex = 16;
            // 
            // ftbDay
            // 
            this.ftbDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbDay.Location = new System.Drawing.Point(475, 2);
            this.ftbDay.Margin = new System.Windows.Forms.Padding(6);
            this.ftbDay.Name = "ftbDay";
            this.ftbDay.PlaceHolder = "";
            this.ftbDay.Size = new System.Drawing.Size(75, 50);
            this.ftbDay.TabIndex = 14;
            // 
            // ftbMin
            // 
            this.ftbMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbMin.Location = new System.Drawing.Point(831, 2);
            this.ftbMin.Margin = new System.Windows.Forms.Padding(6);
            this.ftbMin.Name = "ftbMin";
            this.ftbMin.PlaceHolder = "";
            this.ftbMin.Size = new System.Drawing.Size(84, 50);
            this.ftbMin.TabIndex = 9;
            // 
            // ftbHour
            // 
            this.ftbHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbHour.Location = new System.Drawing.Point(662, 1);
            this.ftbHour.Margin = new System.Windows.Forms.Padding(6);
            this.ftbHour.Name = "ftbHour";
            this.ftbHour.PlaceHolder = "";
            this.ftbHour.Size = new System.Drawing.Size(76, 50);
            this.ftbHour.TabIndex = 7;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.pnEmployeeList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(1305, 789);
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSystemTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private FlatTextbox ftbMin;
        private System.Windows.Forms.Label label3;
        private FlatTextbox ftbHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetTime;
        private FlatTextbox ftbMonth;
        private System.Windows.Forms.Label label5;
        private FlatTextbox ftbYear;
        private System.Windows.Forms.Label label4;
        private FlatTextbox ftbDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbCurrentShift;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.FlowLayoutPanel pnEmployeeList;
    }
}
