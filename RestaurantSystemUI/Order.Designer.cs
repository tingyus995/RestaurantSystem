namespace RestaurantSystemUI
{
    partial class Order
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
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbFood
            // 
            this.cbFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(37, 79);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 21);
            this.cbFood.TabIndex = 0;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.cbFood);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(849, 561);
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFood;
    }
}
