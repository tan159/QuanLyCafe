namespace QuanLyQuanCafe
{
    partial class fBanAn
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMieuTa = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmKhuVuc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenBan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaBan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvBanAn = new System.Windows.Forms.DataGridView();
            this.maBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuVucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mieuTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKhuVuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn ăn";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txbMieuTa);
            this.panel6.Location = new System.Drawing.Point(6, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 49);
            this.panel6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Miêu tả:";
            // 
            // txbMieuTa
            // 
            this.txbMieuTa.Location = new System.Drawing.Point(58, 4);
            this.txbMieuTa.Multiline = true;
            this.txbMieuTa.Name = "txbMieuTa";
            this.txbMieuTa.Size = new System.Drawing.Size(356, 39);
            this.txbMieuTa.TabIndex = 5;
            this.txbMieuTa.Text = "Không";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Controls.Add(this.btnXem);
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Location = new System.Drawing.Point(52, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 43);
            this.panel5.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(172, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(253, 10);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(91, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmKhuVuc);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(228, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 35);
            this.panel3.TabIndex = 3;
            // 
            // nmKhuVuc
            // 
            this.nmKhuVuc.Location = new System.Drawing.Point(61, 4);
            this.nmKhuVuc.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmKhuVuc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmKhuVuc.Name = "nmKhuVuc";
            this.nmKhuVuc.Size = new System.Drawing.Size(39, 20);
            this.nmKhuVuc.TabIndex = 3;
            this.nmKhuVuc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khu vực:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbTenBan);
            this.panel2.Location = new System.Drawing.Point(6, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 35);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bàn:";
            // 
            // txbTenBan
            // 
            this.txbTenBan.Location = new System.Drawing.Point(62, 1);
            this.txbTenBan.Name = "txbTenBan";
            this.txbTenBan.Size = new System.Drawing.Size(130, 20);
            this.txbTenBan.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbMaBan);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bàn:";
            // 
            // txbMaBan
            // 
            this.txbMaBan.Location = new System.Drawing.Point(61, 4);
            this.txbMaBan.Name = "txbMaBan";
            this.txbMaBan.ReadOnly = true;
            this.txbMaBan.Size = new System.Drawing.Size(131, 20);
            this.txbMaBan.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvBanAn);
            this.groupBox2.Location = new System.Drawing.Point(13, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // dtgvBanAn
            // 
            this.dtgvBanAn.AutoGenerateColumns = false;
            this.dtgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBanDataGridViewTextBoxColumn,
            this.tenBanDataGridViewTextBoxColumn,
            this.khuVucDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.mieuTaDataGridViewTextBoxColumn});
            this.dtgvBanAn.DataSource = this.tableBindingSource;
            this.dtgvBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBanAn.Location = new System.Drawing.Point(3, 16);
            this.dtgvBanAn.Name = "dtgvBanAn";
            this.dtgvBanAn.Size = new System.Drawing.Size(443, 180);
            this.dtgvBanAn.TabIndex = 0;
            this.dtgvBanAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBanAn_CellContentClick);
            // 
            // maBanDataGridViewTextBoxColumn
            // 
            this.maBanDataGridViewTextBoxColumn.DataPropertyName = "MaBan";
            this.maBanDataGridViewTextBoxColumn.HeaderText = "MaBan";
            this.maBanDataGridViewTextBoxColumn.Name = "maBanDataGridViewTextBoxColumn";
            this.maBanDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenBanDataGridViewTextBoxColumn
            // 
            this.tenBanDataGridViewTextBoxColumn.DataPropertyName = "TenBan";
            this.tenBanDataGridViewTextBoxColumn.HeaderText = "TenBan";
            this.tenBanDataGridViewTextBoxColumn.Name = "tenBanDataGridViewTextBoxColumn";
            // 
            // khuVucDataGridViewTextBoxColumn
            // 
            this.khuVucDataGridViewTextBoxColumn.DataPropertyName = "KhuVuc";
            this.khuVucDataGridViewTextBoxColumn.HeaderText = "KhuVuc";
            this.khuVucDataGridViewTextBoxColumn.Name = "khuVucDataGridViewTextBoxColumn";
            this.khuVucDataGridViewTextBoxColumn.Width = 50;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            // 
            // mieuTaDataGridViewTextBoxColumn
            // 
            this.mieuTaDataGridViewTextBoxColumn.DataPropertyName = "MieuTa";
            this.mieuTaDataGridViewTextBoxColumn.HeaderText = "MieuTa";
            this.mieuTaDataGridViewTextBoxColumn.Name = "mieuTaDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(QuanLyQuanCafe.DTO.Table);
            // 
            // fBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fBanAn";
            this.Text = "Quản lý bàn";
            this.Load += new System.EventHandler(this.fBanAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKhuVuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvBanAn;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTenBan;
        private System.Windows.Forms.TextBox txbMaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMieuTa;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuVucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mieuTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nmKhuVuc;

    }
}