namespace QuanLyQuanCafe
{
    partial class fNguyenLieu
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMieuTa = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaNL = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNguyenLieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(12, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 53);
            this.panel1.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(250, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(189, 13);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(55, 25);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(128, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 25);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(67, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 25);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.Location = new System.Drawing.Point(6, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 25);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvNguyenLieu);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // dtgvNguyenLieu
            // 
            this.dtgvNguyenLieu.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNguyenLieu.Location = new System.Drawing.Point(7, 20);
            this.dtgvNguyenLieu.Name = "dtgvNguyenLieu";
            this.dtgvNguyenLieu.Size = new System.Drawing.Size(306, 153);
            this.dtgvNguyenLieu.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txbMieuTa);
            this.panel6.Location = new System.Drawing.Point(9, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 48);
            this.panel6.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Miêu tả:";
            // 
            // txbMieuTa
            // 
            this.txbMieuTa.Location = new System.Drawing.Point(57, 3);
            this.txbMieuTa.Multiline = true;
            this.txbMieuTa.Name = "txbMieuTa";
            this.txbMieuTa.Size = new System.Drawing.Size(237, 42);
            this.txbMieuTa.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txbDonGia);
            this.panel5.Location = new System.Drawing.Point(9, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 33);
            this.panel5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá:";
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(97, 3);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(198, 20);
            this.txbDonGia.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbDonVi);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(9, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 33);
            this.panel4.TabIndex = 14;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.Items.AddRange(new object[] {
            "Kg",
            "Gói",
            "Cây"});
            this.cmbDonVi.Location = new System.Drawing.Point(95, 6);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(196, 21);
            this.cmbDonVi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn vị tính:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbTen);
            this.panel3.Location = new System.Drawing.Point(9, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 33);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nguyên liệu:";
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(95, 3);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(197, 20);
            this.txbTen.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbMaNL);
            this.panel2.Location = new System.Drawing.Point(9, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 33);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // txbMaNL
            // 
            this.txbMaNL.Location = new System.Drawing.Point(95, 3);
            this.txbMaNL.Name = "txbMaNL";
            this.txbMaNL.Size = new System.Drawing.Size(196, 20);
            this.txbMaNL.TabIndex = 5;
            // 
            // fNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(351, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nguyên liệu";
            this.SizeChanged += new System.EventHandler(this.fNguyenLieu_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fNguyenLieu_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNguyenLieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvNguyenLieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMieuTa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaNL;

    }
}