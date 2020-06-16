namespace RestaurantSystemUI
{
    partial class Status
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
            this.btnShowDisplay = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.ftbAnnouncement = new RestaurantSystemUI.FlatTextbox();
            this.btnSetText = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.SuspendLayout();
            // 
            // btnShowDisplay
            // 
            this.btnShowDisplay.AutoSize = true;
            this.btnShowDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowDisplay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDisplay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnShowDisplay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnShowDisplay.ForeColor = System.Drawing.Color.White;
            this.btnShowDisplay.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnShowDisplay.IconColor = System.Drawing.Color.White;
            this.btnShowDisplay.IconSize = 18;
            this.btnShowDisplay.Location = new System.Drawing.Point(15, 84);
            this.btnShowDisplay.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnShowDisplay.Name = "btnShowDisplay";
            this.btnShowDisplay.Rotation = 0D;
            this.btnShowDisplay.Size = new System.Drawing.Size(154, 36);
            this.btnShowDisplay.TabIndex = 1;
            this.btnShowDisplay.Text = "開啟第二螢幕";
            this.btnShowDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowDisplay.UseVisualStyleBackColor = true;
            this.btnShowDisplay.Click += new System.EventHandler(this.btnShowDisplay_Click);
            // 
            // ftbAnnouncement
            // 
            this.ftbAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbAnnouncement.IsPassword = false;
            this.ftbAnnouncement.Location = new System.Drawing.Point(15, 22);
            this.ftbAnnouncement.Name = "ftbAnnouncement";
            this.ftbAnnouncement.PlaceHolder = "跑馬燈文字";
            this.ftbAnnouncement.Size = new System.Drawing.Size(669, 45);
            this.ftbAnnouncement.TabIndex = 2;
            // 
            // btnSetText
            // 
            this.btnSetText.AutoSize = true;
            this.btnSetText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetText.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetText.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSetText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSetText.ForeColor = System.Drawing.Color.White;
            this.btnSetText.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnSetText.IconColor = System.Drawing.Color.White;
            this.btnSetText.IconSize = 18;
            this.btnSetText.Location = new System.Drawing.Point(690, 31);
            this.btnSetText.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Rotation = 0D;
            this.btnSetText.Size = new System.Drawing.Size(116, 36);
            this.btnSetText.TabIndex = 3;
            this.btnSetText.Text = "設定文字";
            this.btnSetText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetText.UseVisualStyleBackColor = true;
            this.btnSetText.Click += new System.EventHandler(this.btnSetText_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnSetText);
            this.Controls.Add(this.ftbAnnouncement);
            this.Controls.Add(this.btnShowDisplay);
            this.Name = "Status";
            this.Size = new System.Drawing.Size(809, 540);
            this.Load += new System.EventHandler(this.Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controls.ThemedIconTextButton btnShowDisplay;
        private FlatTextbox ftbAnnouncement;
        private controls.ThemedIconTextButton btnSetText;
    }
}
