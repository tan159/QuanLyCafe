using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int MaBan, string TenBan,string TrangThai, string KhuVuc,string mieuTa )
        {
            this.MaBan = MaBan;
            this.KhuVuc = KhuVuc;
            this.TenBan = TenBan;
            this.TrangThai = TrangThai;
            this.MieuTa = mieuTa;
        }

        public Table(DataRow row)
        {
            this.MaBan = (int)row["MaBan"];
            this.KhuVuc =row["KhuVuc"].ToString() ;
            this.TenBan =row["TenBan"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.MieuTa = row["MieuTa"].ToString();
        }

        private int maBan;

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        private string tenBan;

        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }
        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        private string mieuTa;

        public string MieuTa
        {
            get { return mieuTa; }
            set { mieuTa = value; }
        }
        private string khuVuc;

        public string KhuVuc
        {
            get { return khuVuc; }
            set { khuVuc = value; }
        } 
    }
}
