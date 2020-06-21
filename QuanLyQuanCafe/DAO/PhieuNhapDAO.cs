using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public static PhieuNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapDAO();
                return PhieuNhapDAO.instance; }
            private set { PhieuNhapDAO.instance = value; }
        }
        private PhieuNhapDAO()
        {
           
        }
       public int PhieuNhapByTrangThai()
        {
           DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PhieuNhap WHERE TrangThai = 0");
           if(data.Rows.Count > 0)
           {
               PhieuNhap PhieuNhap = new PhieuNhap(data.Rows[0]);
               return PhieuNhap.MaPhieuNhap;
           }
           return -1;
       }
       public List<PhieuNhap> PhieuNhap()
       {
           List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();
           string query = "SELECT * FROM dbo.PhieuNhap";
           DataTable data = DataProvider.Instance.ExecuteQuery(query);
           foreach (DataRow item in data.Rows)
           {
               PhieuNhap PhieuNhap = new PhieuNhap(item);
               listPhieuNhap.Add(PhieuNhap);
           }

           return listPhieuNhap;
       }
       public List<PhieuNhap> PhieuNhayByMaNCC(int maNCC)
       {
           List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();
           string query = "SELECT * FROM dbo.PhieuNhap WHERE MaNCC=" + maNCC;
           DataTable data = DataProvider.Instance.ExecuteQuery(query);
           foreach (DataRow item in data.Rows)
           {
               PhieuNhap phieuNhap = new PhieuNhap(item);
               listPhieuNhap.Add(phieuNhap);
           }

           return listPhieuNhap;
       }
       public List<PhieuNhap> PhieuNhayByMaNV(int maNV)
       {
           List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();
           string query = "SELECT * FROM dbo.PhieuNhap WHERE MaNV=" + maNV;
           DataTable data = DataProvider.Instance.ExecuteQuery(query);
           foreach (DataRow item in data.Rows)
           {
               PhieuNhap phieuNhap = new PhieuNhap(item);
               listPhieuNhap.Add(phieuNhap);
           }

           return listPhieuNhap;
       }
       public void checkOut(int maPhieuNhap,float tongTien)
       {
           string query = "UPDATE dbo.PhieuNhap SET TrangThai = 1 ,TongTien = "+ tongTien +"WHERE MaPhieuNhap =" + maPhieuNhap;
           DataProvider.Instance.ExecuteNonQuery(query);
       }
       public void InsertBill(int maNCC, int maNV)
       {
           DataProvider.Instance.ExecuteNonQuery("InsertPhieuNhap @MaNCC , @MaNV", new object[] { maNCC, maNV });
       }
       public int GetMaxMaPhieuNhap()
       {
           try
           {
               return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(MaPhieuNhap) FROM dbo.PhieuNhap");
           }
           catch
           {
               return 1;
           }
       }
       public DataTable ThongKePhieuNhap(int thang)
       {
           return DataProvider.Instance.ExecuteQuery("EXEC ThongKePhieuNhapTheoThang @thang  ", new object[] { thang });
       }
       public void DeleteBillByNCC(int maNCC)
       {
           string query = "DELETE dbo.PhieuNhap WHERE MaNCC = " + maNCC;
           DataProvider.Instance.ExecuteQuery(query);
       }
       public void DeleteBillByNV(int maNV)
       {
           string query = "DELETE dbo.PhieuNhap WHERE MaNV = " + maNV;
           DataProvider.Instance.ExecuteQuery(query);
       }
    }
}
