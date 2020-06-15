namespace RestaurantSystemUI.modules
{
    partial class ImageCropper
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
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.imageCropperBox1 = new RestaurantSystemUI.ImageCropperBox();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel2 = new RestaurantSystemUI.controls.ThemedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCropperBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(407, 87);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(137, 107);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 1;
            this.pbPreview.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnConfirm.IconColor = System.Drawing.Color.White;
            this.btnConfirm.IconSize = 18;
            this.btnConfirm.Location = new System.Drawing.Point(413, 418);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Rotation = 0D;
            this.btnConfirm.Size = new System.Drawing.Size(116, 36);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "確定裁切";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // imageCropperBox1
            // 
            this.imageCropperBox1.Image = null;
            this.imageCropperBox1.Location = new System.Drawing.Point(53, 55);
            this.imageCropperBox1.Name = "imageCropperBox1";
            this.imageCropperBox1.Size = new System.Drawing.Size(348, 399);
            this.imageCropperBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageCropperBox1.TabIndex = 0;
            this.imageCropperBox1.TabStop = false;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(408, 56);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(78, 28);
            this.themedLabel1.TabIndex = 3;
            this.themedLabel1.Text = "預覽圖";
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(58, 12);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(100, 28);
            this.themedLabel2.TabIndex = 4;
            this.themedLabel2.Text = "裁切圖片";
            // 
            // ImageCropper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.imageCropperBox1);
            this.Name = "ImageCropper";
            this.Size = new System.Drawing.Size(556, 469);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCropperBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageCropperBox imageCropperBox1;
        private System.Windows.Forms.PictureBox pbPreview;
        private controls.ThemedIconTextButton btnConfirm;
        private controls.ThemedLabel themedLabel1;
        private controls.ThemedLabel themedLabel2;
    }
}
