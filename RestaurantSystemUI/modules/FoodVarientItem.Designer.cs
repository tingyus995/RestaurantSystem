namespace RestaurantSystemUI.modules
{
    partial class FoodVarientItem
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
            this.lbVarientName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnPlus = new RestaurantSystemUI.controls.ThemedIconButton();
            this.SuspendLayout();
            // 
            // lbVarientName
            // 
            this.lbVarientName.AutoSize = true;
            this.lbVarientName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVarientName.ForeColor = System.Drawing.Color.White;
            this.lbVarientName.Location = new System.Drawing.Point(116, 13);
            this.lbVarientName.Name = "lbVarientName";
            this.lbVarientName.Size = new System.Drawing.Size(75, 26);
            this.lbVarientName.TabIndex = 2;
            this.lbVarientName.Text = "label1";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(237, 13);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(75, 26);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "label1";
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnPlus.IconColor = System.Drawing.Color.White;
            this.btnPlus.IconSize = 30;
            this.btnPlus.Location = new System.Drawing.Point(372, 0);
            this.btnPlus.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Rotation = 0D;
            this.btnPlus.Size = new System.Drawing.Size(45, 45);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // FoodVarientItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbVarientName);
            this.Name = "FoodVarientItem";
            this.Size = new System.Drawing.Size(417, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVarientName;
        private System.Windows.Forms.Label lbPrice;
        private controls.ThemedIconButton btnPlus;
    }
}
