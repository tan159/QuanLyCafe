using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class NhaCungCapDAO
    {
         private static NhaCungCapDAO instance;

        internal static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                return NhaCungCapDAO.instance;
            }
            private set { NhaCungCapDAO.instance = value; }
        }
        private NhaCungCapDAO() { }

        public List<NhaCungCap> NhaCungCap()
        {
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();
            string query = "SELECT * FROM dbo.NhaCungCap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhaCungCap NhaCungCap = new NhaCungCap(item);
                listNhaCungCap.Add(NhaCungCap);
            }

            return listNhaCungCap;
        }
        public bool InsertNhaCungCap(string tenNhaCC, string phone, string email, string diaChi)
        {
            string query = string.Format("INSERT dbo.NhaCungCap(tenNhaCC, phone, email, diaChi) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", tenNhaCC,  phone,  email,  diaChi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateNhaCungCap(int maNCC, string tenNhaCC, string phone, string email, string diaChi)
        {
            string query = string.Format("UPDATE dbo.NhaCungCap SET tenNhaCC=N'{0}',phone=N'{1}',email=N'{2}',diaChi=N'{3}' WHERE maNCC = {4}", tenNhaCC, phone, email, diaChi, maNCC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
     
        public bool DeleteNCC(int maNCC)
        {
            List<PhieuNhap> list = PhieuNhapDAO.Instance.PhieuNhayByMaNCC(maNCC);
            foreach (PhieuNhap item in list)
            {
                PhieuNhapChiTietDAO.Instance.DeleteBillInfoBymaPhieuNhap(item.MaPhieuNhap);
            }

            PhieuNhapDAO.Instance.DeleteBillByNCC(maNCC);
            string query = string.Format("DELETE dbo.NhaCungCap WHERE MaNCC = {0}", maNCC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
