namespace RestaurantSystemUI
{
    partial class OrderItem
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbWaitTime = new System.Windows.Forms.Label();
            this.tmWaitTimeUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantSystemUI.Properties.Resources._300;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFoodName.ForeColor = System.Drawing.Color.White;
            this.lbFoodName.Location = new System.Drawing.Point(160, 21);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(131, 26);
            this.lbFoodName.TabIndex = 1;
            this.lbFoodName.Text = "Food Name";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lbStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStatus.Location = new System.Drawing.Point(167, 56);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(5);
            this.lbStatus.Size = new System.Drawing.Size(64, 29);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "準備中";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(165, 97);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 36);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "通知完成";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // lbWaitTime
            // 
            this.lbWaitTime.AutoSize = true;
            this.lbWaitTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitTime.ForeColor = System.Drawing.Color.White;
            this.lbWaitTime.Location = new System.Drawing.Point(306, 114);
            this.lbWaitTime.Name = "lbWaitTime";
            this.lbWaitTime.Size = new System.Drawing.Size(99, 19);
            this.lbWaitTime.TabIndex = 4;
            this.lbWaitTime.Text = "已等候時間：";
            // 
            // tmWaitTimeUpdate
            // 
            this.tmWaitTimeUpdate.Enabled = true;
            this.tmWaitTimeUpdate.Interval = 1000;
            this.tmWaitTimeUpdate.Tick += new System.EventHandler(this.tmWaitTimeUpdate_Tick);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.lbWaitTime);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(492, 150);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbWaitTime;
        private System.Windows.Forms.Timer tmWaitTimeUpdate;
    }
}
