using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ChamCongDAO
    {
        private static ChamCongDAO instance;

        internal static ChamCongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChamCongDAO();
                return ChamCongDAO.instance;
            }
            private set { ChamCongDAO.instance = value; }
        }
        private ChamCongDAO() { }
        public DataTable XemChamCong(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC XemChamCong @date ", new object[] { date });
        }
        public bool InsertCong(int maNV,int maCa,string ngayThang,string ghiChu)
        {
            string query = string.Format("INSERT dbo.ChamCongNV(maNV,maCa,ngayThang,ghiChu) VALUES ({0},{1},'{2}',N'{3}')", maNV, maCa, ngayThang, ghiChu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCong(int maNV, int maCa, string ngayThang, string ghiChu)
        {
            string query = string.Format("UPDATE dbo.ChamCongNV SET GhiChu =N'{0}' WHERE MaCa={1} AND MaNV ={2} AND NgayThang=N'{3}' ", ghiChu, maCa, maNV, ngayThang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCong(int maNV, int maCa, string ngayThang)
        {
            string query = string.Format("Delete dbo.ChamCongNV  WHERE MaCa={0} AND MaNV ={1} AND NgayThang=N'{2}' ", maCa, maNV, ngayThang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteChamCongByCa(int maCa)
        {
            string query = string.Format("DELETE dbo.ChamCongNV WHERE maCa={0}", maCa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteChamCongByNV(int maNV)
        {
            string query = string.Format("DELETE dbo.ChamCongNV WHERE maNV={0}", maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable ThongKeChamCong(int maCa,int thang)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC ThongKeChamCong @maCa , @thang ", new object[] { maCa, thang });
        }

    }
}
