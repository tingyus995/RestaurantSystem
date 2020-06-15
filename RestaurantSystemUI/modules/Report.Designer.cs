namespace RestaurantSystemUI.modules
{
    partial class Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.btnHistory = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.btnMonth = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.themedLabel2 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnMonth);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 155);
            this.panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 18;
            this.btnSave.Location = new System.Drawing.Point(876, 46);
            this.btnSave.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(185, 48);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "儲存或列印";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistory.IconColor = System.Drawing.Color.White;
            this.btnHistory.IconSize = 18;
            this.btnHistory.Location = new System.Drawing.Point(657, 46);
            this.btnHistory.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Rotation = 0D;
            this.btnHistory.Size = new System.Drawing.Size(213, 48);
            this.btnHistory.TabIndex = 23;
            this.btnHistory.Text = "產生歷史報表";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.AutoSize = true;
            this.btnMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMonth.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnMonth.IconColor = System.Drawing.Color.White;
            this.btnMonth.IconSize = 18;
            this.btnMonth.Location = new System.Drawing.Point(438, 46);
            this.btnMonth.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Rotation = 0D;
            this.btnMonth.Size = new System.Drawing.Size(213, 48);
            this.btnMonth.TabIndex = 22;
            this.btnMonth.Text = "產生本月報表";
            this.btnMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.themedLabel2);
            this.panel2.Controls.Add(this.themedLabel1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(36, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 74);
            this.panel2.TabIndex = 17;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(346, 22);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(50, 41);
            this.themedLabel2.TabIndex = 17;
            this.themedLabel2.Text = "月";
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(141, 22);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(50, 41);
            this.themedLabel1.TabIndex = 5;
            this.themedLabel1.Text = "年";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(210, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 15;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1100, 545);
            this.webBrowser1.TabIndex = 5;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.webBrowser1);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 155);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1100, 545);
            this.pnContainer.TabIndex = 6;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private controls.ThemedLabel themedLabel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private controls.ThemedLabel themedLabel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel pnContainer;
        private controls.ThemedIconTextButton btnSave;
        private controls.ThemedIconTextButton btnHistory;
        private controls.ThemedIconTextButton btnMonth;
    }
}
