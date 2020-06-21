using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        public Account(int idAccount,string tenHienThi,string tenTaiKhoan,int loaiTaiKhoan,string passWord = null)
        {
            this.TenHienThi = tenHienThi;
            this.TenTaiKhoan = tenTaiKhoan;
            this.PassWord = passWord;
            this.LoaiTaiKhoan = loaiTaiKhoan;
            this.IdAccount = idAccount;
        }
        public Account(DataRow row)
        {
            this.TenHienThi =row["TenHienThi"].ToString();
            this.TenTaiKhoan = row["TenTaiKhoan"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.LoaiTaiKhoan =(int)row["LoaiTaiKhoan"];
            this.IdAccount = (int)row["IDAccount"];
        }
        private int idAccount;

        public int IdAccount
        {
            get { return idAccount; }
            set { idAccount = value; }
        }
        private string tenHienThi;

        public string TenHienThi
        {
            get { return tenHienThi; }
            set { tenHienThi = value; }
        }
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private int loaiTaiKhoan;

        public int LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }
    }
}
