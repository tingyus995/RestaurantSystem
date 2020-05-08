namespace RestaurantSystemUI
{
    partial class FlatNumericUpDown
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
            this.ibtnPlus = new FontAwesome.Sharp.IconButton();
            this.ibtnMinus = new FontAwesome.Sharp.IconButton();
            this.lbNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ibtnPlus
            // 
            this.ibtnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ibtnPlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnPlus.FlatAppearance.BorderSize = 0;
            this.ibtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPlus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnPlus.IconColor = System.Drawing.Color.White;
            this.ibtnPlus.IconSize = 20;
            this.ibtnPlus.Location = new System.Drawing.Point(157, 0);
            this.ibtnPlus.Name = "ibtnPlus";
            this.ibtnPlus.Rotation = 0D;
            this.ibtnPlus.Size = new System.Drawing.Size(60, 60);
            this.ibtnPlus.TabIndex = 0;
            this.ibtnPlus.UseVisualStyleBackColor = false;
            this.ibtnPlus.Click += new System.EventHandler(this.ibtnPlus_Click);
            // 
            // ibtnMinus
            // 
            this.ibtnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ibtnMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtnMinus.FlatAppearance.BorderSize = 0;
            this.ibtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMinus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ibtnMinus.IconColor = System.Drawing.Color.White;
            this.ibtnMinus.IconSize = 20;
            this.ibtnMinus.Location = new System.Drawing.Point(0, 0);
            this.ibtnMinus.Name = "ibtnMinus";
            this.ibtnMinus.Rotation = 0D;
            this.ibtnMinus.Size = new System.Drawing.Size(60, 60);
            this.ibtnMinus.TabIndex = 1;
            this.ibtnMinus.UseVisualStyleBackColor = false;
            this.ibtnMinus.Click += new System.EventHandler(this.ibtnMinus_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.Color.White;
            this.lbNumber.Location = new System.Drawing.Point(84, 19);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(55, 20);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Text = "label1";
            // 
            // FlatNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.ibtnMinus);
            this.Controls.Add(this.ibtnPlus);
            this.Name = "FlatNumericUpDown";
            this.Size = new System.Drawing.Size(217, 60);
            this.Load += new System.EventHandler(this.FlatNumericUpDown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnPlus;
        private FontAwesome.Sharp.IconButton ibtnMinus;
        private System.Windows.Forms.Label lbNumber;
    }
}
