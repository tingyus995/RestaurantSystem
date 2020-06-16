namespace RestaurantSystemUI
{
    partial class ConfirmWindow
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
            this.themedLabel1 = new RestaurantSystemUI.controls.ThemedLabel();
            this.ftbConfirmWord = new RestaurantSystemUI.FlatTextbox();
            this.btnConfirm = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.SuspendLayout();
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(12, 9);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(357, 28);
            this.themedLabel1.TabIndex = 0;
            this.themedLabel1.Text = "請在輸入框中輸入「Yes」刪除系統";
            // 
            // ftbConfirmWord
            // 
            this.ftbConfirmWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbConfirmWord.IsPassword = false;
            this.ftbConfirmWord.Location = new System.Drawing.Point(17, 40);
            this.ftbConfirmWord.Name = "ftbConfirmWord";
            this.ftbConfirmWord.PlaceHolder = null;
            this.ftbConfirmWord.Size = new System.Drawing.Size(352, 45);
            this.ftbConfirmWord.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnConfirm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirm.IconSize = 18;
            this.btnConfirm.Location = new System.Drawing.Point(17, 97);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Rotation = 0D;
            this.btnConfirm.Size = new System.Drawing.Size(249, 36);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "刪除資料並恢復出廠設定";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ConfirmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(399, 145);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.ftbConfirmWord);
            this.Controls.Add(this.themedLabel1);
            this.Name = "ConfirmWindow";
            this.Text = "ConfirmWindow";
            this.Load += new System.EventHandler(this.ConfirmWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ThemedLabel themedLabel1;
        private FlatTextbox ftbConfirmWord;
        private controls.ThemedIconTextButton btnConfirm;
    }
}