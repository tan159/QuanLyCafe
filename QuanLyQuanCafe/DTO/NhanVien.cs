using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
     public class  NhanVien
    {
        public NhanVien(int maNV, string hoNV, string tenNV, DateTime ngaySinh,string gioiTinh,string diaChi,string email,string sdt)
        {
            this.MaNV = maNV;
            this.HoNV = hoNV;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Email = email;
            this.Sdt = sdt;
        }

        public NhanVien(DataRow row)
        {
            this.MaNV =(int)row["MaNV"];
            this.HoNV = row["hoNV"].ToString();
            this.TenNV = row["tenNV"].ToString();
            this.NgaySinh =(DateTime) row["ngaySinh"];
            this.GioiTinh = row["gioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Email =row["email"].ToString();
            this.Sdt =row["sdt"].ToString();
        }
        private int maNV;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string hoNV;

        public string HoNV
        {
            get { return hoNV; }
            set { hoNV = value; }
        }
        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
