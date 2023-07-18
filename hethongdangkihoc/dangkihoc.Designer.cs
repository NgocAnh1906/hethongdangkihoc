namespace hethongdangkihoc
{
    partial class dangkihoc
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
            this.datamonhoc = new System.Windows.Forms.DataGridView();
            this.bntdangki = new System.Windows.Forms.Button();
            this.boxkihoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datadangki = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbdonviphi = new System.Windows.Forms.TextBox();
            this.bntxoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamonhoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadangki)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datamonhoc);
            this.groupBox1.Location = new System.Drawing.Point(253, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin mon hoc";
            // 
            // datamonhoc
            // 
            this.datamonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datamonhoc.Location = new System.Drawing.Point(3, 18);
            this.datamonhoc.Name = "datamonhoc";
            this.datamonhoc.RowTemplate.Height = 24;
            this.datamonhoc.Size = new System.Drawing.Size(591, 260);
            this.datamonhoc.TabIndex = 0;
            this.datamonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamonhoc_CellClick);
            // 
            // bntdangki
            // 
            this.bntdangki.Enabled = false;
            this.bntdangki.Location = new System.Drawing.Point(31, 21);
            this.bntdangki.Name = "bntdangki";
            this.bntdangki.Size = new System.Drawing.Size(164, 45);
            this.bntdangki.TabIndex = 1;
            this.bntdangki.Text = "Đăng kí";
            this.bntdangki.UseVisualStyleBackColor = true;
            this.bntdangki.Click += new System.EventHandler(this.bntdangki_Click);
            // 
            // boxkihoc
            // 
            this.boxkihoc.FormattingEnabled = true;
            this.boxkihoc.Items.AddRange(new object[] {
            "Hoc ki 1",
            "Hoc ki 2",
            "Hoc ki 3"});
            this.boxkihoc.Location = new System.Drawing.Point(6, 48);
            this.boxkihoc.Name = "boxkihoc";
            this.boxkihoc.Size = new System.Drawing.Size(180, 24);
            this.boxkihoc.TabIndex = 2;
            this.boxkihoc.SelectedIndexChanged += new System.EventHandler(this.boxkihoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn kì học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datadangki);
            this.groupBox2.Location = new System.Drawing.Point(256, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 255);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach dang ki";
            // 
            // datadangki
            // 
            this.datadangki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadangki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datadangki.Enabled = false;
            this.datadangki.Location = new System.Drawing.Point(3, 18);
            this.datadangki.Name = "datadangki";
            this.datadangki.RowTemplate.Height = 24;
            this.datadangki.Size = new System.Drawing.Size(588, 234);
            this.datadangki.TabIndex = 5;
            this.datadangki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadangki_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đơn vị phí";
            // 
            // txbdonviphi
            // 
            this.txbdonviphi.Enabled = false;
            this.txbdonviphi.Location = new System.Drawing.Point(6, 124);
            this.txbdonviphi.Name = "txbdonviphi";
            this.txbdonviphi.Size = new System.Drawing.Size(180, 22);
            this.txbdonviphi.TabIndex = 8;
            // 
            // bntxoa
            // 
            this.bntxoa.Enabled = false;
            this.bntxoa.Location = new System.Drawing.Point(31, 95);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(164, 39);
            this.bntxoa.TabIndex = 9;
            this.bntxoa.Text = "Xóa";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txbdonviphi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.boxkihoc);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 281);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntdangki);
            this.groupBox4.Controls.Add(this.bntxoa);
            this.groupBox4.Location = new System.Drawing.Point(12, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 237);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // dangkihoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 556);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "dangkihoc";
            this.Text = "dangkihoc";
            this.Load += new System.EventHandler(this.dangkihoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datamonhoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datadangki)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datamonhoc;
        private System.Windows.Forms.Button bntdangki;
        private System.Windows.Forms.ComboBox boxkihoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datadangki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbdonviphi;
        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}