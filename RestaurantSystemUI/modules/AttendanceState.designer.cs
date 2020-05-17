namespace RestaurantSystemUI
{
    partial class AttendanceState
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NextWeekButton = new FontAwesome.Sharp.IconPictureBox();
            this.CurrentWeekButton = new FontAwesome.Sharp.IconButton();
            this.PreviousWeekButton = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flatTextbox2 = new RestaurantSystemUI.FlatTextbox();
            this.flatTextbox1 = new RestaurantSystemUI.FlatTextbox();
            this.ftbName = new RestaurantSystemUI.FlatTextbox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextWeekButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousWeekButton)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 700);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(169, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 700);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(931, 511);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 189);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(73, 102);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 48);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NextWeekButton);
            this.panel3.Controls.Add(this.CurrentWeekButton);
            this.panel3.Controls.Add(this.PreviousWeekButton);
            this.panel3.Location = new System.Drawing.Point(7, 14);
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
            this.NextWeekButton.Location = new System.Drawing.Point(336, 13);
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
            this.CurrentWeekButton.Location = new System.Drawing.Point(59, 13);
            this.CurrentWeekButton.Name = "CurrentWeekButton";
            this.CurrentWeekButton.Rotation = 0D;
            this.CurrentWeekButton.Size = new System.Drawing.Size(270, 43);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.flatTextbox2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.flatTextbox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ftbName);
            this.panel4.Location = new System.Drawing.Point(406, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(691, 73);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "interval";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "end";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "start";
            // 
            // flatTextbox2
            // 
            this.flatTextbox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox2.Location = new System.Drawing.Point(518, 10);
            this.flatTextbox2.Margin = new System.Windows.Forms.Padding(6);
            this.flatTextbox2.Name = "flatTextbox2";
            this.flatTextbox2.PlaceHolder = "";
            this.flatTextbox2.Size = new System.Drawing.Size(84, 50);
            this.flatTextbox2.TabIndex = 9;
            // 
            // flatTextbox1
            // 
            this.flatTextbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox1.Location = new System.Drawing.Point(284, 10);
            this.flatTextbox1.Margin = new System.Windows.Forms.Padding(6);
            this.flatTextbox1.Name = "flatTextbox1";
            this.flatTextbox1.PlaceHolder = "";
            this.flatTextbox1.Size = new System.Drawing.Size(99, 50);
            this.flatTextbox1.TabIndex = 7;
            // 
            // ftbName
            // 
            this.ftbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbName.Location = new System.Drawing.Point(94, 10);
            this.ftbName.Margin = new System.Windows.Forms.Padding(6);
            this.ftbName.Name = "ftbName";
            this.ftbName.PlaceHolder = "";
            this.ftbName.Size = new System.Drawing.Size(99, 50);
            this.ftbName.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(286, 102);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 48);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清除所有排班";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AttendanceState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AttendanceState";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.AttendanceState_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextWeekButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousWeekButton)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox NextWeekButton;
        private FontAwesome.Sharp.IconPictureBox PreviousWeekButton;
        private FontAwesome.Sharp.IconButton CurrentWeekButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private FlatTextbox ftbName;
        private System.Windows.Forms.Label label2;
        private FlatTextbox flatTextbox1;
        private FlatTextbox flatTextbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}
