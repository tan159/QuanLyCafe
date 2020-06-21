using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyQuanCafe.DTO
{
    public class ThucAnUong
    {
        public ThucAnUong(int maTAU, string tenTAU,int maDanhMuc,float donGia,float giamGia,string mieuTa,string hinhAnh)
        {
            this.MaTAU = maTAU;
            this.TenTAU = tenTAU;
            this.MaDanhMuc = maDanhMuc;
            this.DonGia = donGia;
            this.GiamGia = giamGia;
            this.MieuTa = mieuTa;
            this.HinhAnh = hinhAnh;
        }
        public ThucAnUong(DataRow row)
        {
            this.MaTAU =(int)row["MaTAU"];
            this.TenTAU = row["TenTAU"].ToString();
            this.MaDanhMuc = (int)row["MaDanhMuc"];
            this.DonGia = (float)Convert.ToDouble(row["DonGia"].ToString());
            this.GiamGia = (float)Convert.ToDouble(row["GiamGia"].ToString());
            this.MieuTa = row["MieuTa"].ToString();
            this.HinhAnh = row["HinhAnh"].ToString();
        
        }
        private string mieuTa;

        public string MieuTa
        {
            get { return mieuTa; }
            set { mieuTa = value; }
        }
        private float giamGia;

        public float GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        private int maTAU;

        public int MaTAU
        {
            get { return maTAU; }
            set { maTAU = value; }
        }
        private string tenTAU;

        public string TenTAU
        {
            get { return tenTAU; }
            set { tenTAU = value; }
        }
        private int maDanhMuc;

        public int MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }
        private float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private string hinhAnh;
        public string HinhAnh
        {
          get { return hinhAnh; }
          set { hinhAnh = value; }
        }
        private Image Picture
        {
            get 
            { 
                if(!string.IsNullOrEmpty(HinhAnh))
                { 
                    if(File.Exists(HinhAnh))
                        return Image.FromFile(HinhAnh);
                }
                return null;
            }
        }
    }
}
