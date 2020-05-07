namespace RestaurantSystemUI.modules
{
    partial class FoodEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbFoodImage = new FontAwesome.Sharp.IconPictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ftbName = new RestaurantSystemUI.FlatTextbox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ftbBasePrice = new RestaurantSystemUI.FlatTextbox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pnTopHalf = new System.Windows.Forms.Panel();
            this.ibtnBack = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fpVarients = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpBottomHalf = new System.Windows.Forms.TableLayoutPanel();
            this.tagInput1 = new RestaurantSystemUI.controls.TagInput();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.pnTopHalf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpBottomHalf.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "食物名稱";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "食物基本價錢";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 4);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "食物分類";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.Location = new System.Drawing.Point(3, 4);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 8;
            this.iconPictureBox3.TabStop = false;
            // 
            // ipbFoodImage
            // 
            this.ipbFoodImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ipbFoodImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipbFoodImage.ForeColor = System.Drawing.Color.LightGray;
            this.ipbFoodImage.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            this.ipbFoodImage.IconColor = System.Drawing.Color.LightGray;
            this.ipbFoodImage.IconSize = 130;
            this.ipbFoodImage.Location = new System.Drawing.Point(12, 17);
            this.ipbFoodImage.Name = "ipbFoodImage";
            this.ipbFoodImage.Size = new System.Drawing.Size(130, 130);
            this.ipbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ipbFoodImage.TabIndex = 10;
            this.ipbFoodImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(158, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "食物種類";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.iconPictureBox5.IconColor = System.Drawing.Color.White;
            this.iconPictureBox5.Location = new System.Drawing.Point(3, 4);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox5.TabIndex = 12;
            this.iconPictureBox5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ftbName, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(158, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 46);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // ftbName
            // 
            this.ftbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbName.Location = new System.Drawing.Point(151, 5);
            this.ftbName.Name = "ftbName";
            this.ftbName.PlaceHolder = "例如：麻醬麵";
            this.ftbName.Size = new System.Drawing.Size(231, 36);
            this.ftbName.TabIndex = 0;
            this.ftbName.Theme = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.iconPictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ftbBasePrice, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 66);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 41);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // ftbBasePrice
            // 
            this.ftbBasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftbBasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ftbBasePrice.Location = new System.Drawing.Point(223, 3);
            this.ftbBasePrice.Name = "ftbBasePrice";
            this.ftbBasePrice.PlaceHolder = "例如：180";
            this.ftbBasePrice.Size = new System.Drawing.Size(129, 35);
            this.ftbBasePrice.TabIndex = 1;
            this.ftbBasePrice.Theme = null;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.iconPictureBox5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(572, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(144, 41);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.iconPictureBox3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(139, 41);
            this.tableLayoutPanel6.TabIndex = 21;
            // 
            // pnTopHalf
            // 
            this.pnTopHalf.Controls.Add(this.ibtnBack);
            this.pnTopHalf.Controls.Add(this.pictureBox1);
            this.pnTopHalf.Controls.Add(this.ipbFoodImage);
            this.pnTopHalf.Controls.Add(this.btnSave);
            this.pnTopHalf.Controls.Add(this.tableLayoutPanel2);
            this.pnTopHalf.Controls.Add(this.tableLayoutPanel1);
            this.pnTopHalf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopHalf.Location = new System.Drawing.Point(0, 0);
            this.pnTopHalf.Name = "pnTopHalf";
            this.pnTopHalf.Size = new System.Drawing.Size(1138, 169);
            this.pnTopHalf.TabIndex = 23;
            // 
            // ibtnBack
            // 
            this.ibtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnBack.FlatAppearance.BorderSize = 0;
            this.ibtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ibtnBack.IconColor = System.Drawing.Color.White;
            this.ibtnBack.IconSize = 50;
            this.ibtnBack.Location = new System.Drawing.Point(1049, 12);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Rotation = 0D;
            this.ibtnBack.Size = new System.Drawing.Size(75, 48);
            this.ibtnBack.TabIndex = 19;
            this.ibtnBack.UseVisualStyleBackColor = true;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(735, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 99);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // fpVarients
            // 
            this.fpVarients.AutoScroll = true;
            this.fpVarients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpVarients.Location = new System.Drawing.Point(572, 50);
            this.fpVarients.Name = "fpVarients";
            this.fpVarients.Padding = new System.Windows.Forms.Padding(10);
            this.fpVarients.Size = new System.Drawing.Size(563, 507);
            this.fpVarients.TabIndex = 14;
            // 
            // tlpBottomHalf
            // 
            this.tlpBottomHalf.ColumnCount = 2;
            this.tlpBottomHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottomHalf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottomHalf.Controls.Add(this.tagInput1, 0, 1);
            this.tlpBottomHalf.Controls.Add(this.fpVarients, 1, 1);
            this.tlpBottomHalf.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tlpBottomHalf.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tlpBottomHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottomHalf.Location = new System.Drawing.Point(0, 169);
            this.tlpBottomHalf.Name = "tlpBottomHalf";
            this.tlpBottomHalf.RowCount = 2;
            this.tlpBottomHalf.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBottomHalf.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBottomHalf.Size = new System.Drawing.Size(1138, 553);
            this.tlpBottomHalf.TabIndex = 24;
            // 
            // tagInput1
            // 
            this.tagInput1.AutoScroll = true;
            this.tagInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tagInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagInput1.Location = new System.Drawing.Point(3, 50);
            this.tagInput1.Name = "tagInput1";
            this.tagInput1.Padding = new System.Windows.Forms.Padding(10);
            this.tagInput1.Size = new System.Drawing.Size(563, 507);
            this.tagInput1.TabIndex = 3;
            this.tagInput1.Tags = new string[0];
            // 
            // FoodEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.tlpBottomHalf);
            this.Controls.Add(this.pnTopHalf);
            this.Name = "FoodEditor";
            this.Size = new System.Drawing.Size(1138, 722);
            this.Load += new System.EventHandler(this.FoodEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.pnTopHalf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlpBottomHalf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatTextbox ftbName;
        private FlatTextbox ftbBasePrice;
        private controls.TagInput tagInput1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox ipbFoodImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel pnTopHalf;
        private System.Windows.Forms.FlowLayoutPanel fpVarients;
        private System.Windows.Forms.TableLayoutPanel tlpBottomHalf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnBack;
    }
}
