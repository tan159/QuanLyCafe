using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class PhieuNhapChiTiet
    {
        public PhieuNhapChiTiet(int maPhieuNhap,int maNL,int soLuong)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.MaNL = maNL;
            this.SoLuong = soLuong;
        }
        public PhieuNhapChiTiet(DataRow row)
        {
            this.MaPhieuNhap =(int)row["maPhieuNhap"];
            this.MaNL =(int)row[" maNL"];
            this.SoLuong = (int)row[" soLuong"];
        }
        private int maPhieuNhap;

        public int MaPhieuNhap
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }
        private int maNL;

        public int MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
