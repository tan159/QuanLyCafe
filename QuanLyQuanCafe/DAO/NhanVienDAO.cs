using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return NhanVienDAO.instance;
            }
            private set { NhanVienDAO.instance = value; }
        }
        private NhanVienDAO() { }
        public List<NhanVien> LayNhanVien()
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();
            string query = "SELECT * FROM dbo.NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien danhmuc = new NhanVien(item);
                listNhanVien.Add(danhmuc);
            }

            return listNhanVien;
        }

        public NhanVien LayNhanVienByMa(int maNV)
        {
            NhanVien nhanVien = null;
            string query = "SELECT * FROM dbo.NhanVien WHERE MaNV =" + maNV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nhanVien = new NhanVien(item);
                return nhanVien;
            }

            return nhanVien;
        }
        public bool InsertNhanVien(string HoNV,string TenNV ,string	NgaySinh,string GioiTinh , string DiaChi ,string SDT ,string Email)
        {
            string query = string.Format("INSERT dbo.NhanVien(HoNV,TenNV,NgaySinh,GioiTinh,DiaChi,SDT,Email) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", HoNV, TenNV ,NgaySinh, GioiTinh ,  DiaChi , SDT , Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateNhanVien(int maNV, string HoNV, string TenNV, string NgaySinh, string GioiTinh, string DiaChi, string SDT, string Email)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET  HoNV = N'{0}' ,  TenNV= N'{1}',  NgaySinh= N'{2}',  GioiTinh= N'{3}',  DiaChi= N'{4}',  SDT= N'{5}',  Email= N'{6}' WHERE MaNV={7}",  HoNV, TenNV, NgaySinh, GioiTinh, DiaChi, SDT, Email,maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteNhanVien(int maNV)
        {
            List<HoaDon> listNV = HoaDonDAO.Instance.LayMaHoaDonByNV(maNV);
            foreach (HoaDon item in listNV)
            {
                HoaDonChiTietDAO.Instance.DeleteBillInfoByMaHoaDon(item.MaHoaDon);
            }
            List<PhieuNhap> listPhieuNhap = PhieuNhapDAO.Instance.PhieuNhayByMaNV(maNV);
            foreach (PhieuNhap item in listPhieuNhap)
            {
                PhieuNhapChiTietDAO.Instance.DeleteBillInfoBymaPhieuNhap(item.MaPhieuNhap);
            }
            HoaDonDAO.Instance.DeleteBillByNV(maNV);
            PhieuNhapDAO.Instance.DeleteBillByNV(maNV);
            ChamCongDAO.Instance.DeleteChamCongByNV(maNV);
            HoaDonDAO.Instance.DeleteBillByNV(maNV);
            string query = string.Format("DELETE dbo.NhanVien WHERE MaNV={0}", maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


    }
}
