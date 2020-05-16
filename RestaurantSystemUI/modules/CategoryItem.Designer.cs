﻿namespace RestaurantSystemUI
{
    partial class CategoryItem
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
            this.pnDecoration = new System.Windows.Forms.Panel();
            this.ibtnEdit = new FontAwesome.Sharp.IconButton();
            this.lbCatName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnDecoration
            // 
            this.pnDecoration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(93)))), ((int)(((byte)(119)))));
            this.pnDecoration.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDecoration.Location = new System.Drawing.Point(0, 0);
            this.pnDecoration.Name = "pnDecoration";
            this.pnDecoration.Size = new System.Drawing.Size(10, 61);
            this.pnDecoration.TabIndex = 1;
            this.pnDecoration.Click += new System.EventHandler(this.pnDecoration_Click);
            // 
            // ibtnEdit
            // 
            this.ibtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));            
            this.ibtnEdit.FlatAppearance.BorderSize = 0;
            this.ibtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ibtnEdit.IconColor = System.Drawing.Color.White;
            this.ibtnEdit.IconSize = 16;
            this.ibtnEdit.Location = new System.Drawing.Point(113, 0);
            this.ibtnEdit.Name = "ibtnEdit";
            this.ibtnEdit.Rotation = 0D;
            this.ibtnEdit.Size = new System.Drawing.Size(33, 31);
            this.ibtnEdit.TabIndex = 2;
            this.ibtnEdit.UseVisualStyleBackColor = false;
            this.ibtnEdit.Click += new System.EventHandler(this.ibtnEdit_Click);
            // 
            // lbCatName
            // 
            this.lbCatName.AutoSize = true;
            this.lbCatName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCatName.ForeColor = System.Drawing.Color.White;
            this.lbCatName.Location = new System.Drawing.Point(45, 20);
            this.lbCatName.Name = "lbCatName";
            this.lbCatName.Size = new System.Drawing.Size(56, 21);
            this.lbCatName.TabIndex = 3;
            this.lbCatName.Text = "label1";
            this.lbCatName.Click += new System.EventHandler(this.lbCatName_Click);
            // 
            // CategoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.lbCatName);
            this.Controls.Add(this.ibtnEdit);
            this.Controls.Add(this.pnDecoration);
            this.Name = "CategoryItem";
            this.Size = new System.Drawing.Size(146, 61);
            this.Load += new System.EventHandler(this.CategoryItem_Load);
            this.Click += new System.EventHandler(this.CategoryItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDecoration;
        private FontAwesome.Sharp.IconButton ibtnEdit;
        private System.Windows.Forms.Label lbCatName;
    }
}
