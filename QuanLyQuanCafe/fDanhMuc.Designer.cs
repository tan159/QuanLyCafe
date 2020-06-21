namespace QuanLyQuanCafe
{
    partial class fDanhMuc
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMaDanhMuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbTenDanhMuc);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(9, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 34);
            this.panel5.TabIndex = 3;
            // 
            // txbTenDanhMuc
            // 
            this.txbTenDanhMuc.Location = new System.Drawing.Point(95, 4);
            this.txbTenDanhMuc.Name = "txbTenDanhMuc";
            this.txbTenDanhMuc.Size = new System.Drawing.Size(150, 20);
            this.txbTenDanhMuc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên danh mục :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbMaDanhMuc);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(9, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 34);
            this.panel4.TabIndex = 2;
            // 
            // txbMaDanhMuc
            // 
            this.txbMaDanhMuc.Location = new System.Drawing.Point(95, 4);
            this.txbMaDanhMuc.Name = "txbMaDanhMuc";
            this.txbMaDanhMuc.ReadOnly = true;
            this.txbMaDanhMuc.Size = new System.Drawing.Size(45, 20);
            this.txbMaDanhMuc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã danh muc:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDanhMuc);
            this.panel1.Location = new System.Drawing.Point(296, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 114);
            this.panel1.TabIndex = 1;
            // 
            // dtgvDanhMuc
            // 
            this.dtgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhMuc.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhMuc.Location = new System.Drawing.Point(4, 7);
            this.dtgvDanhMuc.Name = "dtgvDanhMuc";
            this.dtgvDanhMuc.Size = new System.Drawing.Size(263, 107);
            this.dtgvDanhMuc.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(296, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 48);
            this.panel2.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(206, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyQuanCafe.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(135, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 25);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Delete";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Image = global::QuanLyQuanCafe.Properties.Resources.refresh;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(64, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 25);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Update";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.Image = global::QuanLyQuanCafe.Properties.Resources.plus;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 25);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Add";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Image = global::QuanLyQuanCafe.Properties.Resources.loading;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(223, 193);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(67, 25);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Refresh";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // fDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(590, 241);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục";
            this.SizeChanged += new System.EventHandler(this.fDanhMuc_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fDanhMuc_Paint);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbTenDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbMaDanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDanhMuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}