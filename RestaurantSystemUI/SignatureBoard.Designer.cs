namespace RestaurantSystemUI
{
    partial class SignatureBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Thickness = new System.Windows.Forms.TrackBar();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.CurrentColor = new System.Windows.Forms.PictureBox();
            this.themedLabel2 = new RestaurantSystemUI.controls.ThemedLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.Submit = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.Clear = new RestaurantSystemUI.controls.ThemedIconTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColor)).BeginInit();
            this.SuspendLayout();
            // 
            // Thickness
            // 
            this.Thickness.Location = new System.Drawing.Point(116, 16);
            this.Thickness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Thickness.Maximum = 20;
            this.Thickness.Minimum = 1;
            this.Thickness.Name = "Thickness";
            this.Thickness.Size = new System.Drawing.Size(211, 45);
            this.Thickness.TabIndex = 2;
            this.Thickness.Value = 1;
            this.Thickness.Scroll += new System.EventHandler(this.Thickness_Scroll);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Location = new System.Drawing.Point(36, 65);
            this.canvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(445, 274);
            this.canvas.TabIndex = 3;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseEnter += new System.EventHandler(this.canvas_MouseEnter);
            this.canvas.MouseLeave += new System.EventHandler(this.canvas_MouseLeave);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // CurrentColor
            // 
            this.CurrentColor.Location = new System.Drawing.Point(435, 9);
            this.CurrentColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(68, 52);
            this.CurrentColor.TabIndex = 1;
            this.CurrentColor.TabStop = false;
            this.CurrentColor.Click += new System.EventHandler(this.CurrentColor_Click);
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(11, 16);
            this.themedLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(100, 28);
            this.themedLabel2.TabIndex = 5;
            this.themedLabel2.Text = "筆的粗細";
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(331, 16);
            this.themedLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(100, 28);
            this.themedLabel1.TabIndex = 6;
            this.themedLabel1.Text = "筆的顏色";
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Submit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Submit.IconColor = System.Drawing.Color.White;
            this.Submit.IconSize = 18;
            this.Submit.Location = new System.Drawing.Point(298, 345);
            this.Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit.MinimumSize = new System.Drawing.Size(7, 7);
            this.Submit.Name = "Submit";
            this.Submit.Rotation = 0D;
            this.Submit.Size = new System.Drawing.Size(78, 36);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "確定";
            this.Submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Clear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.Clear.IconColor = System.Drawing.Color.White;
            this.Clear.IconSize = 18;
            this.Clear.Location = new System.Drawing.Point(172, 345);
            this.Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear.MinimumSize = new System.Drawing.Size(7, 7);
            this.Clear.Name = "Clear";
            this.Clear.Rotation = 0D;
            this.Clear.Size = new System.Drawing.Size(78, 36);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "清除";
            this.Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SignatureBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(533, 389);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.Thickness);
            this.Controls.Add(this.CurrentColor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignatureBoard";
            this.Text = "SignatureBoard";
            this.Load += new System.EventHandler(this.SignatureBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CurrentColor;
        private System.Windows.Forms.TrackBar Thickness;
        private System.Windows.Forms.PictureBox canvas;
        private controls.ThemedLabel themedLabel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private controls.ThemedLabel themedLabel1;
        private controls.ThemedIconTextButton Submit;
        private controls.ThemedIconTextButton Clear;
    }
}