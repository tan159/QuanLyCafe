using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyQuanCafe
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
    {
        public fLogin()
        {
            InitializeComponent();
        }
        bool Login(String tenTaiKhoan, String passWord)
        {
            return AccountDAO.Instance.Login(tenTaiKhoan, passWord);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ", "Thông báo",
                MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbTenDangNhap.Text;
            string passWord = txbPassWord.Text;
            CheckLogin(tenTaiKhoan, passWord);
        }
        public bool CheckLogin(string tenTaiKhoan, string passW)
        {
            if (Login(tenTaiKhoan,passW))
            {
                Account loginAccount = AccountDAO.Instance.AccountByUser(tenTaiKhoan);
                fManager f = new fManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản và mật khẩu");
                return false;
            }
        }
        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }

        private void txbTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }

        private void txbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }


    }
}
