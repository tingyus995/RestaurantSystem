namespace RestaurantSystemUI
{
    partial class OOBE
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
            this.pnPageIndicator = new System.Windows.Forms.Panel();
            this.pnPageContainer = new System.Windows.Forms.Panel();
            this.btnNext = new RestaurantSystemUI.controls.ThemedIconButton();
            this.btnPrev = new RestaurantSystemUI.controls.ThemedIconButton();
            this.SuspendLayout();
            // 
            // pnPageIndicator
            // 
            this.pnPageIndicator.Location = new System.Drawing.Point(198, 464);
            this.pnPageIndicator.Name = "pnPageIndicator";
            this.pnPageIndicator.Size = new System.Drawing.Size(200, 25);
            this.pnPageIndicator.TabIndex = 1;
            this.pnPageIndicator.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPageIndicator_Paint);
            // 
            // pnPageContainer
            // 
            this.pnPageContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPageContainer.Location = new System.Drawing.Point(0, 0);
            this.pnPageContainer.Name = "pnPageContainer";
            this.pnPageContainer.Size = new System.Drawing.Size(624, 458);
            this.pnPageContainer.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconSize = 30;
            this.btnNext.Location = new System.Drawing.Point(576, 206);
            this.btnNext.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(36, 33);
            this.btnNext.TabIndex = 4;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnPrev.IconColor = System.Drawing.Color.White;
            this.btnPrev.IconSize = 30;
            this.btnPrev.Location = new System.Drawing.Point(12, 206);
            this.btnPrev.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 0D;
            this.btnPrev.Size = new System.Drawing.Size(36, 33);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // OOBE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(624, 501);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.pnPageContainer);
            this.Controls.Add(this.pnPageIndicator);
            this.Name = "OOBE";
            this.Text = "OOBE";
            this.Load += new System.EventHandler(this.OOBE_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnPageIndicator;
        private controls.ThemedIconButton btnPrev;
        private controls.ThemedIconButton btnNext;
        private System.Windows.Forms.Panel pnPageContainer;
    }
}