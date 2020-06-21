using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class NguyenLieuDAO
    {
        private static NguyenLieuDAO instance;

        internal static NguyenLieuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NguyenLieuDAO();
                return NguyenLieuDAO.instance;
            }
            private set { NguyenLieuDAO.instance = value; }
        }
        private NguyenLieuDAO() { }

        public List<NguyenLieu> NguyenLieu()
        {
            List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
            string query = "SELECT * FROM dbo.NguyenLieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NguyenLieu NguyenLieu = new NguyenLieu(item);
                listNguyenLieu.Add(NguyenLieu);
            }

            return listNguyenLieu;
        }
        public bool InsertNguyenLieu(string tenNL, float donGia, string mieuTa, string donViTinh)
        {
            string query = string.Format("INSERT dbo.NguyenLieu(TenNL,DonGia,MieuTa,DonViTinh) VALUES (N'{0}',{1},N'{2}',N'{3}')", tenNL, donGia, mieuTa, donViTinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateNguyenLieu(int maNL, string tenNL, float donGia, string mieuTa, string donViTinh)
        {
            string query = string.Format("UPDATE dbo.NguyenLieu SET TenNL=N'{0}',DonGia={1},MieuTa=N'{2}',DonViTinh=N'{3}' WHERE MaNL = {4}", tenNL, donGia, mieuTa, donViTinh, maNL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteNguyenLieu(int maNL)
        {
            PhieuNhapChiTietDAO.Instance.DeleteBillInfoByMaNL(maNL);
            string query = string.Format("DELETE dbo.NguyenLieu WHERE MaNL = {0}", maNL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
