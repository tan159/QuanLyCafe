namespace QuanLyQuanCafe
{
    partial class fChucVu
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel11.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.txbMa);
            this.panel11.Location = new System.Drawing.Point(12, 56);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(242, 33);
            this.panel11.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã chức vụ:";
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(86, 3);
            this.txbMa.Name = "txbMa";
            this.txbMa.ReadOnly = true;
            this.txbMa.Size = new System.Drawing.Size(135, 20);
            this.txbMa.TabIndex = 5;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel15.Controls.Add(this.label13);
            this.panel15.Controls.Add(this.txbTen);
            this.panel15.Location = new System.Drawing.Point(12, 92);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(242, 33);
            this.panel15.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên chức vụ:";
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(86, 3);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(135, 20);
            this.txbTen.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 106);
            this.dataGridView1.TabIndex = 18;
            // 
            // panel13
            // 
            this.panel13.AutoSize = true;
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel13.Controls.Add(this.btnThoat);
            this.panel13.Controls.Add(this.btnXem);
            this.panel13.Controls.Add(this.btnXoa);
            this.panel13.Controls.Add(this.btnSua);
            this.panel13.Controls.Add(this.btnThem);
            this.panel13.Location = new System.Drawing.Point(260, 70);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(152, 180);
            this.panel13.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(78, 152);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(12, 85);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(60, 25);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 25);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(78, 121);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 25);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.Location = new System.Drawing.Point(12, 121);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 25);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel15);
            this.Name = "fChucVu";
            this.Text = "Quản lý chức vụ";
            this.SizeChanged += new System.EventHandler(this.fChucVu_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fChucVu_Paint);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}