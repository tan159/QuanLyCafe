using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDon
    {
        public HoaDon(int maHoaDon,DateTime thoiDiemVao,DateTime thoiDiemRa,int trangThai,int giamGia,int tienThua,int tienDua)
        {
            this.MaHoaDon = maHoaDon;
            this.ThoiDiemVao = thoiDiemVao;
            this.ThoiDiemRa = thoiDiemRa;
            this.TrangThai = trangThai;
            this.GiamGia = giamGia;
            this.TienDua = tienDua;
            this.TienThua = tienThua;
        }
        public HoaDon(DataRow row)
        {
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.ThoiDiemVao =(DateTime)row["thoiDiemVao"];
            if(thoiDiemRa.ToString() != "")
                this.ThoiDiemRa = (DateTime)thoiDiemRa;
            this.TrangThai =(int)row["TrangThai"];
            if (GiamGia.ToString() != "")
                this.GiamGia = (float)Convert.ToDouble(row["GiamGia"]);
            //if (TienDua.ToString() != "")
            //    this.TienDua = (int)row["tienDua"];
            //if (TienThua.ToString() != "")
            //    this.TienThua = (int)row["tienThua"];
        }
        private float giamGia;

        public float GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        private int maHoaDon;

        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        private DateTime thoiDiemVao;

        public DateTime ThoiDiemVao
        {
            get { return thoiDiemVao; }
            set { thoiDiemVao = value; }
        }
        private DateTime thoiDiemRa;

        public DateTime ThoiDiemRa
        {
            get { return thoiDiemRa; }
            set { thoiDiemRa = value; }
        }
        private int maBan;

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        private int maNV;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        private int tienThua;

        public int TienThua
        {
            get { return tienThua; }
            set { tienThua = value; }
        }

        private int tienDua;

        public int TienDua
        {
            get { return tienDua; }
            set { tienDua = value; }
        }
     
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

    }
}
