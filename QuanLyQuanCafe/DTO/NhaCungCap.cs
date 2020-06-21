using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap(int maNCC,string tenNhaCC,string phone,string email,string diaChi)
        {
            this.MaNCC = maNCC;
            this.TenNhaCC = tenNhaCC;
            this.Phone = phone;
            this.Email = email;
            this.DiaChi = diaChi;
        }
        public NhaCungCap(DataRow row)
        {
            this.MaNCC = (int)row["maNCC"];
            this.TenNhaCC = row["tenNhaCC"].ToString();
            this.Phone = row["phone"].ToString();
            this.Email =row["email"].ToString();
            this.DiaChi = row["diaChi"].ToString();
        }

        private int maNCC;

        public int MaNCC
        {
          get { return maNCC; }
          set { maNCC = value; }
        }
                private string tenNhaCC;

        public string TenNhaCC
        {
          get { return tenNhaCC; }
          set { tenNhaCC = value; }
        }
                private string phone;

        public string Phone
        {
          get { return phone; }
          set { phone = value; }
        }
                private string email;

        public string Email
        {
          get { return email; }
          set { email = value; }
        }
                private string diaChi;

        public string DiaChi
        {
          get { return diaChi; }
          set { diaChi = value; }
        }
    }
}
