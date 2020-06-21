using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class DanhMucDAO
    {
        private static DanhMucDAO instance;

        internal static DanhMucDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhMucDAO();
                return DanhMucDAO.instance;
            }
            private set { DanhMucDAO.instance = value; }
        }
        private DanhMucDAO()
        {

        }
        public List<DanhMuc> LayDanhMuc()
        {
            List<DanhMuc> listDanhMuc = new List<DanhMuc>();
            string query = "AllDanhMuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                DanhMuc danhmuc = new DanhMuc(item);
                listDanhMuc.Add(danhmuc);
            }
            return listDanhMuc;
        }
        public DanhMuc LayDanhMucByMaDanhMuc(int maDanhMuc)
        {
            DanhMuc danhMuc = null;
            string query = "DanhMucSearch @maDM";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { maDanhMuc });
            foreach (DataRow item in data.Rows)
            {
                 danhMuc = new DanhMuc(item);
                 return danhMuc;
            }
            return danhMuc;
        }
        public bool InsertDanhMuc(string tenDanhMuc)
        {
            string query = "InsertDanhMuc @tenDM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDanhMuc });

            return result > 0;
        }
        public bool UpdateDanhMuc(int maDanhMuc, string tenDanhMuc)
        {
            string query = "UpdateDanhMuc @maDanhMuc , @tenDanhMuc";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDanhMuc, tenDanhMuc });

            return result > 0;
        }
        public bool DeleteDanhMuc(int maDanhMuc)
        {
            List<ThucAnUong> list = ThucAnUongDAO.Instance.LayThucAnUongByMa(maDanhMuc);
            foreach(ThucAnUong item in list)
            {
                HoaDonChiTietDAO.Instance.DeleteBillInfoByMaTAU(item.MaTAU);
            }
            ThucAnUongDAO.Instance.DeleteBillByDanhMuc(maDanhMuc);
            string query = string.Format("DELETE dbo.DanhMuc WHERE MaDanhMuc = {0}", maDanhMuc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool CheckExist(string tenDanhMuc)
        {
            string query = "CheckDanhMuc @tenDanhMuc";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {tenDanhMuc});
            return result.Rows.Count > 0;
        }
    }
}
