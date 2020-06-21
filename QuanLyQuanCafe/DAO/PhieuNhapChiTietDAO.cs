using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class PhieuNhapChiTietDAO
    {
        private static PhieuNhapChiTietDAO instance;

        public static PhieuNhapChiTietDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapChiTietDAO();
                return PhieuNhapChiTietDAO.instance;
            }
           private set { PhieuNhapChiTietDAO.instance = value; }
        }
        private PhieuNhapChiTietDAO() { }

       public List<PhieuNhapChiTiet> PhieuNhapChiTietByMa(int maPhieuNhap)
        {
            List<PhieuNhapChiTiet> listPhieuNhapChiTiet = new List<PhieuNhapChiTiet>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SECLET * FROM dbo.PhieuNhapChiTiet WHERE MaPhieuNhap =" +maPhieuNhap);
           foreach(DataRow item in data.Rows)
           {
               PhieuNhapChiTiet chiTiet = new PhieuNhapChiTiet(item);
               listPhieuNhapChiTiet.Add(chiTiet);
           }
            return listPhieuNhapChiTiet;
        }
       public void InsertBillInfo(int maPhieuNhap, int maTAU, int soLuong)
       {
           DataProvider.Instance.ExecuteNonQuery("InsertPhieuNhapChiTiet @maPhieuNhap , @maNL , @soLuong", new object[] { maPhieuNhap, maTAU, soLuong });
       }
       public void DeleteBillInfoBymaPhieuNhap(int maPhieuNhap)
       {

           string query = "DELETE dbo.PhieuNhapChiTiet WHERE MaPhieuNhap = " + maPhieuNhap;
           DataProvider.Instance.ExecuteQuery(query);
       }
       public void DeleteBillInfoByMaNL(int maNL)
       {
           string query = "DELETE dbo.PhieuNhapChiTiet WHERE MaNL = " + maNL;
           DataProvider.Instance.ExecuteQuery(query);
       }
    }
}
