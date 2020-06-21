using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DanhMuc
    {
        public DanhMuc(int maDanhMuc,string tenDanhMuc)
        {
            this.MaDanhMuc = maDanhMuc;
            this.tenDanhMuc = tenDanhMuc;
        }
        public DanhMuc(DataRow row)
        {
            this.MaDanhMuc =(int)row["MaDanhMuc"];
            this.tenDanhMuc =row["TenDanhMuc"].ToString();
        }
        private int maDanhMuc;

        public int MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }
        private string tenDanhMuc;

        public string TenDanhMuc
        {
            get { return tenDanhMuc; }
            set { tenDanhMuc = value; }
        }
    }
}
