namespace RestaurantSystemUI.OOBE_pages
{
    partial class BasicInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.flatTextbox1 = new RestaurantSystemUI.FlatTextbox();
            this.themedLabel2 = new RestaurantSystemUI.controls.ThemedLabel();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(316, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnBrowse.IconColor = System.Drawing.Color.White;
            this.btnBrowse.IconSize = 18;
            this.btnBrowse.Location = new System.Drawing.Point(170, 291);
            this.btnBrowse.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Rotation = 0D;
            this.btnBrowse.Size = new System.Drawing.Size(116, 36);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "瀏覽圖片";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // flatTextbox1
            // 
            this.flatTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatTextbox1.Location = new System.Drawing.Point(161, 165);
            this.flatTextbox1.Name = "flatTextbox1";
            this.flatTextbox1.PlaceHolder = "店家名稱";
            this.flatTextbox1.Size = new System.Drawing.Size(313, 45);
            this.flatTextbox1.TabIndex = 5;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(173, 95);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(276, 35);
            this.themedLabel2.TabIndex = 4;
            this.themedLabel2.Text = "設定店家名稱與 Logo";
            this.themedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(194, 27);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(242, 47);
            this.themedLabel1.TabIndex = 3;
            this.themedLabel1.Text = "店家基本資訊";
            // 
            // BasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flatTextbox1);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Name = "BasicInfo";
            this.Size = new System.Drawing.Size(640, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ThemedLabel themedLabel1;
        private controls.ThemedLabel themedLabel2;
        private FlatTextbox flatTextbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.ThemedIconTextButton btnBrowse;
    }
}
