namespace RestaurantSystemUI.modules
{
    partial class FoodList
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
            this.fpnCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnFoodItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fpnCategories
            // 
            this.fpnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.fpnCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpnCategories.Location = new System.Drawing.Point(0, 0);
            this.fpnCategories.Name = "fpnCategories";
            this.fpnCategories.Size = new System.Drawing.Size(219, 495);
            this.fpnCategories.TabIndex = 0;
            // 
            // fpnFoodItems
            // 
            this.fpnFoodItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnFoodItems.Location = new System.Drawing.Point(219, 0);
            this.fpnFoodItems.Name = "fpnFoodItems";
            this.fpnFoodItems.Size = new System.Drawing.Size(630, 495);
            this.fpnFoodItems.TabIndex = 1;
            // 
            // FoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.fpnFoodItems);
            this.Controls.Add(this.fpnCategories);
            this.Name = "FoodList";
            this.Size = new System.Drawing.Size(849, 495);
            this.Load += new System.EventHandler(this.FoodList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnCategories;
        private System.Windows.Forms.FlowLayoutPanel fpnFoodItems;
    }
}
