using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class NguyenLieu
    {
        public NguyenLieu(int maNL, string tenNL, float donGia, string mieuTa, string donViTinh)
        { 
             this.MaNL=   maNL ;
	         this.TenNL=tenNL ;
	         this.DonGia =donGia ;
	         this.MieuTa= mieuTa;
	         this.DonViTinh = donViTinh ;
        }
        public NguyenLieu(DataRow row)
        {
            this.MaNL =(int)row["MaNL"];
            this.TenNL = row["tenNL"].ToString();
            this.DonGia =(float)Convert.ToDouble(row["donGia"]);
            this.MieuTa = row["mieuTa"].ToString() ;
            this.DonViTinh = row["donViTinh"].ToString();
        }


        private int maNL;

        public int MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }
        private string tenNL;

        public string TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }
        private float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private string mieuTa;

        public string MieuTa
        {
            get { return mieuTa; }
            set { mieuTa = value; }
        }
        private string donViTinh;

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
    }
}
