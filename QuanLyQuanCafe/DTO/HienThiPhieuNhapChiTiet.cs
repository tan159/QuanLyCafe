using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HienThiPhieuNhapChiTiet
    {
        public HienThiPhieuNhapChiTiet(  string tenNL,int soLuong,string donViTinh,float donGia,float thanhTien)
        {
            this.TenNL = tenNL;
            this.SoLuong = soLuong;
            this.DonViTinh = donViTinh;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }
        public HienThiPhieuNhapChiTiet(DataRow row)
        {
            this.TenNL =row["tenNL"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.DonViTinh = row["donViTinh"].ToString();
            this.DonGia = (float)Convert.ToDouble(row["donGia"]);
            this.ThanhTien = (float)Convert.ToDouble(row["thanhTien"]);
        }

        private string tenNL;

        public string TenNL
        {
          get { return tenNL; }
          set { tenNL = value; }
        }
                private int soLuong;

        public int SoLuong
        {
          get { return soLuong; }
          set { soLuong = value; }
        }
                private string donViTinh;

        public string DonViTinh
        {
          get { return donViTinh; }
          set { donViTinh = value; }
        }
                private float donGia;

        public float DonGia
        {
          get { return donGia; }
          set { donGia = value; }
        }
                private float thanhTien;

        public float ThanhTien
        {
          get { return thanhTien; }
          set { thanhTien = value; }
        }
    }
}
