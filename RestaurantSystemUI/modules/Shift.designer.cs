namespace RestaurantSystemUI
{
    partial class Shift
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.lbSystemTime = new RestaurantSystemUI.controls.ThemedLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFormat = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGodMode = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NextWeekButton = new RestaurantSystemUI.controls.ThemedIconButton();
            this.PreviousWeekButton = new RestaurantSystemUI.controls.ThemedIconButton();
            this.CurrentWeekLabel = new RestaurantSystemUI.controls.ThemedLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(113, 506);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.container);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(113, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 506);
            this.panel1.TabIndex = 4;
            // 
            // container
            // 
            this.container.AllowDrop = true;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 179);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.container.Size = new System.Drawing.Size(914, 327);
            this.container.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.lbSystemTime);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbGodMode);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 179);
            this.panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconSize = 18;
            this.btnClear.Location = new System.Drawing.Point(504, 49);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.MinimumSize = new System.Drawing.Size(7, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Rotation = 0D;
            this.btnClear.Size = new System.Drawing.Size(154, 36);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "清除所有排班";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbSystemTime.ForeColor = System.Drawing.Color.White;
            this.lbSystemTime.Location = new System.Drawing.Point(195, 12);
            this.lbSystemTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(142, 28);
            this.lbSystemTime.TabIndex = 16;
            this.lbSystemTime.Text = "SystemTime";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFormat);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(15, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 53);
            this.panel4.TabIndex = 2;
            // 
            // btnFormat
            // 
            this.btnFormat.AutoSize = true;
            this.btnFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFormat.ForeColor = System.Drawing.Color.White;
            this.btnFormat.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnFormat.IconColor = System.Drawing.Color.White;
            this.btnFormat.IconSize = 18;
            this.btnFormat.Location = new System.Drawing.Point(478, 10);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormat.MinimumSize = new System.Drawing.Size(7, 8);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Rotation = 0D;
            this.btnFormat.Size = new System.Drawing.Size(154, 36);
            this.btnFormat.TabIndex = 0;
            this.btnFormat.Text = "儲存排班格式";
            this.btnFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(385, 14);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(82, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "幾個";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(249, 15);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(193, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "間隔";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "起始時間";
            // 
            // cbGodMode
            // 
            this.cbGodMode.AutoSize = true;
            this.cbGodMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbGodMode.Location = new System.Drawing.Point(426, 62);
            this.cbGodMode.Margin = new System.Windows.Forms.Padding(2);
            this.cbGodMode.Name = "cbGodMode";
            this.cbGodMode.Size = new System.Drawing.Size(73, 17);
            this.cbGodMode.TabIndex = 15;
            this.cbGodMode.Text = "GodMode";
            this.cbGodMode.UseVisualStyleBackColor = true;
            this.cbGodMode.CheckedChanged += new System.EventHandler(this.cbGodMode_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NextWeekButton);
            this.panel3.Controls.Add(this.PreviousWeekButton);
            this.panel3.Controls.Add(this.CurrentWeekLabel);
            this.panel3.Location = new System.Drawing.Point(27, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 52);
            this.panel3.TabIndex = 2;
            // 
            // NextWeekButton
            // 
            this.NextWeekButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NextWeekButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NextWeekButton.FlatAppearance.BorderSize = 0;
            this.NextWeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextWeekButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NextWeekButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.NextWeekButton.ForeColor = System.Drawing.Color.White;
            this.NextWeekButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.NextWeekButton.IconColor = System.Drawing.Color.White;
            this.NextWeekButton.IconSize = 30;
            this.NextWeekButton.Location = new System.Drawing.Point(326, 5);
            this.NextWeekButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextWeekButton.MinimumSize = new System.Drawing.Size(7, 8);
            this.NextWeekButton.Name = "NextWeekButton";
            this.NextWeekButton.Rotation = 0D;
            this.NextWeekButton.Size = new System.Drawing.Size(43, 39);
            this.NextWeekButton.TabIndex = 1;
            this.NextWeekButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NextWeekButton.UseVisualStyleBackColor = true;
            this.NextWeekButton.Click += new System.EventHandler(this.NextWeekButton_Click);
            // 
            // PreviousWeekButton
            // 
            this.PreviousWeekButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PreviousWeekButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PreviousWeekButton.FlatAppearance.BorderSize = 0;
            this.PreviousWeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousWeekButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PreviousWeekButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.PreviousWeekButton.ForeColor = System.Drawing.Color.White;
            this.PreviousWeekButton.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.PreviousWeekButton.IconColor = System.Drawing.Color.White;
            this.PreviousWeekButton.IconSize = 30;
            this.PreviousWeekButton.Location = new System.Drawing.Point(19, 5);
            this.PreviousWeekButton.Margin = new System.Windows.Forms.Padding(2);
            this.PreviousWeekButton.MinimumSize = new System.Drawing.Size(7, 8);
            this.PreviousWeekButton.Name = "PreviousWeekButton";
            this.PreviousWeekButton.Rotation = 0D;
            this.PreviousWeekButton.Size = new System.Drawing.Size(43, 39);
            this.PreviousWeekButton.TabIndex = 0;
            this.PreviousWeekButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PreviousWeekButton.UseVisualStyleBackColor = true;
            this.PreviousWeekButton.Click += new System.EventHandler(this.PreviousWeekButton_Click);
            // 
            // CurrentWeekLabel
            // 
            this.CurrentWeekLabel.AutoSize = true;
            this.CurrentWeekLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CurrentWeekLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentWeekLabel.Location = new System.Drawing.Point(74, 14);
            this.CurrentWeekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentWeekLabel.Name = "CurrentWeekLabel";
            this.CurrentWeekLabel.Size = new System.Drawing.Size(236, 19);
            this.CurrentWeekLabel.TabIndex = 0;
            this.CurrentWeekLabel.Text = "2020年6月14日~2020年6月20日";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Shift
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Shift";
            this.Size = new System.Drawing.Size(1027, 506);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Shift_GiveFeedback);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbGodMode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private controls.ThemedLabel lbSystemTime;
        private controls.ThemedLabel CurrentWeekLabel;
        private controls.ThemedIconTextButton btnClear;
        private controls.ThemedIconTextButton btnFormat;
        private controls.ThemedIconButton PreviousWeekButton;
        private controls.ThemedIconButton NextWeekButton;
    }
}
