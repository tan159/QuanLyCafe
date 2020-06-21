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
using System.Drawing.Imaging;

namespace QuanLyQuanCafe
{
    public partial class fManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set {
                loginAccount = value;
                ChangeAccount(LoginAccount.LoaiTaiKhoan);
            }
        }


        public fManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            LoadTable();
            LoadDanhMuc();
            LoadDanhMucGiam();
            LoadNV();
            

        }
        private void fManager_Load(object sender, EventArgs e)
        {
            this.UpdateFood += fManager_UpdateFood;
            this.InsertBill += FManager_InsertBill;
           
        }

        private void FManager_InsertBill(object sender, EventArgs e)
        {
            if (lsvBill.Tag != null)
                ShowHoaDon((lsvBill.Tag as Table).MaBan);
           
        }

        private void fManager_UpdateFood(object sender, EventArgs e)
        {
            LoadMon((cbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc);
            if (lsvBill.Tag != null)
                ShowHoaDon((lsvBill.Tag as Table).MaBan);
        }

        #region Account
        void ChangeAccount(int loaiTaiKhoan)
        {
            thietLapToolStripMenuItem.Enabled = loaiTaiKhoan == 1;
            chấmCôngToolStripMenuItem.Enabled = loaiTaiKhoan == 1;
            AccountInfoToolStripMenuItem.Enabled = loaiTaiKhoan == 1;
            tàiKhoảnToolStripMenuItem.Text += "(" + loginAccount.TenHienThi + ")";
        }
        #endregion
        #region clickMenu
   
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            f.ShowDialog();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassWord f = new ChangePassWord(LoginAccount);
            f.LoadUpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void f_UpdateAccount(object sender, QuanLyQuanCafe.ChangePassWord.AccountEvent e)
        {
            tàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.TenHienThi + ")";
        }


        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoAnUong f = new fDoAnUong();
            f.InsertFood +=f_InsertFood;
            f.DeleteFood +=f_DeleteFood;
            f.UpdateFood +=f_UpdateFood;
            f.ShowDialog();
        }

        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadMon((cbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc);
            LoadMonGiam((cbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc);
            if (lsvBill.Tag != null)
                ShowHoaDon((lsvBill.Tag as Table).MaBan);
            
        }

        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadMon((cbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc);
            LoadMonGiam((cbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc);
            if (lsvBill.Tag != null)
                ShowHoaDon((lsvBill.Tag as Table).MaBan);
            LoadTable();
        }

        private void f_InsertFood(object sender, EventArgs e)
        {
            LoadMon((cbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc);
            LoadMonGiam((cbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc);
            if(lsvBill.Tag != null)
                ShowHoaDon((lsvBill.Tag as Table).MaBan);
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBanAn f = new fBanAn();
            f.InsertTable +=f_InsertTable;
            f.DeleteTable +=f_DeleteTable;
            f.UpdateTable +=f_UpdateTable;
            f.ShowDialog();
        }

        private void f_UpdateTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void f_DeleteTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void f_InsertTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void AccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinTaiKhoan f = new fThongTinTaiKhoan(LoginAccount);
            f.ShowDialog();
        }
        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChucVu f = new fChucVu();
            f.ShowDialog();
        }
        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNguyenLieu f = new fNguyenLieu();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhaCungCap f = new fNhaCungCap();
            f.ShowDialog();
        }
        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCaLam f = new fCaLam();
            f.ShowDialog();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChamCong f = new fChamCong();
            f.ShowDialog();
        }

        private void danhMụcMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhMuc f = new fDanhMuc();
            f.InsertDanhMuc +=f_InsertDanhMuc;
            f.DeleteDanhMuc +=f_DeleteDanhMuc;
            f.UpdateDanhMuc +=f_UpdateDanhMuc;
            f.ShowDialog();
        }

        private void f_UpdateDanhMuc(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadDanhMucGiam();
        }

        private void f_DeleteDanhMuc(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadDanhMucGiam();
        }

        private void f_InsertDanhMuc(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadDanhMucGiam();
        }

        #endregion clickMenu
      
        #region ChonMon
        void LoadDanhMuc()
        { 
            List<DanhMuc> listDanhMuc = DanhMucDAO.Instance.LayDanhMuc();
            cbDanhMuc.DataSource = listDanhMuc;
            cbDanhMuc.DisplayMember = "TenDanhMuc";
          
        
        }
        void LoadDanhMucGiam()
        {   
            List<DanhMuc> listDanhMuc = DanhMucDAO.Instance.LayDanhMuc();
            cbDanhMucGiam.DataSource = listDanhMuc;
            cbDanhMucGiam.DisplayMember = "TenDanhMuc";
        }
        void LoadMon(int maDanhMuc)
        { 
            List<ThucAnUong> listThucAnUong = ThucAnUongDAO.Instance.LayThucAnUongByMa(maDanhMuc);
            cbThucAnUong.DataSource = listThucAnUong;       
            cbThucAnUong.DisplayMember = "TenTAU";
            
        }
        void LoadMonGiam(int maDanhMuc)
        {
            List<ThucAnUong> listThucAnUong = ThucAnUongDAO.Instance.LayThucAnUongByMa(maDanhMuc);
            cbMonGiam.DataSource = listThucAnUong;
            cbMonGiam.DisplayMember = "TenTAU";
        }
        void LoadNV()
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.LayNhanVien();
            cbNhanVien.DataSource = listNhanVien;
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
        }
        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDanhMuc = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DanhMuc selected = cb.SelectedItem as DanhMuc;
            maDanhMuc = selected.MaDanhMuc;
            LoadMon(maDanhMuc);

        }
        private void cbDanhMucGiam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDanhMuc = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DanhMuc selected = cb.SelectedItem as DanhMuc;
            maDanhMuc = selected.MaDanhMuc;
            LoadMonGiam(maDanhMuc);
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if(table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int maHoaDon = HoaDonDAO.Instance.LayHoaDonTuMaBan(table.MaBan);
            int maNV = (cbNhanVien.SelectedItem as NhanVien).MaNV;
            int soLuong = (int)nmSoLuong.Value;
            
            int maTAU = (cbThucAnUong.SelectedItem as ThucAnUong).MaTAU;
            if (maHoaDon == -1)
            {
                if(HoaDonDAO.Instance.InsertBill(table.MaBan, maNV))
                {
                    if (insertBill != null)
                        insertBill(this, new EventArgs());
                
                }
                if (HoaDonChiTietDAO.Instance.InsertBillInfo(HoaDonDAO.Instance.GetMaxMaHoaDon(), maTAU, soLuong))
                {
                   
                }

            }
            else
            {
                HoaDonChiTietDAO.Instance.InsertBillInfo(maHoaDon, maTAU, soLuong);
            }
        
            ShowHoaDon(table.MaBan);
            LoadTable();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lsvBill.Tag as Table;
                if(table == null)
                {
                    MessageBox.Show("Vui lòng chọn bàn để thanh toán !!");
                    return;
                }
                float tongTien = (float)Convert.ToDouble(txbTongTien.Text);              
                int maHoaDon = HoaDonDAO.Instance.LayHoaDonTuMaBan(table.MaBan);          
                if (maHoaDon != -1)
                {
                    if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn cho bàn" + table.TenBan + " " + table.KhuVuc, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        HoaDonDAO.Instance.checkOut(maHoaDon, (float)tongTien);
                        ShowHoaDon(table.MaBan);
                        LoadTable();
                    }
                }
                else
                    return;
            }
            catch { }
        }
        #endregion ChonMon

        #region HienThiBanAn
        void LoadTable()
        {
            flpTable1.Controls.Clear();
            flpTable2.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
           
            foreach(Table item in tableList)
            {
                
                Button btn = new Button()
                
                {
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHight,
    
                };
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = SystemColors.Control;
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackgroundImage = Properties.Resources.coffeecup1;
                        break;
                    default:
                        btn.BackgroundImage = Properties.Resources.coffeecup2;      
                        break;
                }
                    
                switch(int.Parse(item.KhuVuc))
                {
                    case 1 :
                        flpTable1.Controls.Add(btn);
                        break;
                    case 2:
                        flpTable2.Controls.Add(btn);
                        break;                      
                }
                btn.Click +=btn_Click;
                btn.Tag = item;
                btn.Text  = item.TenBan ;           
            }
    
        }
        #endregion HienThiBanAn

        #region HienThiHoaDon
        void ShowHoaDon(int maBan)
        {
            Table table = lsvBill.Tag as Table;
            lsvBill.Items.Clear();
            float tongTien = 0;
            List<HienThiHoaDonChiTiet> listHoaDonChiTiet = HienThiHoaDonChiTietDAO.Instance.LayHoaDonChiTietTheoBan(maBan);

            foreach(HienThiHoaDonChiTiet item in listHoaDonChiTiet)
            {           
                ListViewItem lsvItem = new ListViewItem(item.TenTAU.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.GiamGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString() );
                tongTien += item.ThanhTien;
     
                lsvBill.Items.Add(lsvItem);
                

            }
                List<HoaDon> listHoaDon = HoaDonDAO.Instance.LayHoaDon(table.MaBan);
            if (table.TrangThai == "Có người")
            {         
                foreach (HoaDon item in listHoaDon)
                {
                    txbMaHoaDon.Text = item.MaHoaDon.ToString();
                     txbThoiGianVao.Text = item.ThoiDiemVao.ToString("MM/dd/yyyy");
                    nmGiamGiaTong.Value = (int)item.MaHoaDon;
                }
            }
            else
            {
                txbMaHoaDon.Text = " ";
                nmGiamGiaTong.Value = -1;
            }
           
            txbTienDua.Text = "0";
            txbTienDu.Text = "0";
            txbGiamTong.Text = "0";
            txbTongTien.Text = tongTien.ToString();
            txbTenBan.Text = table.TenBan.ToString() + @"-Khu " + table.KhuVuc.ToString();
 
        }
        private event EventHandler insertBill;
        public event EventHandler InsertBill
        {
            add { insertBill += value; }
            remove { insertBill -= value; }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int maBan =((sender as Button).Tag as Table).MaBan;
            lsvBill.Tag = (sender as Button).Tag;
            ShowHoaDon(maBan);
        }
        #endregion
        #region MyRegion

        
        private void btnThietLapMon_Click(object sender, EventArgs e)
        {
            try
            {
                float giaGiam = (float)Convert.ToDouble(txbGiaMon.Text);
                int maTAU = (cbThucAnUong.SelectedItem as ThucAnUong).MaTAU;
                if(giaGiam < 0)
                    MessageBox.Show("Không thể nhập giá trị < 0");
                else if (ThucAnUongDAO.Instance.UpdateGiamGia(giaGiam, maTAU))
                {
                    MessageBox.Show("Thêm thành công");
                    if (updateFood != null)
                        updateFood(this, new EventArgs());
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            catch { }

        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapHang f = new fNhapHang();
            f.ShowDialog();
        }

        private void btnThietLapBill_Click(object sender, EventArgs e)
        {
            try
            {
                float giaGiam = (float)Convert.ToDouble(txbGiamTong.Text);
                float tongTien = (float)Convert.ToDouble(txbTongTien.Text);
                int maHoaDon = (int)nmGiamGiaTong.Value;
                if(giaGiam < 0)
                    MessageBox.Show("Không thể nhập giá trị < 0");
                else if (giaGiam < tongTien )
                {
                    if (HoaDonDAO.Instance.UpdateGiamGia(giaGiam, maHoaDon))
                    {
                        MessageBox.Show("Giảm giá thành công");
                    }
                    else
                        MessageBox.Show("Giarm giá  không thành công");
                    tongTien = tongTien - giaGiam;
                }
                else
                {
                    MessageBox.Show("Không thể nhập giá trị nhiều hơn tổng tiền");
                }

                txbTongTien.Text = tongTien.ToString();
            }
            catch { }
        }

  

        private void txbTienDua_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                float tienDua = (float)Convert.ToDouble(txbTienDua.Text);
                float tongTien = (float)Convert.ToDouble(txbTongTien.Text);
                float tienThua;
                if (e.KeyCode == Keys.Enter)
                {
                    if (tienDua < tongTien || tienDua < 0)
                    {
                        MessageBox.Show("Đưa thiếu tiền");
                    }
                    else
                    {
                        tienThua = tienDua - tongTien;
                        txbTienDu.Text = tienThua.ToString();
                    }

                }
            }
            catch { }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongKe f = new fThongKe();
            f.ShowDialog();
        }

        private void chấmCôngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThongKeChamCong f = new fThongKeChamCong();
            f.ShowDialog();
        }
#endregion
   

      

     
   
  

    

   

        

       

       

        

       
      
    }
}
