using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class HienThiHoaDonChiTietDAO
    {
        private static HienThiHoaDonChiTietDAO instance;

        public static HienThiHoaDonChiTietDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HienThiHoaDonChiTietDAO();
                return HienThiHoaDonChiTietDAO.instance;
            }
            private set { HienThiHoaDonChiTietDAO.instance = value; }
        }
        private HienThiHoaDonChiTietDAO() { }
        public List<HienThiHoaDonChiTiet> LayHoaDonChiTietTheoBan(int maBan) {

            List<HienThiHoaDonChiTiet> listHienThi = new List<HienThiHoaDonChiTiet>();
            string query = "SELECT  f.TenTAU ,bi.SoLuong ,f.DonGia ,f.GiamGia ,(f.DonGia - f.GiamGia)*bi.SoLuong as ThanhTien FROM dbo.ThucAnUong as f , dbo.HoaDon as b ,dbo.HoaDonChiTiet as bi WHERE bi.MaHoaDon = b.MaHoaDon AND bi.MaTAU = f.MaTAU AND b.TrangThai = 0 AND b.MaBan =" + maBan;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows )
            {
                HienThiHoaDonChiTiet chiTiet = new HienThiHoaDonChiTiet(item);
                listHienThi.Add(chiTiet);
            }
            return listHienThi;
        }
        public List<HienThiPhieuNhapChiTiet> PhieuNhapChiTiet()
        {

            List<HienThiPhieuNhapChiTiet> listHienThi = new List<HienThiPhieuNhapChiTiet>();
            string query = "SELECT f.TenNL ,bi.SoLuong ,f.DonGia ,f.DonGia*bi.SoLuong as ThanhTien ,f.DonViTinh FROM dbo.NguyenLieu as f , dbo.PhieuNhap as b ,dbo.PhieuNhapChiTiet as bi WHERE bi.MaPhieuNhap = b.MaPhieuNhap AND bi.MaNL = f.MaNL AND b.TrangThai = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HienThiPhieuNhapChiTiet chiTiet = new HienThiPhieuNhapChiTiet(item);
                listHienThi.Add(chiTiet);
            }
            return listHienThi;
        }

    }
}
