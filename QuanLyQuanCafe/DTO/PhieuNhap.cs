using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class PhieuNhap
    {
        public PhieuNhap(int maPhieuNhap,DateTime ngayNhap,int maNV,string moTa,int maNCC)
        {
             this.MaPhieuNhap = maPhieuNhap;
             this.NgayNhap =ngayNhap;
             this.MaNV = maNV;
             this.MoTa =moTa;
             this.MaNCC = maNCC;
        }
        public PhieuNhap(DataRow row)
        {
            this.MaPhieuNhap =(int)row["maPhieuNhap"];
            this.NgayNhap = (DateTime)row["ngayNhap"];
            this.MaNV =(int)row["maNV"];
            this.MoTa =row["moTa"].ToString();
            this.MaNCC = (int)row["maNCC"];
        }
        private int maPhieuNhap;

        public int MaPhieuNhap
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }
        private DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        private int maNV;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string moTa;

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        private int maNCC;

        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
    }
}
