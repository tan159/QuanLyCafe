using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;

        internal static ChucVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChucVuDAO();
                return ChucVuDAO.instance;
            }
            private set { ChucVuDAO.instance = value; }
        }
        private ChucVuDAO() { }

        public List<ChucVu> ChucVu()
        {
            List<ChucVu> listChucVu= new List<ChucVu>();
            string query = "SELECT * FROM dbo.ChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChucVu chucVu = new ChucVu(item);
                listChucVu.Add(chucVu);
            }

            return listChucVu;
        }
        public ChucVu LayChucVuByMa(int maChucVu)
        {
            ChucVu chucVu = null;
            string query = "SELECT * FROM dbo.ChucVu WHERE MaChucVu =" + maChucVu;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                chucVu = new ChucVu(item);
                return chucVu;
            }
            return chucVu;
        }

        public bool InsertChucVu(string tenChucVu)
        {
            string query = string.Format("INSERT dbo.ChucVu(TenChucVu) VALUES (N'{0}')", tenChucVu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateChucVu(int maChucVu, string tenChucVu)
        {
            string query = string.Format("UPDATE dbo.ChucVu SET TenChucVu = N'{0}' WHERE maChucVu={1}", tenChucVu, maChucVu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteChucVu(int maChucVu)
        {
            HopDongDAO.Instance.DeleteHopDongByMaChuc(maChucVu);
            string query = string.Format("DELETE dbo.ChucVu WHERE maChucVu = {0}", maChucVu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
