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
            this.btnFormat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGodMode = new System.Windows.Forms.CheckBox();
            this.lbSystemTime = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NextWeekButton = new FontAwesome.Sharp.IconPictureBox();
            this.CurrentWeekButton = new FontAwesome.Sharp.IconButton();
            this.PreviousWeekButton = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextWeekButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousWeekButton)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 700);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.container);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 700);
            this.panel1.TabIndex = 4;
            // 
            // container
            // 
            this.container.AllowDrop = true;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 189);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1370, 511);
            this.container.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Controls.Add(this.btnFormat);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbGodMode);
            this.panel2.Controls.Add(this.lbSystemTime);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 189);
            this.panel2.TabIndex = 1;
            // 
            // btnFormat
            // 
            this.btnFormat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.ForeColor = System.Drawing.Color.White;
            this.btnFormat.Location = new System.Drawing.Point(959, 20);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(214, 48);
            this.btnFormat.TabIndex = 14;
            this.btnFormat.Text = "儲存排班格式";
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(23, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(990, 74);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(673, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "起始時間";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(545, 24);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 26);
            this.comboBox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(470, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "幾個";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(342, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "間隔";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "起始時間";
            // 
            // cbGodMode
            // 
            this.cbGodMode.AutoSize = true;
            this.cbGodMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbGodMode.Location = new System.Drawing.Point(665, 48);
            this.cbGodMode.Name = "cbGodMode";
            this.cbGodMode.Size = new System.Drawing.Size(101, 22);
            this.cbGodMode.TabIndex = 15;
            this.cbGodMode.Text = "GodMode";
            this.cbGodMode.UseVisualStyleBackColor = true;
            this.cbGodMode.CheckedChanged += new System.EventHandler(this.cbGodMode_CheckedChanged);
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.lbSystemTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSystemTime.Location = new System.Drawing.Point(807, 48);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(94, 18);
            this.lbSystemTime.TabIndex = 14;
            this.lbSystemTime.Text = "SystemTime";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(415, 28);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 48);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清除所有排班";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NextWeekButton);
            this.panel3.Controls.Add(this.CurrentWeekButton);
            this.panel3.Controls.Add(this.PreviousWeekButton);
            this.panel3.Location = new System.Drawing.Point(8, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 72);
            this.panel3.TabIndex = 2;
            // 
            // NextWeekButton
            // 
            this.NextWeekButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextWeekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.NextWeekButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.NextWeekButton.IconColor = System.Drawing.Color.White;
            this.NextWeekButton.IconSize = 44;
            this.NextWeekButton.Location = new System.Drawing.Point(336, 14);
            this.NextWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextWeekButton.Name = "NextWeekButton";
            this.NextWeekButton.Size = new System.Drawing.Size(48, 44);
            this.NextWeekButton.TabIndex = 6;
            this.NextWeekButton.TabStop = false;
            this.NextWeekButton.Click += new System.EventHandler(this.NextWeekButton_Click);
            // 
            // CurrentWeekButton
            // 
            this.CurrentWeekButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CurrentWeekButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CurrentWeekButton.IconColor = System.Drawing.Color.Black;
            this.CurrentWeekButton.IconSize = 16;
            this.CurrentWeekButton.Location = new System.Drawing.Point(58, 14);
            this.CurrentWeekButton.Name = "CurrentWeekButton";
            this.CurrentWeekButton.Rotation = 0D;
            this.CurrentWeekButton.Size = new System.Drawing.Size(270, 44);
            this.CurrentWeekButton.TabIndex = 7;
            this.CurrentWeekButton.Text = "iconButton1";
            this.CurrentWeekButton.UseVisualStyleBackColor = true;
            // 
            // PreviousWeekButton
            // 
            this.PreviousWeekButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreviousWeekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.PreviousWeekButton.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.PreviousWeekButton.IconColor = System.Drawing.Color.White;
            this.PreviousWeekButton.IconSize = 44;
            this.PreviousWeekButton.Location = new System.Drawing.Point(4, 12);
            this.PreviousWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.PreviousWeekButton.Name = "PreviousWeekButton";
            this.PreviousWeekButton.Size = new System.Drawing.Size(48, 44);
            this.PreviousWeekButton.TabIndex = 5;
            this.PreviousWeekButton.TabStop = false;
            this.PreviousWeekButton.Click += new System.EventHandler(this.PreviousWeekButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Shift
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Shift";
            this.Size = new System.Drawing.Size(1540, 700);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Shift_GiveFeedback);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextWeekButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousWeekButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbGodMode;
        private System.Windows.Forms.Label lbSystemTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox NextWeekButton;
        private FontAwesome.Sharp.IconButton CurrentWeekButton;
        private FontAwesome.Sharp.IconPictureBox PreviousWeekButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Label label4;
    }
}
