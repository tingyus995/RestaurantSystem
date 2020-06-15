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
            this.fpnQueuingList = new System.Windows.Forms.FlowLayoutPanel();
            this.tmQueueScroll = new System.Windows.Forms.Timer(this.components);
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel3 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel4 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel5 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel6 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel2 = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbAnnouncement = new RestaurantSystemUI.controls.ThemedLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnQueuingMask = new System.Windows.Forms.Panel();
            this.pnAnnouncementWrapper.SuspendLayout();
            this.fpnQueuingList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnQueuingMask.SuspendLayout();
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
            // fpnQueuingList
            // 
            this.fpnQueuingList.AutoSize = true;
            this.fpnQueuingList.Controls.Add(this.themedLabel1);
            this.fpnQueuingList.Controls.Add(this.themedLabel3);
            this.fpnQueuingList.Controls.Add(this.themedLabel4);
            this.fpnQueuingList.Controls.Add(this.themedLabel5);
            this.fpnQueuingList.Controls.Add(this.themedLabel6);
            this.fpnQueuingList.Location = new System.Drawing.Point(3, 3);
            this.fpnQueuingList.Name = "fpnQueuingList";
            this.fpnQueuingList.Size = new System.Drawing.Size(850, 137);
            this.fpnQueuingList.TabIndex = 4;
            this.fpnQueuingList.WrapContents = false;
            // 
            // tmQueueScroll
            // 
            this.tmQueueScroll.Enabled = true;
            this.tmQueueScroll.Tick += new System.EventHandler(this.tmQueueScroll_Tick);
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themedLabel1.ForeColor = System.Drawing.Color.Red;
            this.themedLabel1.Location = new System.Drawing.Point(3, 0);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(164, 120);
            this.themedLabel1.TabIndex = 0;
            this.themedLabel1.Text = "18";
            // 
            // themedLabel3
            // 
            this.themedLabel3.AutoSize = true;
            this.themedLabel3.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themedLabel3.ForeColor = System.Drawing.Color.Red;
            this.themedLabel3.Location = new System.Drawing.Point(173, 0);
            this.themedLabel3.Name = "themedLabel3";
            this.themedLabel3.Size = new System.Drawing.Size(164, 120);
            this.themedLabel3.TabIndex = 1;
            this.themedLabel3.Text = "19";
            // 
            // themedLabel4
            // 
            this.themedLabel4.AutoSize = true;
            this.themedLabel4.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themedLabel4.ForeColor = System.Drawing.Color.Red;
            this.themedLabel4.Location = new System.Drawing.Point(343, 0);
            this.themedLabel4.Name = "themedLabel4";
            this.themedLabel4.Size = new System.Drawing.Size(164, 120);
            this.themedLabel4.TabIndex = 2;
            this.themedLabel4.Text = "20";
            // 
            // themedLabel5
            // 
            this.themedLabel5.AutoSize = true;
            this.themedLabel5.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themedLabel5.ForeColor = System.Drawing.Color.Red;
            this.themedLabel5.Location = new System.Drawing.Point(513, 0);
            this.themedLabel5.Name = "themedLabel5";
            this.themedLabel5.Size = new System.Drawing.Size(164, 120);
            this.themedLabel5.TabIndex = 3;
            this.themedLabel5.Text = "21";
            // 
            // themedLabel6
            // 
            this.themedLabel6.AutoSize = true;
            this.themedLabel6.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themedLabel6.ForeColor = System.Drawing.Color.Red;
            this.themedLabel6.Location = new System.Drawing.Point(683, 0);
            this.themedLabel6.Name = "themedLabel6";
            this.themedLabel6.Size = new System.Drawing.Size(164, 120);
            this.themedLabel6.TabIndex = 4;
            this.themedLabel6.Text = "22";
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(3, 0);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(131, 47);
            this.themedLabel2.TabIndex = 3;
            this.themedLabel2.Text = "排隊中";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnQueuingMask, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.themedLabel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 439);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pnQueuingMask
            // 
            this.pnQueuingMask.Controls.Add(this.fpnQueuingList);
            this.pnQueuingMask.Location = new System.Drawing.Point(3, 50);
            this.pnQueuingMask.Name = "pnQueuingMask";
            this.pnQueuingMask.Size = new System.Drawing.Size(287, 154);
            this.pnQueuingMask.TabIndex = 6;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnAnnouncementWrapper);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.pnAnnouncementWrapper.ResumeLayout(false);
            this.pnAnnouncementWrapper.PerformLayout();
            this.fpnQueuingList.ResumeLayout(false);
            this.fpnQueuingList.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnQueuingMask.ResumeLayout(false);
            this.pnQueuingMask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ThemedLabel themedLabel1;
        private controls.ThemedLabel lbAnnouncement;
        private System.Windows.Forms.Timer tmAnnouncementRoll;
        private System.Windows.Forms.Panel pnAnnouncementWrapper;
        private controls.ThemedLabel themedLabel2;
        private System.Windows.Forms.FlowLayoutPanel fpnQueuingList;
        private controls.ThemedLabel themedLabel3;
        private controls.ThemedLabel themedLabel4;
        private controls.ThemedLabel themedLabel5;
        private controls.ThemedLabel themedLabel6;
        private System.Windows.Forms.Timer tmQueueScroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnQueuingMask;
    }
}