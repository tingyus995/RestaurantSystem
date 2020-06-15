namespace RestaurantSystemUI.modules
{
    partial class LockScreen
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
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.btnUnlock = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.SuspendLayout();
            // 
            // flatTextbox1
            // 
            this.flatTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox1.IsPassword = true;
            this.flatTextbox1.Location = new System.Drawing.Point(262, 243);
            this.flatTextbox1.Name = "flatTextbox1";
            this.flatTextbox1.PlaceHolder = "請輸入管理員密碼";
            this.flatTextbox1.Size = new System.Drawing.Size(313, 45);
            this.flatTextbox1.TabIndex = 0;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(257, 188);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(232, 28);
            this.themedLabel1.TabIndex = 1;
            this.themedLabel1.Text = "該功能需要管理員權限";
            // 
            // btnUnlock
            // 
            this.btnUnlock.AutoSize = true;
            this.btnUnlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUnlock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnUnlock.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.btnUnlock.IconColor = System.Drawing.Color.White;
            this.btnUnlock.IconSize = 18;
            this.btnUnlock.Location = new System.Drawing.Point(262, 307);
            this.btnUnlock.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Rotation = 0D;
            this.btnUnlock.Size = new System.Drawing.Size(78, 36);
            this.btnUnlock.TabIndex = 2;
            this.btnUnlock.Text = "解鎖";
            this.btnUnlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // LockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.flatTextbox1);
            this.Name = "LockScreen";
            this.Size = new System.Drawing.Size(870, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatTextbox flatTextbox1;
        private controls.ThemedLabel themedLabel1;
        private controls.ThemedIconTextButton btnUnlock;
    }
}
