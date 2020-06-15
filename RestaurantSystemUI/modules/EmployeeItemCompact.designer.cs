namespace RestaurantSystemUI
{
    partial class EmployeeItemCompact
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
            this.lbName = new System.Windows.Forms.Label();
            this.pnCardStatus = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(22, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // pnCardStatus
            // 
            this.pnCardStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnCardStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCardStatus.Location = new System.Drawing.Point(0, 0);
            this.pnCardStatus.Name = "pnCardStatus";
            this.pnCardStatus.Size = new System.Drawing.Size(16, 42);
            this.pnCardStatus.TabIndex = 1;
            // 
            // EmployeeItemCompact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnCardStatus);
            this.Controls.Add(this.lbName);
            this.Name = "EmployeeItemCompact";
            this.Size = new System.Drawing.Size(96, 42);
            this.Load += new System.EventHandler(this.EmployeeItemCompact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnCardStatus;
    }
}
