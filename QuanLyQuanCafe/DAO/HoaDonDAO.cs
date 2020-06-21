using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO()
        {
           
        }
       public int LayHoaDonTuMaBan(int maBan)
        {
           DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HoaDon WHERE MaBan = " + maBan +  "AND TrangThai = 0");
           if(data.Rows.Count > 0)
           {
               HoaDon hoaDon = new HoaDon(data.Rows[0]);
               return hoaDon.MaHoaDon;
           }
           return -1;
       }
       public List<HoaDon> LayMaHoaDonByBan(int maBan)
       {
           List<HoaDon> listHoaDon = new List<HoaDon>();
           string query = "SELECT * FROM dbo.HoaDon WHERE MaBan=" + maBan ;
           DataTable data = DataProvider.Instance.ExecuteQuery(query);
           foreach (DataRow item in data.Rows)
           {
               HoaDon hoaDon = new HoaDon(item);
               listHoaDon.Add(hoaDon);
           }

           return listHoaDon;
       }
       public List<HoaDon> LayMaHoaDonByNV(int maNV)
       {
           List<HoaDon> listHoaDon = new List<HoaDon>();
           string query = "SELECT * FROM dbo.HoaDon WHERE MaNV=" + maNV;
           DataTable data = DataProvider.Instance.ExecuteQuery(query);
           foreach (DataRow item in data.Rows)
           {
               HoaDon hoaDon = new HoaDon(item);
               listHoaDon.Add(hoaDon);
           }

           return listHoaDon;
       }
       public List<HoaDon> LayHoaDon(int maBan)
       {
           List<HoaDon> listHoaDon = new List<HoaDon>();
           string query = "SELECT * FROM dbo.HoaDon as hd ,dbo.BanAn as ba WHERE hd.MaBan="+maBan+" AND ba.TrangThai = N'Có người' AND hd.TrangThai = 0";
           DataTable data = DataProvider.Instance.ExecuteQuery(query);
           foreach (DataRow item in data.Rows)
           {
               HoaDon hoaDon = new HoaDon(item);
               listHoaDon.Add(hoaDon);
           }

           return listHoaDon;
       }

       
       public void checkOut(int maHoaDon,float tongTien)
       {
           string query = "UPDATE dbo.HoaDon SET TrangThai = 1, ThoiDiemRa =GETDATE(),TongTien = "+ tongTien +" WHERE MaHoaDon =" + maHoaDon;
           DataProvider.Instance.ExecuteNonQuery(query);
       }
       public bool InsertBill(int maBan, int maNV)
       {
         int result =  DataProvider.Instance.ExecuteNonQuery("InsertBill @MaNV , @MaBan", new object[] { maBan, maNV });
            return result > 0;
        }
       public bool UpdateGiamGia(float donGia, int maHoaDon)
       {
           string query = string.Format("UPDATE dbo.HoaDon SET GiamGia={0} WHERE MaHoaDon = {1}", donGia, maHoaDon);
           int result = DataProvider.Instance.ExecuteNonQuery(query);

           return result > 0;
       }
       public int GetMaxMaHoaDon()
       {
           try
           {
               return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(MaHoaDon) FROM dbo.HoaDon");
           }
           catch
           {
               return 1;
           }
       }
       public void DeleteBillByTable(int maBan)
       {
           string query = "DELETE dbo.HoaDon WHERE MaBan = " + maBan;
           DataProvider.Instance.ExecuteQuery(query);
       }
       public void DeleteBillByNV(int maNV)
       {
           string query = "DELETE dbo.HoaDon WHERE MaNV = " + maNV;
           DataProvider.Instance.ExecuteQuery(query);
       }

        public DataTable ThongKeBill(DateTime checkIn,DateTime checkOut)
       {
          return DataProvider.Instance.ExecuteQuery("EXEC ThongKeBill @checkin , @checkout ", new object[] { checkIn, checkOut });
       }
        

    }
}
