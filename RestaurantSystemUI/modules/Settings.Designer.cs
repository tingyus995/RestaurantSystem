namespace RestaurantSystemUI.modules
{
    partial class Settings
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.btnBrowse = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.tbShopName = new RestaurantSystemUI.FlatTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vertPwd = new RestaurantSystemUI.FlatTextbox();
            this.btnChangePwd = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.oldPwd = new RestaurantSystemUI.FlatTextbox();
            this.newPwd = new RestaurantSystemUI.FlatTextbox();
            this.tabChangeTheme = new System.Windows.Forms.TabPage();
            this.btnApplyTheme = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnReset = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.btnAddFoods = new RestaurantSystemUI.controls.ThemedIconTextButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabChangeTheme.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(142, 83);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabChangeTheme);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 495);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.tbShopName);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.iconPictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "店家基本資訊";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 18;
            this.btnSave.Location = new System.Drawing.Point(471, 158);
            this.btnSave.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(116, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存設定";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnBrowse.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.btnBrowse.IconColor = System.Drawing.Color.White;
            this.btnBrowse.IconSize = 18;
            this.btnBrowse.Location = new System.Drawing.Point(36, 124);
            this.btnBrowse.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Rotation = 0D;
            this.btnBrowse.Size = new System.Drawing.Size(116, 36);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "選擇圖片";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbShopName
            // 
            this.tbShopName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbShopName.IsPassword = false;
            this.tbShopName.Location = new System.Drawing.Point(181, 83);
            this.tbShopName.Margin = new System.Windows.Forms.Padding(4);
            this.tbShopName.Name = "tbShopName";
            this.tbShopName.PlaceHolder = "店家名稱";
            this.tbShopName.Size = new System.Drawing.Size(406, 35);
            this.tbShopName.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabPage2.Controls.Add(this.vertPwd);
            this.tabPage2.Controls.Add(this.btnChangePwd);
            this.tabPage2.Controls.Add(this.oldPwd);
            this.tabPage2.Controls.Add(this.newPwd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "密碼變更";
            // 
            // vertPwd
            // 
            this.vertPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.vertPwd.IsPassword = false;
            this.vertPwd.Location = new System.Drawing.Point(30, 129);
            this.vertPwd.Name = "vertPwd";
            this.vertPwd.PlaceHolder = "確認新密碼";
            this.vertPwd.Size = new System.Drawing.Size(185, 45);
            this.vertPwd.TabIndex = 14;
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.AutoSize = true;
            this.btnChangePwd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePwd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChangePwd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnChangePwd.ForeColor = System.Drawing.Color.White;
            this.btnChangePwd.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChangePwd.IconColor = System.Drawing.Color.White;
            this.btnChangePwd.IconSize = 18;
            this.btnChangePwd.Location = new System.Drawing.Point(30, 199);
            this.btnChangePwd.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Rotation = 0D;
            this.btnChangePwd.Size = new System.Drawing.Size(173, 36);
            this.btnChangePwd.TabIndex = 13;
            this.btnChangePwd.Text = "變更管理員密碼";
            this.btnChangePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // oldPwd
            // 
            this.oldPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.oldPwd.IsPassword = false;
            this.oldPwd.Location = new System.Drawing.Point(30, 17);
            this.oldPwd.Name = "oldPwd";
            this.oldPwd.PlaceHolder = "舊密碼";
            this.oldPwd.Size = new System.Drawing.Size(185, 45);
            this.oldPwd.TabIndex = 12;
            // 
            // newPwd
            // 
            this.newPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.newPwd.IsPassword = false;
            this.newPwd.Location = new System.Drawing.Point(30, 68);
            this.newPwd.Name = "newPwd";
            this.newPwd.PlaceHolder = "新密碼";
            this.newPwd.Size = new System.Drawing.Size(185, 45);
            this.newPwd.TabIndex = 10;
            // 
            // tabChangeTheme
            // 
            this.tabChangeTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabChangeTheme.Controls.Add(this.btnApplyTheme);
            this.tabChangeTheme.Location = new System.Drawing.Point(4, 22);
            this.tabChangeTheme.Name = "tabChangeTheme";
            this.tabChangeTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeTheme.Size = new System.Drawing.Size(841, 469);
            this.tabChangeTheme.TabIndex = 2;
            this.tabChangeTheme.Text = "變更佈景主題";
            // 
            // btnApplyTheme
            // 
            this.btnApplyTheme.AutoSize = true;
            this.btnApplyTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApplyTheme.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApplyTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyTheme.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnApplyTheme.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnApplyTheme.ForeColor = System.Drawing.Color.White;
            this.btnApplyTheme.IconChar = FontAwesome.Sharp.IconChar.PaintRoller;
            this.btnApplyTheme.IconColor = System.Drawing.Color.White;
            this.btnApplyTheme.IconSize = 18;
            this.btnApplyTheme.Location = new System.Drawing.Point(18, 16);
            this.btnApplyTheme.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnApplyTheme.Name = "btnApplyTheme";
            this.btnApplyTheme.Rotation = 0D;
            this.btnApplyTheme.Size = new System.Drawing.Size(154, 36);
            this.btnApplyTheme.TabIndex = 0;
            this.btnApplyTheme.Text = "套用佈景主題";
            this.btnApplyTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyTheme.UseVisualStyleBackColor = true;
            this.btnApplyTheme.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabPage4.Controls.Add(this.btnReset);
            this.tabPage4.Controls.Add(this.btnAddFoods);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(841, 469);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "其他系統管理工具";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReset.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnReset.IconColor = System.Drawing.Color.White;
            this.btnReset.IconSize = 18;
            this.btnReset.Location = new System.Drawing.Point(6, 48);
            this.btnReset.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Rotation = 0D;
            this.btnReset.Size = new System.Drawing.Size(249, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "清除資料並恢復原廠設定";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddFoods
            // 
            this.btnAddFoods.AutoSize = true;
            this.btnAddFoods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFoods.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFoods.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddFoods.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddFoods.ForeColor = System.Drawing.Color.White;
            this.btnAddFoods.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnAddFoods.IconColor = System.Drawing.Color.White;
            this.btnAddFoods.IconSize = 18;
            this.btnAddFoods.Location = new System.Drawing.Point(6, 6);
            this.btnAddFoods.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnAddFoods.Name = "btnAddFoods";
            this.btnAddFoods.Rotation = 0D;
            this.btnAddFoods.Size = new System.Drawing.Size(192, 36);
            this.btnAddFoods.TabIndex = 0;
            this.btnAddFoods.Text = "批次匯入食物工具";
            this.btnAddFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFoods.UseVisualStyleBackColor = true;
            this.btnAddFoods.Click += new System.EventHandler(this.AddFoods_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 495);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(843, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 495);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(6, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 6);
            this.panel3.TabIndex = 3;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(849, 495);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabChangeTheme.ResumeLayout(false);
            this.tabChangeTheme.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatTextbox tbShopName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FlatTextbox newPwd;
        private FlatTextbox oldPwd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabChangeTheme;
        private FlatTextbox vertPwd;
        private controls.ThemedIconTextButton btnChangePwd;
        private System.Windows.Forms.TabPage tabPage4;
        private controls.ThemedIconTextButton btnAddFoods;
        private controls.ThemedIconTextButton btnApplyTheme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private controls.ThemedIconTextButton btnSave;
        private controls.ThemedIconTextButton btnBrowse;
        private controls.ThemedIconTextButton btnReset;
    }
}
