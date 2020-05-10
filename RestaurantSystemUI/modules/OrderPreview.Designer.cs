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
            this.pnTopHalf = new System.Windows.Forms.Panel();
            this.pnBottomBar = new System.Windows.Forms.Panel();
            this.fpnFoodItems = new System.Windows.Forms.FlowLayoutPanel();
            this.themedIconButton1 = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.lbTotal = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.pnTopHalf.SuspendLayout();
            this.pnBottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopHalf
            // 
            this.pnTopHalf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.pnTopHalf.Controls.Add(this.themedLabel1);
            this.pnTopHalf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopHalf.Location = new System.Drawing.Point(0, 0);
            this.pnTopHalf.Name = "pnTopHalf";
            this.pnTopHalf.Size = new System.Drawing.Size(513, 43);
            this.pnTopHalf.TabIndex = 2;
            // 
            // pnBottomBar
            // 
            this.pnBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnBottomBar.Controls.Add(this.themedIconButton1);
            this.pnBottomBar.Controls.Add(this.lbTotal);
            this.pnBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottomBar.Location = new System.Drawing.Point(0, 79);
            this.pnBottomBar.Name = "pnBottomBar";
            this.pnBottomBar.Size = new System.Drawing.Size(513, 52);
            this.pnBottomBar.TabIndex = 3;
            // 
            // fpnFoodItems
            // 
            this.fpnFoodItems.AutoSize = true;
            this.fpnFoodItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnFoodItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnFoodItems.Location = new System.Drawing.Point(0, 43);
            this.fpnFoodItems.MinimumSize = new System.Drawing.Size(300, 20);
            this.fpnFoodItems.Name = "fpnFoodItems";
            this.fpnFoodItems.Size = new System.Drawing.Size(513, 36);
            this.fpnFoodItems.TabIndex = 4;
            // 
            // themedIconButton1
            // 
            this.themedIconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.themedIconButton1.AutoSize = true;
            this.themedIconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.themedIconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.themedIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themedIconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.themedIconButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.themedIconButton1.ForeColor = System.Drawing.Color.White;
            this.themedIconButton1.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.themedIconButton1.IconColor = System.Drawing.Color.White;
            this.themedIconButton1.IconSize = 18;
            this.themedIconButton1.Location = new System.Drawing.Point(11, 8);
            this.themedIconButton1.MinimumSize = new System.Drawing.Size(10, 10);
            this.themedIconButton1.Name = "themedIconButton1";
            this.themedIconButton1.Rotation = 0D;
            this.themedIconButton1.Size = new System.Drawing.Size(80, 36);
            this.themedIconButton1.TabIndex = 0;
            this.themedIconButton1.Text = "next";
            this.themedIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.themedIconButton1.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(343, 12);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(158, 28);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "共 {money} 元";
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(12, 9);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(39, 28);
            this.themedLabel1.TabIndex = 0;
            this.themedLabel1.Text = "#1";
            // 
            // OrderPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.fpnFoodItems);
            this.Controls.Add(this.pnBottomBar);
            this.Controls.Add(this.pnTopHalf);
            this.Name = "OrderPreview";
            this.Size = new System.Drawing.Size(513, 131);
            this.pnTopHalf.ResumeLayout(false);
            this.pnTopHalf.PerformLayout();
            this.pnBottomBar.ResumeLayout(false);
            this.pnBottomBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ThemedLabel themedLabel1;
        private controls.ThemedIconTextButton themedIconButton1;
        private controls.ThemedLabel lbTotal;
        private System.Windows.Forms.Panel pnTopHalf;
        private System.Windows.Forms.Panel pnBottomBar;
        private System.Windows.Forms.FlowLayoutPanel fpnFoodItems;
    }
}
