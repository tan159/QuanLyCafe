namespace QuanLyQuanCafe
{
    partial class fThongKe
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvThongKePn = new System.Windows.Forms.DataGridView();
            this.btnThongKePn = new System.Windows.Forms.Button();
            this.nmThang = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbTongTienBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKePn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmThang)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.txbTongTien);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtgvThongKePn);
            this.tabPage2.Controls.Add(this.btnThongKePn);
            this.tabPage2.Controls.Add(this.nmThang);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông kê hóa đơn nhập";
            // 
            // txbTongTien
            // 
            this.txbTongTien.ForeColor = System.Drawing.Color.Red;
            this.txbTongTien.Location = new System.Drawing.Point(452, 333);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(103, 20);
            this.txbTongTien.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng tiền:";
            // 
            // dtgvThongKePn
            // 
            this.dtgvThongKePn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongKePn.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvThongKePn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKePn.Location = new System.Drawing.Point(0, 61);
            this.dtgvThongKePn.Name = "dtgvThongKePn";
            this.dtgvThongKePn.Size = new System.Drawing.Size(558, 266);
            this.dtgvThongKePn.TabIndex = 4;
            // 
            // btnThongKePn
            // 
            this.btnThongKePn.Location = new System.Drawing.Point(244, 32);
            this.btnThongKePn.Name = "btnThongKePn";
            this.btnThongKePn.Size = new System.Drawing.Size(75, 23);
            this.btnThongKePn.TabIndex = 3;
            this.btnThongKePn.Text = "Thống kê";
            this.btnThongKePn.UseVisualStyleBackColor = true;
            this.btnThongKePn.Click += new System.EventHandler(this.btnThongKePn_Click);
            // 
            // nmThang
            // 
            this.nmThang.Location = new System.Drawing.Point(277, 6);
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
            this.nmThang.Size = new System.Drawing.Size(42, 20);
            this.nmThang.TabIndex = 2;
            this.nmThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbTongTienBan);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông kê hóa đơn bán";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txbTongTienBan
            // 
            this.txbTongTienBan.ForeColor = System.Drawing.Color.Red;
            this.txbTongTienBan.Location = new System.Drawing.Point(447, 336);
            this.txbTongTienBan.Name = "txbTongTienBan";
            this.txbTongTienBan.Size = new System.Drawing.Size(103, 20);
            this.txbTongTienBan.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(247, 0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(373, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2018, 9, 26, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(564, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thống kê";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKePn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmThang)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvThongKePn;
        private System.Windows.Forms.Button btnThongKePn;
        private System.Windows.Forms.NumericUpDown nmThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTongTienBan;
        private System.Windows.Forms.Label label3;

    }
}