namespace RestaurantSystemUI.OOBE_pages
{
    partial class FinalInstructions
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
            this.btnStartSystem = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.themedLabel3 = new RestaurantSystemUI.controls.ThemedLabel();
            this.SuspendLayout();
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(29, 90);
            this.themedLabel2.MaximumSize = new System.Drawing.Size(600, 0);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(582, 70);
            this.themedLabel2.TabIndex = 9;
            this.themedLabel2.Text = "設定完成後請到食物管理新增食物，到人員管理新增員工！";
            this.themedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(202, 25);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(242, 47);
            this.themedLabel1.TabIndex = 8;
            this.themedLabel1.Text = "即將完成設定";
            // 
            // btnStartSystem
            // 
            this.btnStartSystem.AutoSize = true;
            this.btnStartSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartSystem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSystem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStartSystem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnStartSystem.ForeColor = System.Drawing.Color.White;
            this.btnStartSystem.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnStartSystem.IconColor = System.Drawing.Color.White;
            this.btnStartSystem.IconSize = 18;
            this.btnStartSystem.Location = new System.Drawing.Point(256, 294);
            this.btnStartSystem.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnStartSystem.Name = "btnStartSystem";
            this.btnStartSystem.Rotation = 0D;
            this.btnStartSystem.Size = new System.Drawing.Size(116, 36);
            this.btnStartSystem.TabIndex = 10;
            this.btnStartSystem.Text = "進入系統";
            this.btnStartSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartSystem.UseVisualStyleBackColor = true;
            this.btnStartSystem.Click += new System.EventHandler(this.btnStartSystem_Click);
            // 
            // themedLabel3
            // 
            this.themedLabel3.AutoSize = true;
            this.themedLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel3.ForeColor = System.Drawing.Color.White;
            this.themedLabel3.Location = new System.Drawing.Point(29, 188);
            this.themedLabel3.MaximumSize = new System.Drawing.Size(600, 0);
            this.themedLabel3.Name = "themedLabel3";
            this.themedLabel3.Size = new System.Drawing.Size(597, 70);
            this.themedLabel3.TabIndex = 11;
            this.themedLabel3.Text = "人員的職位增加 「clerk」，可以讓員工有排班的功能！";
            this.themedLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.themedLabel3);
            this.Controls.Add(this.btnStartSystem);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Name = "FinalInstructions";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ThemedLabel themedLabel2;
        private controls.ThemedLabel themedLabel1;
        private controls.ThemedIconTextButton btnStartSystem;
        private controls.ThemedLabel themedLabel3;
    }
}
