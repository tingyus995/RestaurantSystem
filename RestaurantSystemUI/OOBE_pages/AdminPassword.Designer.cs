namespace RestaurantSystemUI.OOBE_pages
{
    partial class AdminPassword
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
            this.flatTextbox1 = new RestaurantSystemUI.FlatTextbox();
            this.themedLabel2 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.flatTextbox2 = new RestaurantSystemUI.FlatTextbox();
            this.SuspendLayout();
            // 
            // flatTextbox1
            // 
            this.flatTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox1.IsPassword = true;
            this.flatTextbox1.Location = new System.Drawing.Point(123, 157);
            this.flatTextbox1.Name = "flatTextbox1";
            this.flatTextbox1.PlaceHolder = "請輸入密碼";
            this.flatTextbox1.Size = new System.Drawing.Size(313, 45);
            this.flatTextbox1.TabIndex = 8;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(170, 91);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(204, 35);
            this.themedLabel2.TabIndex = 7;
            this.themedLabel2.Text = "設定管理員密碼";
            this.themedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(168, 21);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(205, 47);
            this.themedLabel1.TabIndex = 6;
            this.themedLabel1.Text = "管理員密碼";
            // 
            // flatTextbox2
            // 
            this.flatTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox2.IsPassword = true;
            this.flatTextbox2.Location = new System.Drawing.Point(123, 208);
            this.flatTextbox2.Name = "flatTextbox2";
            this.flatTextbox2.PlaceHolder = "請輸入確認密碼";
            this.flatTextbox2.Size = new System.Drawing.Size(313, 45);
            this.flatTextbox2.TabIndex = 9;
            // 
            // AdminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.flatTextbox2);
            this.Controls.Add(this.flatTextbox1);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Name = "AdminPassword";
            this.Size = new System.Drawing.Size(556, 469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatTextbox flatTextbox1;
        private controls.ThemedLabel themedLabel2;
        private controls.ThemedLabel themedLabel1;
        private FlatTextbox flatTextbox2;
    }
}
