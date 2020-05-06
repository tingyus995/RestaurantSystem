namespace RestaurantSystemUI
{
    partial class FlatTextbox
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
            this.pnUnderline = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lbPlaceholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnUnderline
            // 
            this.pnUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUnderline.BackColor = System.Drawing.Color.White;
            this.pnUnderline.Location = new System.Drawing.Point(0, 41);
            this.pnUnderline.Name = "pnUnderline";
            this.pnUnderline.Size = new System.Drawing.Size(313, 3);
            this.pnUnderline.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(0, 9);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(313, 27);
            this.textBox.TabIndex = 4;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbPlaceholder
            // 
            this.lbPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPlaceholder.AutoSize = true;
            this.lbPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lbPlaceholder.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPlaceholder.ForeColor = System.Drawing.Color.LightGray;
            this.lbPlaceholder.Location = new System.Drawing.Point(9, 10);
            this.lbPlaceholder.Margin = new System.Windows.Forms.Padding(0);
            this.lbPlaceholder.Name = "lbPlaceholder";
            this.lbPlaceholder.Size = new System.Drawing.Size(134, 26);
            this.lbPlaceholder.TabIndex = 5;
            this.lbPlaceholder.Text = "placeholder";
            // 
            // FlatTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lbPlaceholder);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pnUnderline);
            this.Name = "FlatTextbox";
            this.Size = new System.Drawing.Size(313, 45);
            this.Load += new System.EventHandler(this.FlatTextbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnUnderline;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lbPlaceholder;
    }
}
