namespace RestaurantSystemUI
{
    partial class Status
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnShowDisplay = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(15, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 28);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnShowDisplay
            // 
            this.btnShowDisplay.AutoSize = true;
            this.btnShowDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowDisplay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDisplay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnShowDisplay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnShowDisplay.ForeColor = System.Drawing.Color.White;
            this.btnShowDisplay.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnShowDisplay.IconColor = System.Drawing.Color.White;
            this.btnShowDisplay.IconSize = 18;
            this.btnShowDisplay.Location = new System.Drawing.Point(15, 49);
            this.btnShowDisplay.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnShowDisplay.Name = "btnShowDisplay";
            this.btnShowDisplay.Rotation = 0D;
            this.btnShowDisplay.Size = new System.Drawing.Size(154, 36);
            this.btnShowDisplay.TabIndex = 1;
            this.btnShowDisplay.Text = "開啟第二螢幕";
            this.btnShowDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowDisplay.UseVisualStyleBackColor = true;
            this.btnShowDisplay.Click += new System.EventHandler(this.btnShowDisplay_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnShowDisplay);
            this.Controls.Add(this.checkBox1);
            this.Name = "Status";
            this.Size = new System.Drawing.Size(809, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private controls.ThemedIconTextButton btnShowDisplay;
    }
}
