using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class CaLam
    {   
        public  CaLam(int maCa,string loaiCa)
        {
            this.MaCa = maCa;
            this.LoaiCa = loaiCa;
        }
        public CaLam(DataRow row)
        {
            this.MaCa =(int)row["maCa"];
            this.LoaiCa = row["loaiCa"].ToString();
        }
        private int maCa;

        public int MaCa
        {
            get { return maCa; }
            set { maCa = value; }
        }
        
        private string loaiCa;

        public string LoaiCa
        {
            get { return loaiCa; }
            set { loaiCa = value; }
        }
    }
}
