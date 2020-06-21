using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class HienThiNhanVienDAO
    {
        private static HienThiNhanVienDAO instance;

        public static HienThiNhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HienThiNhanVienDAO();
                return HienThiNhanVienDAO.instance;
            }
            private set { HienThiNhanVienDAO.instance = value; }
        }
        HienThiNhanVienDAO() { }

        public List<HienThiNhanVien> LayHoaDon()
        {
            List<HienThiNhanVien> listHoaDon = new List<HienThiNhanVien>();
            string query = "SELECT MaNV,HoNV,TenNV, NgaySinh, GioiTinh FROM dbo.NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HienThiNhanVien nhanVien = new HienThiNhanVien(item);
                listHoaDon.Add(nhanVien);
            }

            return listHoaDon;
        }
    }
}
