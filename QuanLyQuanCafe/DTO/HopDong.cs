using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HopDong
    {
        public HopDong(int maHopDong,int maNV,int maChucVu,DateTime ngayVaoLam,DateTime ngayKetThuc,float luong)
        {
            this.MaHopDong = maHopDong;
            this.MaNV = maNV;
            this.MaChucVu = maChucVu;
            this.NgayVaoLam = ngayVaoLam;
            this.NgayKetThuc = ngayKetThuc;
            this.Luong = luong;
        }
        public HopDong(DataRow row)
        {
            this.MaHopDong =(int)row["maHopDong"];
            this.MaNV = (int)row["maNV"];
            this.MaChucVu = (int)row["maChucVu"];
            this.NgayVaoLam = (DateTime)row["ngayVaoLam"];
            this.NgayKetThuc = (DateTime)row["ngayKetThuc"];
            this.Luong = (float)Convert.ToDouble(row["Luong"]);
        }
        private int maHopDong;

        public int MaHopDong
        {
            get { return maHopDong; }
            set { maHopDong = value; }
        }
        private int maNV;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngayVaoLam;

        public DateTime NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }
        private DateTime ngayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }
        private int maChucVu;

        public int MaChucVu
        {
            get { return maChucVu; }
            set { maChucVu = value; }
        }
        private float luong;

        public float Luong
        {
            get { return luong; }
            set { luong = value; }
        }

       
    }
}
