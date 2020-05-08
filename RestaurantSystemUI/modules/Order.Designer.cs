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
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.col1 = new System.Windows.Forms.Panel();
            this.fpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.col1_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatNumericUpDown1 = new RestaurantSystemUI.FlatNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.col1.SuspendLayout();
            this.col1_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // fpCategories
            // 
            this.fpCategories.AutoScroll = true;
            this.fpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCategories.Location = new System.Drawing.Point(0, 63);
            this.fpCategories.Name = "fpCategories";
            this.fpCategories.Size = new System.Drawing.Size(327, 498);
            this.fpCategories.TabIndex = 2;
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(371, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 211);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Time
            // 
            this.Time.HeaderText = "Column1";
            this.Time.Name = "Time";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column1";
            this.Column2.Name = "Column2";
            // 
            // flatNumericUpDown1
            // 
            this.flatNumericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.flatNumericUpDown1.Location = new System.Drawing.Point(418, 63);
            this.flatNumericUpDown1.Maximum = 10;
            this.flatNumericUpDown1.Minimum = 0;
            this.flatNumericUpDown1.Name = "flatNumericUpDown1";
            this.flatNumericUpDown1.Size = new System.Drawing.Size(217, 60);
            this.flatNumericUpDown1.TabIndex = 6;
            this.flatNumericUpDown1.Value = 0;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.flatNumericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.col1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbFood);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(849, 561);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.col1.ResumeLayout(false);
            this.col1_header.ResumeLayout(false);
            this.col1_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel col1;
        private System.Windows.Forms.FlowLayoutPanel fpCategories;
        private System.Windows.Forms.Panel col1_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private FlatNumericUpDown flatNumericUpDown1;
    }
}
