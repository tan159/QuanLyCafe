namespace QuanLyQuanCafe
{
    partial class fChamCong
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
            this.dtgvChamCong = new System.Windows.Forms.DataGridView();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cbCa = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbGhiChu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChamCong
            // 
            this.dtgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChamCong.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChamCong.Location = new System.Drawing.Point(12, 104);
            this.dtgvChamCong.Name = "dtgvChamCong";
            this.dtgvChamCong.Size = new System.Drawing.Size(575, 150);
            this.dtgvChamCong.TabIndex = 0;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Location = new System.Drawing.Point(512, 260);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(75, 23);
            this.btnChamCong.TabIndex = 1;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ca :";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "MM/dd/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(56, 60);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(99, 20);
            this.dtpNgay.TabIndex = 8;
            // 
            // cbCa
            // 
            this.cbCa.FormattingEnabled = true;
            this.cbCa.Location = new System.Drawing.Point(231, 61);
            this.cbCa.Name = "cbCa";
            this.cbCa.Size = new System.Drawing.Size(103, 21);
            this.cbCa.TabIndex = 9;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(274, 259);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(93, 23);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem chấm công";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(373, 259);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa công";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(454, 259);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbGhiChu
            // 
            this.cbGhiChu.FormattingEnabled = true;
            this.cbGhiChu.Items.AddRange(new object[] {
            "Có làm",
            "Không làm"});
            this.cbGhiChu.Location = new System.Drawing.Point(454, 61);
            this.cbGhiChu.Name = "cbGhiChu";
            this.cbGhiChu.Size = new System.Drawing.Size(121, 21);
            this.cbGhiChu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ghi chú:";
            // 
            // fChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(599, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGhiChu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbCa);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.dtgvChamCong);
            this.Name = "fChamCong";
            this.Text = "Quản lý chấm công";
            this.SizeChanged += new System.EventHandler(this.fChamCong_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fChamCong_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChamCong;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cbCa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbGhiChu;
        private System.Windows.Forms.Label label2;
    }
}