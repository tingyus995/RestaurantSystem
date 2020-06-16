namespace RestaurantSystemUI
{
    partial class BatchFoodImportTool
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flatTextbox1 = new RestaurantSystemUI.FlatTextbox();
            this.btnBrowse = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.btnImport = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(506, 210);
            this.textBox1.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 290);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(505, 29);
            this.progressBar1.TabIndex = 12;
            // 
            // flatTextbox1
            // 
            this.flatTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox1.IsPassword = false;
            this.flatTextbox1.Location = new System.Drawing.Point(304, 12);
            this.flatTextbox1.Name = "flatTextbox1";
            this.flatTextbox1.PlaceHolder = "食物基本價錢";
            this.flatTextbox1.Size = new System.Drawing.Size(193, 46);
            this.flatTextbox1.TabIndex = 14;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnBrowse.IconColor = System.Drawing.Color.White;
            this.btnBrowse.IconSize = 18;
            this.btnBrowse.Location = new System.Drawing.Point(21, 22);
            this.btnBrowse.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Rotation = 0D;
            this.btnBrowse.Size = new System.Drawing.Size(135, 36);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "選擇資料夾";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnImport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnImport.IconColor = System.Drawing.Color.White;
            this.btnImport.IconSize = 18;
            this.btnImport.Location = new System.Drawing.Point(220, 324);
            this.btnImport.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnImport.Name = "btnImport";
            this.btnImport.Rotation = 0D;
            this.btnImport.Size = new System.Drawing.Size(78, 36);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "匯入";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BatchFoodImportTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(537, 367);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.flatTextbox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BatchFoodImportTool";
            this.Text = "FoodBatchImportTool";
            this.Load += new System.EventHandler(this.BatchFoodImportTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private FlatTextbox flatTextbox1;
        private controls.ThemedIconTextButton btnBrowse;
        private controls.ThemedIconTextButton btnImport;
    }
}