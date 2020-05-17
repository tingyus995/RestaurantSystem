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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::RestaurantSystemUI.Properties.Resources.DefaultEmployeeImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(216, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(110, 41);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbActualEnd
            // 
            this.lbActualEnd.AutoSize = true;
            this.lbActualEnd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbActualEnd.ForeColor = System.Drawing.Color.White;
            this.lbActualEnd.Location = new System.Drawing.Point(216, 149);
            this.lbActualEnd.Name = "lbActualEnd";
            this.lbActualEnd.Size = new System.Drawing.Size(210, 41);
            this.lbActualEnd.TabIndex = 2;
            this.lbActualEnd.Text = "尚未打下班卡";
            // 
            // lbActualStart
            // 
            this.lbActualStart.AutoSize = true;
            this.lbActualStart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbActualStart.ForeColor = System.Drawing.Color.White;
            this.lbActualStart.Location = new System.Drawing.Point(216, 82);
            this.lbActualStart.Name = "lbActualStart";
            this.lbActualStart.Size = new System.Drawing.Size(210, 41);
            this.lbActualStart.TabIndex = 1;
            this.lbActualStart.Text = "尚未打上班卡";
            // 
            // btnNext
            // 
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
            this.btnNext.Location = new System.Drawing.Point(332, 16);
            this.btnNext.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(180, 54);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "上班打卡";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbActualEnd);
            this.Controls.Add(this.lbActualStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(534, 204);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.ThemedLabel lbActualStart;
        private controls.ThemedLabel lbActualEnd;
        private controls.ThemedLabel lbName;
        private controls.ThemedIconButton btnNext;
    }
}
