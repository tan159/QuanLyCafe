namespace QuanLyQuanCafe
{
    partial class fCaLam
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMaCa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbLoaiCa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCaLam = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCaLam)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 92);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbMaCa);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 33);
            this.panel3.TabIndex = 19;
            // 
            // txbMaCa
            // 
            this.txbMaCa.Location = new System.Drawing.Point(50, 3);
            this.txbMaCa.Name = "txbMaCa";
            this.txbMaCa.ReadOnly = true;
            this.txbMaCa.Size = new System.Drawing.Size(47, 20);
            this.txbMaCa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Ca:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbLoaiCa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 33);
            this.panel2.TabIndex = 18;
            // 
            // txbLoaiCa
            // 
            this.txbLoaiCa.Location = new System.Drawing.Point(50, 3);
            this.txbLoaiCa.Name = "txbLoaiCa";
            this.txbLoaiCa.Size = new System.Drawing.Size(79, 20);
            this.txbLoaiCa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại ca:";
            // 
            // dtgvCaLam
            // 
            this.dtgvCaLam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCaLam.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCaLam.Location = new System.Drawing.Point(175, 55);
            this.dtgvCaLam.Name = "dtgvCaLam";
            this.dtgvCaLam.Size = new System.Drawing.Size(184, 92);
            this.dtgvCaLam.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnXem);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Location = new System.Drawing.Point(12, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 48);
            this.panel4.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(273, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(9, 13);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(60, 25);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(207, 13);
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
            this.btnSua.Location = new System.Drawing.Point(141, 13);
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
            this.btnThem.Location = new System.Drawing.Point(75, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 25);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(372, 214);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtgvCaLam);
            this.Controls.Add(this.panel1);
            this.Name = "fCaLam";
            this.Text = "Ca làm";
            this.SizeChanged += new System.EventHandler(this.fCaLam_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fCaLam_Paint);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCaLam)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbMaCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCaLam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbLoaiCa;

    }
}