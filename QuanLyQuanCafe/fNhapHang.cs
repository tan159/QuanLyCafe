using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fNhapHang : Form
    {
        public fNhapHang()
        {
            InitializeComponent();
            loadfNhapHang();
        }

        void loadfNhapHang()
        { 
            loadNhanVien();
            loadNguyenLieu();
            loadNCC();
            loadTime();
            showPhieuNhapChiTiet();        
        }
        void loadNhanVien()
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.LayNhanVien();
            cbNhanVien.DataSource = listNhanVien;
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
        }
        void loadNguyenLieu()
        {
            List<NguyenLieu> listNguyenLieu = NguyenLieuDAO.Instance.NguyenLieu();
            cbNguyenLieu.DataSource = listNguyenLieu;
            cbNguyenLieu.DisplayMember = "TenNL";
            cbNguyenLieu.ValueMember = "MaNL";
        }
        void loadNCC()
        {
            List<NhaCungCap> listNguyenLieu = NhaCungCapDAO.Instance.NhaCungCap();
            cbNCC.DataSource = listNguyenLieu;
            cbNCC.DisplayMember = "TenNhaCC";
            cbNCC.ValueMember = "MaNCC";
        }
        void loadTime()
        {
            this.dtNgayNhap.Value = DateTime.Now;
        }
        void showPhieuNhapChiTiet()
        {
            lsvBill.Items.Clear();
            float tongTien = 0;
            List<HienThiPhieuNhapChiTiet> listHoaDonChiTiet = HienThiHoaDonChiTietDAO.Instance.PhieuNhapChiTiet();

            foreach (HienThiPhieuNhapChiTiet item in listHoaDonChiTiet)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenNL.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonViTinh.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                tongTien += item.ThanhTien;

                lsvBill.Items.Add(lsvItem);

            }
            txbTongTien.Text = tongTien.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {         
            int maPhieu = PhieuNhapDAO.Instance.PhieuNhapByTrangThai();
            int maNV = (cbNhanVien.SelectedItem as NhanVien).MaNV;
            int soLuong = (int)nmSoLuong.Value;
            int maNCC = (cbNCC.SelectedItem as NhaCungCap).MaNCC;
            int maNL = (cbNguyenLieu.SelectedItem as NguyenLieu).MaNL;
            if (maPhieu == -1)
            {
                PhieuNhapDAO.Instance.InsertBill(maNCC, maNV);
                PhieuNhapChiTietDAO.Instance.InsertBillInfo(PhieuNhapDAO.Instance.GetMaxMaPhieuNhap(), maNL, soLuong);
            }
            else
            {
                PhieuNhapChiTietDAO.Instance.InsertBillInfo(maPhieu,maNL,soLuong);
            }
            txbMa.Text = maPhieu.ToString();
            showPhieuNhapChiTiet();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maPhieu = PhieuNhapDAO.Instance.PhieuNhapByTrangThai();
            txbMa.Text = maPhieu.ToString();
            float tongTien = (float)Convert.ToDouble(txbTongTien.Text);
            if (maPhieu != -1)
            {
                if (MessageBox.Show("Bạn có muốn thanh toán " , "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    PhieuNhapDAO.Instance.checkOut(maPhieu,tongTien);
                    showPhieuNhapChiTiet();       
                }
            }
        }
        #region Pain
        private void VeHinh(Graphics g, Rectangle rect)
        {
            Image img = Properties.Resources.coffeeBaner;
            g.DrawImage(img, rect);
        }
        private void VeChu(Graphics g, Rectangle rect)
        {
            Font font = new Font("Arial", 12);
            Color color = Color.Honeydew;
            SolidBrush br = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Near;
            g.DrawString(this.Text, font, br, rect, format);
        }

         private void fNhapHang_SizeChanged(object sender, EventArgs e)
        {
             Invalidate();
        }

        private void fNhapHang_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }

        
        #endregion
 

     
    }
}
