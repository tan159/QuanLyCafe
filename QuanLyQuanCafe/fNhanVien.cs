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
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
            LoadfNhanVien();
            this.UpdateNV += FNhanVien_UpdateNV;
            this.DeleteNV += FNhanVien_DeleteNV;
            this.InsertNV += FNhanVien_InsertNV;
        }

        private void FNhanVien_InsertNV(object sender, EventArgs e)
        {
            LoadNV();
            LoadMaNVVaoCmb(cbMaNV);
        }

        private void FNhanVien_DeleteNV(object sender, EventArgs e)
        {
            LoadNV();
            LoadMaNVVaoCmb(cbMaNV);
        }

        private void FNhanVien_UpdateNV(object sender, EventArgs e)
        {
            LoadNV();
            LoadMaNVVaoCmb(cbMaNV);
        }

        void LoadfNhanVien()
        {
            loadHopDong();
            LoadNV();
            LoadMaNVVaoCmb(cbMaNV);
            LoadChucVuVaoCmb(cmbChucVu);
            BindingHD();
            BindingNV();
        }
        void LoadMaNVVaoCmb(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.LayNhanVien();
            cb.DisplayMember = "MaNV";
        }
        void LoadChucVuVaoCmb(ComboBox cb)
        {
            cb.DataSource = ChucVuDAO.Instance.ChucVu();
            cb.DisplayMember = "TenChucVu";
        }
        BindingSource bindingHopDong = new BindingSource();
        void loadHopDong()
        {
            bindingHopDong.DataSource = HopDongDAO.Instance.LayHopDong();
            dtgvHopDong.DataSource = bindingHopDong;
        }
        void BindingHD()
        {
            txbHD.DataBindings.Add(new Binding("Text", dtgvHopDong.DataSource, "MaHopDong"));
            txbLuong.DataBindings.Add(new Binding("Text", dtgvHopDong.DataSource, "Luong"));
            dtpNgayVaoLam.DataBindings.Add(new Binding("Text", dtgvHopDong.DataSource, "NgayVaoLam"));
            dtpNgayKetThuc.DataBindings.Add(new Binding("Text", dtgvHopDong.DataSource, "NgayKetThuc"));
        }
        void BindingNV()
        {
            txbMaNV.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "MaNV"));
            txbHoNV.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "HoNV"));
            txbTenNV.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "TenNV"));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "NgaySinh"));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "GioiTinh"));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "DiaChi"));
            txbSDT.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "SDT"));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvDanhSachNV.DataSource, "Email"));
        }
        BindingSource bindingNhanVien = new BindingSource();
        void LoadNV()
        {
            bindingNhanVien.DataSource = NhanVienDAO.Instance.LayNhanVien();
            dtgvDanhSachNV.DataSource = bindingNhanVien;
        }

        void LoadHoTen(int maNV)
        {
            NhanVien nhanVien = NhanVienDAO.Instance.LayNhanVienByMa(maNV);
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.LayNhanVien();
            foreach(NhanVien item in listNhanVien)
            {
                if (item.HoNV == nhanVien.HoNV && item.TenNV == nhanVien.TenNV)
                {
                    txbTen.Text = item.TenNV;
                    txbHo.Text = item.HoNV;
                }
            }
                 
        }
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNV= 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            NhanVien selected = cb.SelectedItem as NhanVien;
            maNV = selected.MaNV;
            LoadHoTen(maNV);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            loadHopDong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(txbMaNV.Text);
            string hoNV = txbHoNV.Text;
            string tenNV = txbTenNV.Text;
            string ngaySinh = dtpNgaySinh.Value.Date.ToString("yyyy-MM-dd");
            string gioiTinh = cbGioiTinh.Text;
            string diaChi = txbDiaChi.Text;
            string sDT = txbSDT.Text;
            string email = txbEmail.Text;
            if (NhanVienDAO.Instance.UpdateNhanVien(maNV,hoNV,tenNV,ngaySinh,gioiTinh,diaChi,sDT,email))
            {
                MessageBox.Show("Sửa thành công");
                if (updateNV != null)
                    updateNV(this, new EventArgs());
                LoadNV();
            }
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            int maHD = Convert.ToInt32(txbHD.Text);
            int maNV =(cbMaNV.SelectedItem as NhanVien).MaNV;
            int maChucVu=(cmbChucVu.SelectedItem as ChucVu).MaChucVu;
            string ngayVaoLam = dtpNgayVaoLam.Value.Date.ToString("yyyy-MM-dd");
            string ngayKetThuc = dtpNgayKetThuc.Value.Date.ToString("yyyy-MM-dd");
            float luong = (float)Convert.ToDouble(txbLuong.Text); 

            if (HopDongDAO.Instance.UpdateHopDong(maNV,maChucVu,luong,ngayVaoLam,ngayKetThuc,maHD))
            {
                MessageBox.Show("Thêm thành công");
                loadHopDong();
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           string hoNV  = txbHoNV.Text;
           string tenNV = txbTenNV.Text;
	       string ngaySinh = dtpNgaySinh.Value.Date.ToString("yyyy-MM-dd");
           string gioiTinh = cbGioiTinh.Text;
           string diaChi = txbDiaChi.Text;
           string sDT = txbSDT.Text;
           string email = txbEmail.Text;
           if (NhanVienDAO.Instance.InsertNhanVien(hoNV,tenNV,ngaySinh,gioiTinh,diaChi,sDT,email))
           {
               MessageBox.Show("Thêm thành công");
                if (insertNV != null)
                    insertNV(this, new EventArgs());
                LoadNV();
           }
           else
               MessageBox.Show("Thêm không thành công");

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            int maNV = (cbMaNV.SelectedItem as NhanVien).MaNV;
            int maChucVu = (cmbChucVu.SelectedItem as ChucVu).MaChucVu;
            string ngayVaoLam = dtpNgayVaoLam.Value.Date.ToString("yyyy-MM-dd");
            string ngayKetThuc = dtpNgayKetThuc.Value.Date.ToString("yyyy-MM-dd");
            float luong = (float)Convert.ToDouble(txbLuong.Text);

            if (HopDongDAO.Instance.InsertHopDong(maNV, maChucVu, luong, ngayVaoLam, ngayKetThuc))
            {
                MessageBox.Show("Thêm thành công");
                loadHopDong();
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void txbHD_TextChanged(object sender, EventArgs e)
        {
            if (dtgvHopDong.SelectedCells.Count > 0) 
            {

                int maChucVu = (int)dtgvHopDong.SelectedCells[0].OwningRow.Cells["MaChucVu"].Value;
                int maNV = (int)dtgvHopDong.SelectedCells[0].OwningRow.Cells["MaNV"].Value;
                ChucVu chucVu = ChucVuDAO.Instance.LayChucVuByMa(maChucVu);
                NhanVien nhanVien = NhanVienDAO.Instance.LayNhanVienByMa(maNV);
                cmbChucVu.SelectedItem = chucVu;
                int index = -1;
                int i = 0;
                foreach (ChucVu item in cmbChucVu.Items)
                {
                    if (item.MaChucVu == chucVu.MaChucVu)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                int index1 = -1;
                int j = 0;
                foreach(NhanVien item in cbMaNV.Items)
                {
                    if (item.MaNV == nhanVien.MaNV )
                    {
                        index1 = j;
                        break;
                    }
                    j++;
                }
                cbMaNV.SelectedIndex = index1;
                cmbChucVu.SelectedIndex = index;
            }
        }

        private void btnThoatHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            int maHopDOng = Convert.ToInt32(txbHD.Text);
            if (HopDongDAO.Instance.DeleteHopDong(maHopDOng))
            {
                MessageBox.Show("Xóa thành công");
                loadHopDong();
            }
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(txbMaNV.Text);
            if (NhanVienDAO.Instance.DeleteNhanVien(maNV))
            {
                MessageBox.Show("Xóa thành công");
                if (deleteNV != null)
                    deleteNV(this, new EventArgs());
                LoadNV();

            }
            else
                MessageBox.Show("Xóa không thành công");
        }
        private event EventHandler insertNV;
        public event EventHandler InsertNV
        {
            add { insertNV += value; }
            remove { insertNV -= value; }
        }
        private event EventHandler deleteNV;
        public event EventHandler DeleteNV
        {
            add { deleteNV += value; }
            remove { deleteNV -= value; }
        }
        private event EventHandler updateNV;
        public event EventHandler UpdateNV
        {
            add { updateNV += value; }
            remove { updateNV -= value; }
        }
    }
}
