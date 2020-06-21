namespace QuanLyQuanCafe
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbPassWord = new MetroFramework.Controls.MetroTextBox();
            this.txbTenDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.btnDangNhap);
            this.metroPanel1.Controls.Add(this.txbPassWord);
            this.metroPanel1.Controls.Add(this.txbTenDangNhap);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(292, 95);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(183, 67);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Login";
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyQuanCafe.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txbPassWord
            // 
            // 
            // 
            // 
            this.txbPassWord.CustomButton.Image = null;
            this.txbPassWord.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txbPassWord.CustomButton.Name = "";
            this.txbPassWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPassWord.CustomButton.TabIndex = 1;
            this.txbPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPassWord.CustomButton.UseSelectable = true;
            this.txbPassWord.CustomButton.Visible = false;
            this.txbPassWord.DisplayIcon = true;
            this.txbPassWord.Icon = ((System.Drawing.Image)(resources.GetObject("txbPassWord.Icon")));
            this.txbPassWord.Lines = new string[0];
            this.txbPassWord.Location = new System.Drawing.Point(153, 35);
            this.txbPassWord.MaxLength = 32767;
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '●';
            this.txbPassWord.PromptText = "Mật khẩu";
            this.txbPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassWord.SelectedText = "";
            this.txbPassWord.SelectionLength = 0;
            this.txbPassWord.SelectionStart = 0;
            this.txbPassWord.ShortcutsEnabled = true;
            this.txbPassWord.Size = new System.Drawing.Size(124, 26);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.UseSelectable = true;
            this.txbPassWord.UseSystemPasswordChar = true;
            this.txbPassWord.WaterMark = "Mật khẩu";
            this.txbPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassWord_KeyDown);
            // 
            // txbTenDangNhap
            // 
            // 
            // 
            // 
            this.txbTenDangNhap.CustomButton.Image = null;
            this.txbTenDangNhap.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txbTenDangNhap.CustomButton.Name = "";
            this.txbTenDangNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbTenDangNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTenDangNhap.CustomButton.TabIndex = 1;
            this.txbTenDangNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTenDangNhap.CustomButton.UseSelectable = true;
            this.txbTenDangNhap.CustomButton.Visible = false;
            this.txbTenDangNhap.DisplayIcon = true;
            this.txbTenDangNhap.Icon = ((System.Drawing.Image)(resources.GetObject("txbTenDangNhap.Icon")));
            this.txbTenDangNhap.Lines = new string[0];
            this.txbTenDangNhap.Location = new System.Drawing.Point(153, 3);
            this.txbTenDangNhap.MaxLength = 32767;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.PasswordChar = '\0';
            this.txbTenDangNhap.PromptText = "Tên đăng nhập";
            this.txbTenDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTenDangNhap.SelectedText = "";
            this.txbTenDangNhap.SelectionLength = 0;
            this.txbTenDangNhap.SelectionStart = 0;
            this.txbTenDangNhap.ShortcutsEnabled = true;
            this.txbTenDangNhap.Size = new System.Drawing.Size(124, 26);
            this.txbTenDangNhap.TabIndex = 0;
            this.txbTenDangNhap.UseSelectable = true;
            this.txbTenDangNhap.WaterMark = "Tên đăng nhập";
            this.txbTenDangNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTenDangNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTenDangNhap_KeyDown);
            // 
            // fLogin
            // 
            this.ClientSize = new System.Drawing.Size(332, 175);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "fLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLogin_KeyDown);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txbPassWord;
        private MetroFramework.Controls.MetroTextBox txbTenDangNhap;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

