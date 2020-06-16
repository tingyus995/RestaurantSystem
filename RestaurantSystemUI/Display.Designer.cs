namespace RestaurantSystemUI
{
    partial class Display
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
            this.components = new System.ComponentModel.Container();
            this.tmAnnouncementRoll = new System.Windows.Forms.Timer(this.components);
            this.pnAnnouncementWrapper = new System.Windows.Forms.Panel();
            this.lbAnnouncement = new RestaurantSystemUI.controls.ThemedLabel();
            this.pbOrderPreview = new System.Windows.Forms.PictureBox();
            this.tmShowReadyNum = new System.Windows.Forms.Timer(this.components);
            this.lbReadyNo = new RestaurantSystemUI.controls.ThemedLabel();
            this.pnAnnouncementWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tmAnnouncementRoll
            // 
            this.tmAnnouncementRoll.Enabled = true;
            this.tmAnnouncementRoll.Interval = 30;
            this.tmAnnouncementRoll.Tick += new System.EventHandler(this.tmAnnouncementRoll_Tick);
            // 
            // pnAnnouncementWrapper
            // 
            this.pnAnnouncementWrapper.Controls.Add(this.lbAnnouncement);
            this.pnAnnouncementWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAnnouncementWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnAnnouncementWrapper.Name = "pnAnnouncementWrapper";
            this.pnAnnouncementWrapper.Size = new System.Drawing.Size(1264, 123);
            this.pnAnnouncementWrapper.TabIndex = 2;
            // 
            // lbAnnouncement
            // 
            this.lbAnnouncement.AutoSize = true;
            this.lbAnnouncement.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnouncement.ForeColor = System.Drawing.Color.White;
            this.lbAnnouncement.Location = new System.Drawing.Point(12, 9);
            this.lbAnnouncement.Name = "lbAnnouncement";
            this.lbAnnouncement.Size = new System.Drawing.Size(2642, 120);
            this.lbAnnouncement.TabIndex = 1;
            this.lbAnnouncement.Text = "這裡是給你放一些宣傳用的標語的，字很多沒關係，他會跑。";
            // 
            // pbOrderPreview
            // 
            this.pbOrderPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOrderPreview.Location = new System.Drawing.Point(617, 120);
            this.pbOrderPreview.Name = "pbOrderPreview";
            this.pbOrderPreview.Size = new System.Drawing.Size(635, 549);
            this.pbOrderPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOrderPreview.TabIndex = 6;
            this.pbOrderPreview.TabStop = false;
            // 
            // tmShowReadyNum
            // 
            this.tmShowReadyNum.Enabled = true;
            this.tmShowReadyNum.Interval = 1000;
            this.tmShowReadyNum.Tick += new System.EventHandler(this.tmShowReadyNum_Tick);
            // 
            // lbReadyNo
            // 
            this.lbReadyNo.AutoSize = true;
            this.lbReadyNo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 250F, System.Drawing.FontStyle.Bold);
            this.lbReadyNo.ForeColor = System.Drawing.Color.White;
            this.lbReadyNo.Location = new System.Drawing.Point(2, 211);
            this.lbReadyNo.Name = "lbReadyNo";
            this.lbReadyNo.Size = new System.Drawing.Size(376, 424);
            this.lbReadyNo.TabIndex = 7;
            this.lbReadyNo.Text = "0";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbReadyNo);
            this.Controls.Add(this.pbOrderPreview);
            this.Controls.Add(this.pnAnnouncementWrapper);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.pnAnnouncementWrapper.ResumeLayout(false);
            this.pnAnnouncementWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmAnnouncementRoll;
        private System.Windows.Forms.Panel pnAnnouncementWrapper;
        private System.Windows.Forms.Timer tmShowReadyNum;
        internal System.Windows.Forms.PictureBox pbOrderPreview;
        private controls.ThemedLabel lbReadyNo;
        internal controls.ThemedLabel lbAnnouncement;
    }
}