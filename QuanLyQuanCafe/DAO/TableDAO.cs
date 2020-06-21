using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance
        {
            get {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance; }
           private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 50;
        public static int TableHight = 60;
        public TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("GetTableList");

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public bool InsertBanAn(string tenBan,string khuVuc,string mieuTa)
        {
            string query = "EXEC insertTable @tenBan , @khuVuc , @mieuTa";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {tenBan, khuVuc, mieuTa});

            return result > 0;
        }
        public bool UpdateBanAn(int maBan,string tenBan, string khuVuc, string mieuTa)
        {
            string query = string.Format("UPDATE dbo.BanAn SET TenBan = N'{0}',KhuVuc=N'{1}',MieuTa=N'{2}' WHERE MaBan={3}", tenBan, khuVuc, mieuTa,maBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBanAn(int maBan)
        {
            List<HoaDon> list = HoaDonDAO.Instance.LayMaHoaDonByBan(maBan);
            foreach(HoaDon item in list)
            {
                HoaDonChiTietDAO.Instance.DeleteBillInfoByMaHoaDon(item.MaHoaDon);
            }
            
            HoaDonDAO.Instance.DeleteBillByTable(maBan);
            string query = string.Format("DELETE dbo.BanAn WHERE maban = {0}",maBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
