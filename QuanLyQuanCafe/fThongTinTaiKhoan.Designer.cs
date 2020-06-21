namespace QuanLyQuanCafe
{
    partial class fThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongTinTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbID = new MetroFramework.Controls.MetroTextBox();
            this.txbPass = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmType = new System.Windows.Forms.NumericUpDown();
            this.txbTen = new MetroFramework.Controls.MetroTextBox();
            this.txbHienThi = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(179, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 53);
            this.panel1.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyQuanCafe.Properties.Resources.plus;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(78, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 25);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Add";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXem
            // 
            this.btnXem.Image = global::QuanLyQuanCafe.Properties.Resources.loading;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(3, 13);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(65, 25);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Refresh";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyQuanCafe.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(210, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 25);
            this.btnXoa.TabIndex = 6;
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
            this.btnSua.Location = new System.Drawing.Point(139, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 25);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Update";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvAccount);
            this.groupBox2.Location = new System.Drawing.Point(179, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 180);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 16);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(274, 161);
            this.dtgvAccount.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txbID);
            this.groupBox1.Controls.Add(this.txbPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmType);
            this.groupBox1.Controls.Add(this.txbTen);
            this.groupBox1.Controls.Add(this.txbHienThi);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 180);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txbID
            // 
            // 
            // 
            // 
            this.txbID.CustomButton.Image = null;
            this.txbID.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.txbID.CustomButton.Name = "";
            this.txbID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbID.CustomButton.TabIndex = 1;
            this.txbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbID.CustomButton.UseSelectable = true;
            this.txbID.CustomButton.Visible = false;
            this.txbID.DisplayIcon = true;
            this.txbID.Icon = global::QuanLyQuanCafe.Properties.Resources.id;
            this.txbID.Lines = new string[0];
            this.txbID.Location = new System.Drawing.Point(11, 19);
            this.txbID.MaxLength = 32767;
            this.txbID.Name = "txbID";
            this.txbID.PasswordChar = '\0';
            this.txbID.PromptText = "ID";
            this.txbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbID.SelectedText = "";
            this.txbID.SelectionLength = 0;
            this.txbID.SelectionStart = 0;
            this.txbID.ShortcutsEnabled = true;
            this.txbID.Size = new System.Drawing.Size(85, 23);
            this.txbID.TabIndex = 19;
            this.txbID.UseSelectable = true;
            this.txbID.WaterMark = "ID";
            this.txbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbPass
            // 
            // 
            // 
            // 
            this.txbPass.CustomButton.Image = null;
            this.txbPass.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txbPass.CustomButton.Name = "";
            this.txbPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPass.CustomButton.TabIndex = 1;
            this.txbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPass.CustomButton.UseSelectable = true;
            this.txbPass.CustomButton.Visible = false;
            this.txbPass.DisplayIcon = true;
            this.txbPass.Icon = ((System.Drawing.Image)(resources.GetObject("txbPass.Icon")));
            this.txbPass.Lines = new string[0];
            this.txbPass.Location = new System.Drawing.Point(11, 106);
            this.txbPass.MaxLength = 32767;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '●';
            this.txbPass.PromptText = "Password";
            this.txbPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPass.SelectedText = "";
            this.txbPass.SelectionLength = 0;
            this.txbPass.SelectionStart = 0;
            this.txbPass.ShortcutsEnabled = true;
            this.txbPass.Size = new System.Drawing.Size(144, 23);
            this.txbPass.TabIndex = 2;
            this.txbPass.UseSelectable = true;
            this.txbPass.UseSystemPasswordChar = true;
            this.txbPass.WaterMark = "Password";
            this.txbPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại tài khoản:";
            // 
            // nmType
            // 
            this.nmType.Location = new System.Drawing.Point(104, 135);
            this.nmType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmType.Name = "nmType";
            this.nmType.Size = new System.Drawing.Size(40, 20);
            this.nmType.TabIndex = 3;
            // 
            // txbTen
            // 
            // 
            // 
            // 
            this.txbTen.CustomButton.Image = null;
            this.txbTen.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txbTen.CustomButton.Name = "";
            this.txbTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTen.CustomButton.TabIndex = 1;
            this.txbTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTen.CustomButton.UseSelectable = true;
            this.txbTen.CustomButton.Visible = false;
            this.txbTen.DisplayIcon = true;
            this.txbTen.Icon = ((System.Drawing.Image)(resources.GetObject("txbTen.Icon")));
            this.txbTen.Lines = new string[0];
            this.txbTen.Location = new System.Drawing.Point(11, 77);
            this.txbTen.MaxLength = 32767;
            this.txbTen.Name = "txbTen";
            this.txbTen.PasswordChar = '\0';
            this.txbTen.PromptText = "Tên tài khoản";
            this.txbTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTen.SelectedText = "";
            this.txbTen.SelectionLength = 0;
            this.txbTen.SelectionStart = 0;
            this.txbTen.ShortcutsEnabled = true;
            this.txbTen.Size = new System.Drawing.Size(144, 23);
            this.txbTen.TabIndex = 1;
            this.txbTen.UseSelectable = true;
            this.txbTen.WaterMark = "Tên tài khoản";
            this.txbTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbHienThi
            // 
            // 
            // 
            // 
            this.txbHienThi.CustomButton.Image = null;
            this.txbHienThi.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txbHienThi.CustomButton.Name = "";
            this.txbHienThi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbHienThi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbHienThi.CustomButton.TabIndex = 1;
            this.txbHienThi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbHienThi.CustomButton.UseSelectable = true;
            this.txbHienThi.CustomButton.Visible = false;
            this.txbHienThi.DisplayIcon = true;
            this.txbHienThi.Icon = global::QuanLyQuanCafe.Properties.Resources.user;
            this.txbHienThi.Lines = new string[0];
            this.txbHienThi.Location = new System.Drawing.Point(11, 48);
            this.txbHienThi.MaxLength = 32767;
            this.txbHienThi.Name = "txbHienThi";
            this.txbHienThi.PasswordChar = '\0';
            this.txbHienThi.PromptText = "Tên hiển thị";
            this.txbHienThi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHienThi.SelectedText = "";
            this.txbHienThi.SelectionLength = 0;
            this.txbHienThi.SelectionStart = 0;
            this.txbHienThi.ShortcutsEnabled = true;
            this.txbHienThi.Size = new System.Drawing.Size(144, 23);
            this.txbHienThi.TabIndex = 0;
            this.txbHienThi.UseSelectable = true;
            this.txbHienThi.WaterMark = "Tên hiển thị";
            this.txbHienThi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbHienThi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyQuanCafe.Properties.Resources.window_cleaning;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(23, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fThongTinTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmType;
        private MetroFramework.Controls.MetroTextBox txbID;
        private MetroFramework.Controls.MetroTextBox txbPass;
        private MetroFramework.Controls.MetroTextBox txbTen;
        private MetroFramework.Controls.MetroTextBox txbHienThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
    }
}