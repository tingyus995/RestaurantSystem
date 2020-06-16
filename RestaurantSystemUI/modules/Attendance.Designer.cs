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
            this.lbSystemTime = new RestaurantSystemUI.controls.ThemedLabel();
            this.cbGodMode = new System.Windows.Forms.CheckBox();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.CBSelect = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnEmployeeList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.lbSystemTime);
            this.panel1.Controls.Add(this.cbGodMode);
            this.panel1.Controls.Add(this.themedLabel1);
            this.panel1.Controls.Add(this.CBSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 72);
            this.panel1.TabIndex = 1;
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbSystemTime.ForeColor = System.Drawing.Color.White;
            this.lbSystemTime.Location = new System.Drawing.Point(500, 14);
            this.lbSystemTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(142, 28);
            this.lbSystemTime.TabIndex = 4;
            this.lbSystemTime.Text = "SystemTime";
            // 
            // cbGodMode
            // 
            this.cbGodMode.AutoSize = true;
            this.cbGodMode.Location = new System.Drawing.Point(429, 20);
            this.cbGodMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGodMode.Name = "cbGodMode";
            this.cbGodMode.Size = new System.Drawing.Size(73, 17);
            this.cbGodMode.TabIndex = 3;
            this.cbGodMode.Text = "GodMode";
            this.cbGodMode.UseVisualStyleBackColor = true;
            this.cbGodMode.CheckedChanged += new System.EventHandler(this.cbGodMode_CheckedChanged);
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(18, 14);
            this.themedLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(188, 28);
            this.themedLabel1.TabIndex = 2;
            this.themedLabel1.Text = "選擇上班打卡時段";
            // 
            // CBSelect
            // 
            this.CBSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSelect.FormattingEnabled = true;
            this.CBSelect.Location = new System.Drawing.Point(205, 19);
            this.CBSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBSelect.Name = "CBSelect";
            this.CBSelect.Size = new System.Drawing.Size(211, 21);
            this.CBSelect.TabIndex = 1;
            this.CBSelect.SelectedIndexChanged += new System.EventHandler(this.CBSelect_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnEmployeeList
            // 
            this.pnEmployeeList.AutoScroll = true;
            this.pnEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmployeeList.Location = new System.Drawing.Point(0, 103);
            this.pnEmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnEmployeeList.Name = "pnEmployeeList";
            this.pnEmployeeList.Size = new System.Drawing.Size(870, 467);
            this.pnEmployeeList.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 31);
            this.panel2.TabIndex = 2;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.pnEmployeeList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(870, 570);
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox CBSelect;
        private System.Windows.Forms.FlowLayoutPanel pnEmployeeList;
        private System.Windows.Forms.CheckBox cbGodMode;
        private controls.ThemedLabel themedLabel1;
        private controls.ThemedLabel lbSystemTime;
        private System.Windows.Forms.Panel panel2;
    }
}
