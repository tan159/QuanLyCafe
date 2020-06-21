using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class CaLamDAO
    {
        private static CaLamDAO instance;

        internal static CaLamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaLamDAO();
                return CaLamDAO.instance;
            }
            private set { CaLamDAO.instance = value; }
        }
        private CaLamDAO() { }

        public List<CaLam> CaLam()
        {
            List<CaLam> listCaLam= new List<CaLam>();
            string query = "SELECT * FROM dbo.CaLamViec";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CaLam caLam = new CaLam(item);
                listCaLam.Add(caLam);
            }

            return listCaLam;
        }
        public CaLam LayCaLamByMa(int maCa)
        {
            CaLam CaLam = null;
            string query = "SELECT * FROM dbo.CaLamViec WHERE MaCa =" + maCa;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CaLam = new CaLam(item);
                return CaLam;
            }
            return CaLam;
        }

        public bool InsertCaLam(string loaiCa)
        {
            string query = string.Format("INSERT dbo.CaLamViec(loaiCa) VALUES (N'{0}')",loaiCa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCaLam(int maCa, string loaiCa)
        {
            string query = string.Format("UPDATE dbo.CaLamViec SET loaiCa =N'{0}' WHERE maCa={1}",  loaiCa, maCa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCaLam(int maCa)
        {
            ChamCongDAO.Instance.DeleteChamCongByCa(maCa);
            string query = string.Format("DELETE dbo.CaLamViec WHERE maCa={0}",  maCa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
