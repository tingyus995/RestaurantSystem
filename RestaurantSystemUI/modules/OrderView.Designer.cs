namespace RestaurantSystemUI.modules
{
    partial class OrderView
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
            this.pnTopHalf = new System.Windows.Forms.Panel();
            this.pnCreatedOrderInfo = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnBottomBar = new System.Windows.Forms.Panel();
            this.tmUpdateWaitTime = new System.Windows.Forms.Timer(this.components);
            this.tlpFoodItems = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.lbTotal = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbWaitTime = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbOrderNumber = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.pnTopHalf.SuspendLayout();
            this.pnCreatedOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnBottomBar.SuspendLayout();
            this.tlpFoodItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopHalf
            // 
            this.pnTopHalf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.pnTopHalf.Controls.Add(this.pnCreatedOrderInfo);
            this.pnTopHalf.Controls.Add(this.lbOrderNumber);
            this.pnTopHalf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopHalf.Location = new System.Drawing.Point(0, 0);
            this.pnTopHalf.Name = "pnTopHalf";
            this.pnTopHalf.Size = new System.Drawing.Size(513, 43);
            this.pnTopHalf.TabIndex = 2;
            // 
            // pnCreatedOrderInfo
            // 
            this.pnCreatedOrderInfo.Controls.Add(this.lbStatus);
            this.pnCreatedOrderInfo.Controls.Add(this.lbWaitTime);
            this.pnCreatedOrderInfo.Controls.Add(this.iconPictureBox1);
            this.pnCreatedOrderInfo.Location = new System.Drawing.Point(104, 3);
            this.pnCreatedOrderInfo.Name = "pnCreatedOrderInfo";
            this.pnCreatedOrderInfo.Size = new System.Drawing.Size(392, 40);
            this.pnCreatedOrderInfo.TabIndex = 7;
            this.pnCreatedOrderInfo.Visible = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lbStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStatus.Location = new System.Drawing.Point(18, 4);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(5);
            this.lbStatus.Size = new System.Drawing.Size(64, 29);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "準備中";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(129, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // pnBottomBar
            // 
            this.pnBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnBottomBar.Controls.Add(this.btnNext);
            this.pnBottomBar.Controls.Add(this.lbTotal);
            this.pnBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottomBar.Location = new System.Drawing.Point(0, 237);
            this.pnBottomBar.Name = "pnBottomBar";
            this.pnBottomBar.Size = new System.Drawing.Size(513, 52);
            this.pnBottomBar.TabIndex = 3;
            // 
            // tmUpdateWaitTime
            // 
            this.tmUpdateWaitTime.Interval = 1000;
            this.tmUpdateWaitTime.Tick += new System.EventHandler(this.tmUpdateWaitTime_Tick);
            // 
            // tlpFoodItems
            // 
            this.tlpFoodItems.AutoSize = true;
            this.tlpFoodItems.ColumnCount = 1;
            this.tlpFoodItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFoodItems.Controls.Add(this.themedLabel1, 0, 0);
            this.tlpFoodItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFoodItems.Location = new System.Drawing.Point(0, 43);
            this.tlpFoodItems.Name = "tlpFoodItems";
            this.tlpFoodItems.RowCount = 1;
            this.tlpFoodItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFoodItems.Size = new System.Drawing.Size(513, 194);
            this.tlpFoodItems.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconSize = 18;
            this.btnNext.Location = new System.Drawing.Point(11, 8);
            this.btnNext.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(80, 36);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(343, 12);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(81, 28);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "共 0 元";
            // 
            // lbWaitTime
            // 
            this.lbWaitTime.AutoSize = true;
            this.lbWaitTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbWaitTime.ForeColor = System.Drawing.Color.White;
            this.lbWaitTime.Location = new System.Drawing.Point(167, 4);
            this.lbWaitTime.Name = "lbWaitTime";
            this.lbWaitTime.Size = new System.Drawing.Size(126, 28);
            this.lbWaitTime.TabIndex = 1;
            this.lbWaitTime.Text = "{wait time}";
            // 
            // lbOrderNumber
            // 
            this.lbOrderNumber.AutoSize = true;
            this.lbOrderNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbOrderNumber.ForeColor = System.Drawing.Color.White;
            this.lbOrderNumber.Location = new System.Drawing.Point(12, 9);
            this.lbOrderNumber.Name = "lbOrderNumber";
            this.lbOrderNumber.Size = new System.Drawing.Size(74, 28);
            this.lbOrderNumber.TabIndex = 0;
            this.lbOrderNumber.Text = "#{No}";
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(10, 10);
            this.themedLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(493, 174);
            this.themedLabel1.TabIndex = 0;
            this.themedLabel1.Text = "訂單內沒有食物喔";
            this.themedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.tlpFoodItems);
            this.Controls.Add(this.pnBottomBar);
            this.Controls.Add(this.pnTopHalf);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(513, 289);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.pnTopHalf.ResumeLayout(false);
            this.pnTopHalf.PerformLayout();
            this.pnCreatedOrderInfo.ResumeLayout(false);
            this.pnCreatedOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnBottomBar.ResumeLayout(false);
            this.pnBottomBar.PerformLayout();
            this.tlpFoodItems.ResumeLayout(false);
            this.tlpFoodItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ThemedLabel lbOrderNumber;
        private controls.ThemedIconTextButton btnNext;
        private controls.ThemedLabel lbTotal;
        private System.Windows.Forms.Panel pnTopHalf;
        private System.Windows.Forms.Panel pnBottomBar;
        private controls.ThemedLabel lbWaitTime;
        private System.Windows.Forms.Timer tmUpdateWaitTime;
        private System.Windows.Forms.Label lbStatus;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel pnCreatedOrderInfo;
        private System.Windows.Forms.TableLayoutPanel tlpFoodItems;
        private controls.ThemedLabel themedLabel1;
    }
}
