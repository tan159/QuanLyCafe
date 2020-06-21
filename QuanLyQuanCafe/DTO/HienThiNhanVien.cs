using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HienThiNhanVien
    {
        public HienThiNhanVien(int maNV, string hoNV, string tenNV, DateTime ngaySinh, string gioiTinh)
        {
            this.MaNV = maNV;
            this.HoNV = hoNV;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
        }
        public HienThiNhanVien(DataRow row)
        {
            this.MaNV = (int)row["maNV"];
            this.HoNV = row["hoNV"].ToString();
            this.TenNV = row["tenNV"].ToString();
            this.NgaySinh =(DateTime) row["ngaySinh"];
            this.GioiTinh =row["GioiTinh"].ToString();
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
    }
}
