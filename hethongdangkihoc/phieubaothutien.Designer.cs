namespace hethongdangkihoc
{
    partial class phieubaothutien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datahocphi = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.GroupBox();
            this.datatonghocphi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datahocphi)).BeginInit();
            this.Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatonghocphi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datahocphi);
            this.groupBox1.Location = new System.Drawing.Point(26, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học phí";
            // 
            // datahocphi
            // 
            this.datahocphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahocphi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datahocphi.Location = new System.Drawing.Point(3, 18);
            this.datahocphi.Name = "datahocphi";
            this.datahocphi.RowTemplate.Height = 24;
            this.datahocphi.Size = new System.Drawing.Size(570, 186);
            this.datahocphi.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.Controls.Add(this.datatonghocphi);
            this.Total.Location = new System.Drawing.Point(71, 272);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(478, 79);
            this.Total.TabIndex = 1;
            this.Total.TabStop = false;
            this.Total.Text = "Tong";
            // 
            // datatonghocphi
            // 
            this.datatonghocphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatonghocphi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datatonghocphi.Location = new System.Drawing.Point(3, 18);
            this.datatonghocphi.Name = "datatonghocphi";
            this.datatonghocphi.RowTemplate.Height = 24;
            this.datatonghocphi.Size = new System.Drawing.Size(472, 58);
            this.datatonghocphi.TabIndex = 0;
            // 
            // phieubaothutien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 398);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.groupBox1);
            this.Name = "phieubaothutien";
            this.Text = "phieubaothutien";
            this.Load += new System.EventHandler(this.phieubaothutien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datahocphi)).EndInit();
            this.Total.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datatonghocphi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datahocphi;
        private System.Windows.Forms.GroupBox Total;
        private System.Windows.Forms.DataGridView datatonghocphi;
    }
}