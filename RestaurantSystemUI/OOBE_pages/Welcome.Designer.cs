namespace RestaurantSystemUI.OOBE_pages
{
    partial class Welcome
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
            this.themedLabel2 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.SuspendLayout();
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(25, 97);
            this.themedLabel2.MaximumSize = new System.Drawing.Size(600, 0);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(582, 70);
            this.themedLabel2.TabIndex = 3;
            this.themedLabel2.Text = "在開始使用系統前，讓我們快速地介紹系統的功能吧！";
            this.themedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(177, 34);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(279, 47);
            this.themedLabel1.TabIndex = 2;
            this.themedLabel1.Text = "歡迎使用本系統";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ThemedLabel themedLabel2;
        private controls.ThemedLabel themedLabel1;
    }
}
