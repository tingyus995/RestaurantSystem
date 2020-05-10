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
            this.fpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fpnLeftTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.orderPreview1 = new RestaurantSystemUI.modules.OrderView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpCategories
            // 
            this.fpCategories.AutoScroll = true;
            this.fpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCategories.Location = new System.Drawing.Point(3, 9);
            this.fpCategories.Name = "fpCategories";
            this.fpCategories.Size = new System.Drawing.Size(418, 549);
            this.fpCategories.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fpCategories, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fpnLeftTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderPreview1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 561);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // fpnLeftTitle
            // 
            this.fpnLeftTitle.AutoSize = true;
            this.fpnLeftTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnLeftTitle.Location = new System.Drawing.Point(3, 3);
            this.fpnLeftTitle.Name = "fpnLeftTitle";
            this.fpnLeftTitle.Size = new System.Drawing.Size(418, 1);
            this.fpnLeftTitle.TabIndex = 7;
            // 
            // orderPreview1
            // 
            this.orderPreview1.AutoSize = true;
            this.orderPreview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.orderPreview1.Location = new System.Drawing.Point(427, 9);
            this.orderPreview1.Name = "orderPreview1";
            this.orderPreview1.Size = new System.Drawing.Size(300, 115);
            this.orderPreview1.TabIndex = 8;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(849, 561);
            this.Load += new System.EventHandler(this.Order_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fpCategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel fpnLeftTitle;
        private modules.OrderView orderPreview1;
    }
}
