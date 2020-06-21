namespace QuanLyQuanCafe
{
    partial class fThongKeChamCong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.nmThang = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCa = new System.Windows.Forms.ComboBox();
            this.ca = new System.Windows.Forms.Label();
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.nmThang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCa);
            this.panel1.Controls.Add(this.ca);
            this.panel1.Controls.Add(this.dtgvThongKe);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 301);
            this.panel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(132, 76);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // nmThang
            // 
            this.nmThang.Location = new System.Drawing.Point(45, 43);
            this.nmThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmThang.Name = "nmThang";
            this.nmThang.Size = new System.Drawing.Size(35, 20);
            this.nmThang.TabIndex = 4;
            this.nmThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tháng:";
            // 
            // cbCa
            // 
            this.cbCa.FormattingEnabled = true;
            this.cbCa.Location = new System.Drawing.Point(45, 12);
            this.cbCa.Name = "cbCa";
            this.cbCa.Size = new System.Drawing.Size(121, 21);
            this.cbCa.TabIndex = 2;
            // 
            // ca
            // 
            this.ca.AutoSize = true;
            this.ca.Location = new System.Drawing.Point(4, 15);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(23, 13);
            this.ca.TabIndex = 1;
            this.ca.Text = "Ca:";
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongKe.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKe.Location = new System.Drawing.Point(0, 116);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.Size = new System.Drawing.Size(359, 182);
            this.dtgvThongKe.TabIndex = 0;
            // 
            // fThongKeChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 368);
            this.Controls.Add(this.panel1);
            this.Name = "fThongKeChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê chấm công";
            this.SizeChanged += new System.EventHandler(this.fThongKeChamCong_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fThongKeChamCong_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvThongKe;
        private System.Windows.Forms.ComboBox cbCa;
        private System.Windows.Forms.Label ca;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.NumericUpDown nmThang;
        private System.Windows.Forms.Label label1;
    }
}