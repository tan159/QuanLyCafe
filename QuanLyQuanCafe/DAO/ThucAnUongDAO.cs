using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class ThucAnUongDAO
    {
        private static ThucAnUongDAO instance;

        internal static ThucAnUongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThucAnUongDAO();
                return ThucAnUongDAO.instance;
            }
            private set { ThucAnUongDAO.instance = value; }
        }
        private ThucAnUongDAO() { }
        public List<ThucAnUong> LayThucAnUongByMa(int maDanhMuc)
        {
            List<ThucAnUong> listThucAnhUong = new List<ThucAnUong>();
            string query = "SELECT * FROM dbo.ThucAnUong WHERE MaDanhMuc = " + maDanhMuc;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThucAnUong thucanuong = new ThucAnUong(item);
                listThucAnhUong.Add(thucanuong);
            }

            return listThucAnhUong;

        }
    
        public List<ThucAnUong> LayThucAnUong()
        {
            List<ThucAnUong> listThucAnUong = new List<ThucAnUong>();
            string query = "SELECT * FROM dbo.ThucAnUong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThucAnUong ThucAnUong = new ThucAnUong(item);
                listThucAnUong.Add(ThucAnUong);
            }

            return listThucAnUong;
        }

        public List<ThucAnUong> SearchTaU(string foodName)
        {
            List<ThucAnUong> listThucAnUong = new List<ThucAnUong>();
            string query = "SearchFood @food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] {foodName});
            foreach (DataRow item in data.Rows)
            {
                ThucAnUong ThucAnUong = new ThucAnUong(item);
                listThucAnUong.Add(ThucAnUong);
            }

            return listThucAnUong;
        }
        public ThucAnUong CheckExistTAU(string tenTAU)
        {
            string query = "CheckTAU @tenTaU";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {tenTAU});
            foreach (DataRow item in result.Rows)
            {
                return new ThucAnUong(item);
            }
            return null;
        }
        public bool InsertThucAnUong(string tenTau,string hinhAnh,int maDanhMuc,float donGia,string mieuTa,float giamGia)
        {
            string query = string.Format("INSERT dbo.ThucAnUong(TenTAU,DonGia,MaDanhMuc,GiamGia,MieuTa,HinhAnh) VALUES (N'{0}',{1},{2},{3},N'{4}',N'{5}')" , tenTau , donGia , maDanhMuc , giamGia , mieuTa , hinhAnh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public void DeleteBillByDanhMuc(int maDanhMuc)
        {
            string query = "DELETE dbo.ThucAnUong WHERE MaDanhMuc = " + maDanhMuc;
            DataProvider.Instance.ExecuteQuery(query);
        }
        public bool UpdateThucAnUong(string tenTau, string hinhAnh, int maDanhMuc, float donGia, string mieuTa, float giamGia,int maTAU)
        {
            string query = string.Format("UPDATE dbo.ThucAnUong SET TenTAU=N'{0}', DonGia={1} , MaDanhMuc={2} , GiamGia={3}  ,MieuTa=N'{4}' , HinhAnh= N'{5}' WHERE MaTAU = {6}", tenTau, donGia, maDanhMuc, giamGia, mieuTa, hinhAnh,maTAU);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateGiamGia(float donGia,int maTAU)
        {
            string query = string.Format("UPDATE dbo.ThucAnUong SET GiamGia={0} WHERE MaTAU = {1}", donGia,maTAU);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTAU(int maTAU)
        {
            
            HoaDonChiTietDAO.Instance.DeleteBillInfoByMaTAU(maTAU);
            string query = string.Format("DELETE dbo.ThucAnUong WHERE MaTAU = {0}", maTAU);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
