using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDonChiTiet
    {
        public HoaDonChiTiet(int maHoaDon,int maTAU, int soLuong,int giamGia)
        {
            this.GiamGia = giamGia;
            this.MaHoaDon = maHoaDon;
            this.MaTAU = maTAU;
            this.SoLuong = soLuong;
        }
        public HoaDonChiTiet(DataRow row)
        {
         
        }
        private int maHoaDon;

        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        private int maTAU;

        public int MaTAU
        {
            get { return maTAU; }
            set { maTAU = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private int giamGia;

        public int GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

    }
}
