using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
     public class HienThiHoaDonChiTiet
    {
         public HienThiHoaDonChiTiet(string tenTAU,int soLuong,float donGia,float giamGia =0,float thanhTien =0)
         {
             this.TenTAU = tenTAU;
             this.SoLuong = soLuong;
             this.DonGia = donGia;
             this.GiamGia = giamGia;
             this.ThanhTien = thanhTien;
            
         }
         public HienThiHoaDonChiTiet(DataRow row)
         {
             this.TenTAU = row["tenTAU"].ToString();
             this.SoLuong =(int)row["soLuong"];
             this.DonGia =(float)Convert.ToDouble(row ["donGia"].ToString());
             this.GiamGia =(float)Convert.ToDouble(row ["giamGia"].ToString());
             this.ThanhTien = (float)Convert.ToDouble(row["thanhTien"].ToString());
             
        }

        private string tenTAU;

        public string TenTAU
        {
            get { return tenTAU; }
            set { tenTAU = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private float giamGia;

        public float GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        private float thanhTien;

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

   
    }
}
