using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
     public class HoaDonChiTietDAO
    {
        private static HoaDonChiTietDAO instance;

        public static HoaDonChiTietDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonChiTietDAO();
                return HoaDonChiTietDAO.instance;
            }
           private set { HoaDonChiTietDAO.instance = value; }
        }
        private HoaDonChiTietDAO() { }

       public List<HoaDonChiTiet> LayHoaDonChiTiet(int maHoaDon)
        {
            List<HoaDonChiTiet> listHoaDonChiTiet = new List<HoaDonChiTiet>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SECLET * FROM dbo.HoaDonChiTiet WHERE MaHoaDon =" +maHoaDon);
           foreach(DataRow item in data.Rows)
           {
               HoaDonChiTiet chiTiet = new HoaDonChiTiet(item);
               listHoaDonChiTiet.Add(chiTiet);
           }
            return listHoaDonChiTiet;
        }
       public bool InsertBillInfo(int maHoaDon, int maTAU, int soLuong)
       {
          int result = DataProvider.Instance.ExecuteNonQuery("InsertBillInfo @maHoaDon , @maTAU , @soLuong", new object[] { maHoaDon, maTAU, soLuong });
            return result > 0;
        }
     
        public void DeleteBillInfoByMaHoaDon(int maHoaDon)
       {
           string query = "DELETE dbo.HoaDonChiTiet WHERE MaHoaDon = " + maHoaDon;
           DataProvider.Instance.ExecuteQuery(query);
       }
       public void DeleteBillInfoByMaTAU(int maTAU)
       {
           string query = "DELETE dbo.HoaDonChiTiet WHERE MaTAU = " + maTAU;
           DataProvider.Instance.ExecuteQuery(query);
       }

    }
}
