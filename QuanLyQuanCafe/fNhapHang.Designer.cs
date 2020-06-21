namespace QuanLyQuanCafe
{
    partial class fNhapHang
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
            this.txbMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMoTa = new System.Windows.Forms.TextBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txbMa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nmSoLuong);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txbTongTien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.cbNguyenLieu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbMoTa);
            this.panel1.Controls.Add(this.dtNgayNhap);
            this.panel1.Controls.Add(this.cbNhanVien);
            this.panel1.Controls.Add(this.cbNCC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 432);
            this.panel1.TabIndex = 0;
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(87, 9);
            this.txbMa.Name = "txbMa";
            this.txbMa.ReadOnly = true;
            this.txbMa.Size = new System.Drawing.Size(100, 20);
            this.txbMa.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã hóa đơn :";
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(215, 112);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(33, 20);
            this.nmSoLuong.TabIndex = 17;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(254, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(47, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(267, 352);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(54, 20);
            this.txbTongTien.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng tiền:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(267, 378);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(54, 35);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cbNguyenLieu
            // 
            this.cbNguyenLieu.FormattingEnabled = true;
            this.cbNguyenLieu.Location = new System.Drawing.Point(87, 111);
            this.cbNguyenLieu.Name = "cbNguyenLieu";
            this.cbNguyenLieu.Size = new System.Drawing.Size(121, 21);
            this.cbNguyenLieu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nguyên liệu";
            // 
            // txbMoTa
            // 
            this.txbMoTa.Location = new System.Drawing.Point(48, 352);
            this.txbMoTa.Multiline = true;
            this.txbMoTa.Name = "txbMoTa";
            this.txbMoTa.Size = new System.Drawing.Size(120, 61);
            this.txbMoTa.TabIndex = 10;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.CustomFormat = "MM/dd/yyyy";
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhap.Location = new System.Drawing.Point(87, 89);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(81, 20);
            this.dtNgayNhap.TabIndex = 9;
            this.dtNgayNhap.Value = new System.DateTime(2018, 9, 25, 0, 0, 0, 0);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(87, 62);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(121, 21);
            this.cbNhanVien.TabIndex = 8;
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(87, 35);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(121, 21);
            this.cbNCC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(3, 143);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(328, 203);
            this.lsvBill.TabIndex = 2;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn vị";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 70;
            // 
            // fNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 492);
            this.Controls.Add(this.panel1);
            this.Name = "fNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập hàng";
            this.SizeChanged += new System.EventHandler(this.fNhapHang_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fNhapHang_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txbMoTa;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ComboBox cbNguyenLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Label label7;
    }
}