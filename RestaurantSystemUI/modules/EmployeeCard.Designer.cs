namespace RestaurantSystemUI.modules
{
    partial class EmployeeCard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbActualEnd = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbActualStart = new RestaurantSystemUI.controls.ThemedLabel();
            this.btnNext = new RestaurantSystemUI.controls.ThemedIconButton();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::RestaurantSystemUI.Properties.Resources.DefaultEmployeeImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(137, 17);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 28);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbActualEnd
            // 
            this.lbActualEnd.AutoSize = true;
            this.lbActualEnd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbActualEnd.ForeColor = System.Drawing.Color.White;
            this.lbActualEnd.Location = new System.Drawing.Point(189, 105);
            this.lbActualEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActualEnd.Name = "lbActualEnd";
            this.lbActualEnd.Size = new System.Drawing.Size(144, 28);
            this.lbActualEnd.TabIndex = 2;
            this.lbActualEnd.Text = "尚未打下班卡";
            // 
            // lbActualStart
            // 
            this.lbActualStart.AutoSize = true;
            this.lbActualStart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbActualStart.ForeColor = System.Drawing.Color.White;
            this.lbActualStart.Location = new System.Drawing.Point(189, 59);
            this.lbActualStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActualStart.Name = "lbActualStart";
            this.lbActualStart.Size = new System.Drawing.Size(144, 28);
            this.lbActualStart.TabIndex = 1;
            this.lbActualStart.Text = "尚未打上班卡";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconSize = 30;
            this.btnNext.Location = new System.Drawing.Point(329, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.MinimumSize = new System.Drawing.Size(7, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(129, 39);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "上班打卡";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconPictureBox5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.iconPictureBox5.IconColor = System.Drawing.Color.White;
            this.iconPictureBox5.Location = new System.Drawing.Point(152, 59);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox5.TabIndex = 13;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconPictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(152, 105);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbActualEnd);
            this.Controls.Add(this.lbActualStart);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(468, 147);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.ThemedLabel lbActualStart;
        private controls.ThemedLabel lbActualEnd;
        private controls.ThemedLabel lbName;
        private controls.ThemedIconButton btnNext;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
