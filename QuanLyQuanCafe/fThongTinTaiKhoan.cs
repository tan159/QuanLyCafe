using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fThongTinTaiKhoan : MetroFramework.Forms.MetroForm
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fThongTinTaiKhoan(Account acc)
        {
            InitializeComponent();
            loginAccount = acc;
            LoadAccountList();
        }
        public fThongTinTaiKhoan() { }
        #region Account
        void ChangeAccount(Account acc)
        {

        }
        #endregion
        BindingSource bindingAccount = new BindingSource();
        void LoadAccountList()
        {
            LoadAccount();
            BindingAccount();
        }

        void LoadAccount()
        {
            bindingAccount.DataSource = AccountDAO.Instance.Account();
            try { dtgvAccount.DataSource = bindingAccount; }
            catch { }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        void BindingAccount()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "IDAccount"));
            txbHienThi.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenHienThi"));
            txbPass.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "PassWord"));
            nmType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "LoaiTaiKhoan"));
            txbTen.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenTaiKhoan"));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbTen.Text;
            string tenHienThi = txbHienThi.Text;
            string pass = txbPass.Text;
            int type = (int)nmType.Value;
            if (String.IsNullOrEmpty(txbID.Text))
                MessageBox.Show("Không có gì để thay đổi");
            else
            {
                int id = Convert.ToInt32(txbID.Text);
                updateAccInDatabase(id, tenTaiKhoan, tenHienThi, pass, type);
            }
        }
        public bool updateAccInDatabase(int id, string tenTaiKhoan, string tenHienThi, string pass, int type)
        {
            if (tenTaiKhoan == "" || tenHienThi == "" || id <= -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ! Không được để trống ");
                return false;
            }
            else
            {
                Account accountTrung = AccountDAO.Instance.AccountByUser(tenTaiKhoan);

                if (accountTrung != null && accountTrung.IdAccount == id)
                {
                    if (AccountDAO.Instance.UpdateListAccount(id, accountTrung.TenTaiKhoan, tenHienThi, pass, type))
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadAccount();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                        return false;
                    }
                }
                if (accountTrung != null)
                {
                    MessageBox.Show("Tên muốn sửa đã có");
                    return false;
                }
                else
                {
                    if (AccountDAO.Instance.UpdateListAccount(id, tenTaiKhoan, tenHienThi, pass, type))
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadAccount();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                        return false;
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbID.Text))
                MessageBox.Show("Không có gì để thay đổi");
            else
            {
                int id = Convert.ToInt32(txbID.Text);
                DeleteAccount(id);
            }
        }
        public void DeleteAccount(int id)
        {
            try
            {
                if (loginAccount.IdAccount.Equals(id))
                {
                    MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
                    return;
                }
            }
            catch { }
            if (AccountDAO.Instance.DeleteAccount(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadAccount();
            }
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbTen.Text;
            string tenHienThi = txbHienThi.Text;
            int type = (int)nmType.Value;

            AddAccToDatabase(tenTaiKhoan, tenHienThi, type);
        }

        public bool AddAccToDatabase(string tenTaiKhoan, string tenHienThi, int type)
        {
            if (tenTaiKhoan == "" || tenHienThi == "") // sửa lỗi nhập giá trị null
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ! Không được để trống ");
                return false;
            }
            else
            {
                if (AccountDAO.Instance.AccountByUser(tenTaiKhoan) == null)
                {
                    if (AccountDAO.Instance.InsertAccount(tenTaiKhoan, tenHienThi, type))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadAccount();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại tên tài khoản " + tenTaiKhoan);
                    return false;
                }

            }
        }
        public int countAccount()
        {
            int a = AccountDAO.Instance.countAcc();
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txbHienThi.Clear();
            txbID.Clear();
            txbPass.Clear();
            txbTen.Clear();
        }
    }
}
