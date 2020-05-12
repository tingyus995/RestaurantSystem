namespace RestaurantSystemUI.modules
{
    partial class OrderViewFoodItem
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
            this.btnRemove = new RestaurantSystemUI.controls.ThemedIconButton();
            this.lbPrice = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbAmount = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbVarientName = new RestaurantSystemUI.controls.ThemedLabel();
            this.lbFoodName = new RestaurantSystemUI.controls.ThemedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconSize = 30;
            this.btnRemove.Location = new System.Drawing.Point(455, 0);
            this.btnRemove.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Rotation = 0D;
            this.btnRemove.Size = new System.Drawing.Size(58, 63);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(398, 13);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(51, 28);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "180";
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbAmount.ForeColor = System.Drawing.Color.White;
            this.lbAmount.Location = new System.Drawing.Point(338, 13);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(37, 28);
            this.lbAmount.TabIndex = 3;
            this.lbAmount.Text = "5x";
            // 
            // lbVarientName
            // 
            this.lbVarientName.AutoSize = true;
            this.lbVarientName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbVarientName.ForeColor = System.Drawing.Color.White;
            this.lbVarientName.Location = new System.Drawing.Point(197, 13);
            this.lbVarientName.Name = "lbVarientName";
            this.lbVarientName.Size = new System.Drawing.Size(102, 28);
            this.lbVarientName.TabIndex = 2;
            this.lbVarientName.Text = "{varient}";
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbFoodName.ForeColor = System.Drawing.Color.White;
            this.lbFoodName.Location = new System.Drawing.Point(69, 13);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(144, 28);
            this.lbFoodName.TabIndex = 1;
            this.lbFoodName.Text = "{food name}";
            // 
            // OrderPreviewFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbVarientName);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderPreviewFoodItem";
            this.Size = new System.Drawing.Size(513, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.ThemedLabel lbFoodName;
        private controls.ThemedLabel lbVarientName;
        private controls.ThemedLabel lbAmount;
        private controls.ThemedLabel lbPrice;
        private controls.ThemedIconButton btnRemove;
    }
}
