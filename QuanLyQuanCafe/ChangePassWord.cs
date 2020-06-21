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
    public partial class ChangePassWord : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public ChangePassWord(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }
        public ChangePassWord() { }
        #region Pain
        private void VeHinh(Graphics g, Rectangle rect)
        {
            Image img = Properties.Resources.coffeeBaner;
            g.DrawImage(img, rect);
        }
        private void VeChu(Graphics g, Rectangle rect)
        {
            Font font = new Font("Arial", 12);
            Color color = Color.Honeydew;
            SolidBrush br = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Near;
            g.DrawString(this.Text, font, br, rect, format);
        }
        private void ChangePassWord_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ChangePassWord_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }
        #endregion
        #region Account
        void ChangeAccount(Account acc)
        {
            txbTenDangNhap.Text = loginAccount.TenTaiKhoan;
            txbTenHienThi.Text = loginAccount.TenHienThi;
        }
        #endregion
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool UpdateAccount(string tenTaiKhoan, string tenHienThi, string passWord, string newPass, string nhapLai)
        {
            if (AccountDAO.Instance.AccountByUser(tenTaiKhoan) == null)
            {
                MessageBox.Show("Tài khoản không tồn tại !!");
                try
                {
                    txbTenHienThi.Clear();
                    txbMatKhau.Clear();
                    txbMatKhauMoi.Clear();
                    txbNhapLai.Clear();
                    txbTenDangNhap.Clear();
                }
                catch { }
                return false;
            }
            else
            {
                if (!newPass.Equals(nhapLai))
                {
                    MessageBox.Show("Mật khẩu không trùng nhau. Vui lòng nhập lại");
                    return false;
                }
                else
                {
                    if (AccountDAO.Instance.UpdateAccount(tenTaiKhoan, tenHienThi, passWord, newPass))
                    {
                        MessageBox.Show("Cập nhập thành công");
                        if (updateAccount != null)
                            updateAccount(this, new AccountEvent(AccountDAO.Instance.AccountByUser(tenTaiKhoan)));
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đúng mật khẩu");
                        return false;
                    }
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> LoadUpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string tenHienThi = txbTenHienThi.Text;
            string passWord = txbMatKhau.Text;
            string newPass = txbMatKhauMoi.Text;
            string nhapLai = txbNhapLai.Text;
            string tenTaiKhoan = txbTenDangNhap.Text;
            UpdateAccount(tenTaiKhoan, tenHienThi, passWord, newPass, nhapLai);
        }
        public class AccountEvent:EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc )
            {
                this.Acc = acc;
            }
        }

      
    }
}
