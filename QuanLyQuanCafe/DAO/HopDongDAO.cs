using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class HopDongDAO
    {
        private static HopDongDAO instance;

        internal static HopDongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HopDongDAO();
                return HopDongDAO.instance; }
            private set { HopDongDAO.instance = value; }
        }
        HopDongDAO() { }
        public List<HopDong> LayHopDong()
        {
            List<HopDong> listHopDong = new List<HopDong>();
            string query = "SELECT * FROM dbo.HopDong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HopDong hopDong = new HopDong(item);
                listHopDong.Add(hopDong);
            }

            return listHopDong;
        }
        public HopDong LayHopDongByMa(int maHopDong)
        {
            HopDong hopDong = null;
            string query = "SELECT * FROM dbo.HopDong WHERE MaHopDong =" + maHopDong;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                hopDong = new HopDong(item);
                return hopDong;
            }
            return hopDong;
        }
        public bool InsertHopDong(int maNV, int maChucVu,float luong,string ngayVaoLam,string ngayKetThuc)
        {
            string query = string.Format("INSERT dbo.HopDong(MaNV,MaChucVu,NgayVaoLam,NgayKetThuc,Luong) VALUES ({0},{1},'{2}','{3}',{4})", maNV, maChucVu,ngayVaoLam,ngayKetThuc,luong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateHopDong(int maNV, int maChucVu, float luong, string ngayVaoLam, string ngayKetThuc,int maHD)
        {
            string query = string.Format("UPDATE dbo.HopDong SET MaNV = {0},MaChucVu ={1},NgayVaoLam='{2}',NgayKetThuc='{3}',Luong = {4} WHERE MaHopDong={5}", maNV,  maChucVu,ngayVaoLam, ngayKetThuc,luong,maHD);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHopDongByMaChuc(int maChucVu)
        {
            string query = string.Format("Delete dbo.HopDong WHERE MaChucVu={0}",  maChucVu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHopDong(int maHopDong)
        {
            string query = string.Format("Delete dbo.HopDong WHERE MaHopDong={0}", maHopDong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHopDongByNV(int maNV)
        {
            string query = string.Format("Delete dbo.HopDong WHERE MaNV={0}", maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
