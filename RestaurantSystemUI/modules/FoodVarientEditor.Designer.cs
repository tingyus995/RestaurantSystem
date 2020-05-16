namespace RestaurantSystemUI.modules
{
    partial class FoodVarientEditor
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
            this.ftbName = new RestaurantSystemUI.FlatTextbox();
            this.ftbDelta = new RestaurantSystemUI.FlatTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ftbName
            // 
            this.ftbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbName.Location = new System.Drawing.Point(56, 2);
            this.ftbName.Name = "ftbName";
            this.ftbName.PlaceHolder = "例如：大杯";
            this.ftbName.Size = new System.Drawing.Size(173, 45);
            this.ftbName.TabIndex = 12;            
            // 
            // ftbDelta
            // 
            this.ftbDelta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbDelta.Location = new System.Drawing.Point(235, 2);
            this.ftbDelta.Name = "ftbDelta";
            this.ftbDelta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ftbDelta.PlaceHolder = "例如：+35";
            this.ftbDelta.Size = new System.Drawing.Size(140, 45);
            this.ftbDelta.TabIndex = 13;
            
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FoodVarient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ftbDelta);
            this.Controls.Add(this.ftbName);
            this.Name = "FoodVarient";
            this.Size = new System.Drawing.Size(388, 50);
            this.Load += new System.EventHandler(this.FoodVarient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public FlatTextbox ftbName;
        public FlatTextbox ftbDelta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
