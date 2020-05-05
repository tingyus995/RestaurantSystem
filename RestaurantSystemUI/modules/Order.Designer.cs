﻿namespace RestaurantSystemUI
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flatTextbox1 = new RestaurantSystemUI.FlatTextbox();
            this.col1 = new System.Windows.Forms.Panel();
            this.col1_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fpCategories = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.col1.SuspendLayout();
            this.col1_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFood
            // 
            this.cbFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(681, 77);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 21);
            this.cbFood.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(623, 185);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // flatTextbox1
            // 
            this.flatTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox1.Location = new System.Drawing.Point(348, 234);
            this.flatTextbox1.Name = "flatTextbox1";
            this.flatTextbox1.PlaceHolder = "店家名稱";
            this.flatTextbox1.Size = new System.Drawing.Size(406, 35);
            this.flatTextbox1.TabIndex = 3;
            this.flatTextbox1.Theme = null;
            // 
            // col1
            // 
            this.col1.Controls.Add(this.fpCategories);
            this.col1.Controls.Add(this.col1_header);
            this.col1.Dock = System.Windows.Forms.DockStyle.Left;
            this.col1.Location = new System.Drawing.Point(0, 0);
            this.col1.Name = "col1";
            this.col1.Size = new System.Drawing.Size(327, 561);
            this.col1.TabIndex = 4;
            // 
            // col1_header
            // 
            this.col1_header.Controls.Add(this.label1);
            this.col1_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.col1_header.Location = new System.Drawing.Point(0, 0);
            this.col1_header.Name = "col1_header";
            this.col1_header.Size = new System.Drawing.Size(327, 63);
            this.col1_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "餐點分類";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpCategories
            // 
            this.fpCategories.AutoScroll = true;
            this.fpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCategories.Location = new System.Drawing.Point(0, 63);
            this.fpCategories.Name = "fpCategories";
            this.fpCategories.Size = new System.Drawing.Size(327, 498);
            this.fpCategories.TabIndex = 2;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.col1);
            this.Controls.Add(this.flatTextbox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbFood);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(849, 561);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.col1.ResumeLayout(false);
            this.col1_header.ResumeLayout(false);
            this.col1_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FlatTextbox flatTextbox1;
        private System.Windows.Forms.Panel col1;
        private System.Windows.Forms.FlowLayoutPanel fpCategories;
        private System.Windows.Forms.Panel col1_header;
        private System.Windows.Forms.Label label1;
    }
}
