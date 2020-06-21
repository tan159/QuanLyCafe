using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fDoAnUong : Form
    {
        BindingSource bindingThucAnUong = new BindingSource();
        public fDoAnUong()
        {
            InitializeComponent();
            loadDanhSachMon();
            BindingThucAnUong();
            LoadDanhMucVaoCmbox(cmbLoaiMon);
            
        }
        void loadDanhSachMon()
        {
            bindingThucAnUong.DataSource = ThucAnUongDAO.Instance.LayThucAnUong();
            try { dtgvDanhSachMon.DataSource = bindingThucAnUong; }
            catch { }
            
        }
        void BindingThucAnUong()
        {
            txbTenMon.DataBindings.Add(new Binding("Text", dtgvDanhSachMon.DataSource, "TenTAU"));
            txbMaMon.DataBindings.Add(new Binding("Text", dtgvDanhSachMon.DataSource, "MaTAU"));
            txbDonGia.DataBindings.Add(new Binding("Text", dtgvDanhSachMon.DataSource, "DonGia"));
            txbMieuTa.DataBindings.Add(new Binding("Text", dtgvDanhSachMon.DataSource, "MieuTa"));
            txbAnh.DataBindings.Add(new Binding("Text", dtgvDanhSachMon.DataSource, "HinhAnh"));
        }  
        private void btnXem_Click(object sender, EventArgs e)
        {
            loadDanhSachMon();
        }
        void LoadDanhMucVaoCmbox(ComboBox cb)
        {
            cb.DataSource = DanhMucDAO.Instance.LayDanhMuc();
            cb.DisplayMember = "TenDanhMuc";
        }
    
        private void txbMaMon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDanhSachMon.SelectedCells.Count >= 1)
                {
                    int maDanhMuc = (int)dtgvDanhSachMon.SelectedCells[0].OwningRow.Cells["MaDanhMuc"].Value;

                    if (txbAnh.Text == "")
                    {
                        Image image = Properties.Resources.NotFound;
                        picThucAn.Image = image;
                    }
                    else
                    {
                        Image image = Image.FromFile(@txbAnh.Text);
                        picThucAn.Image = image;
                    }

                    DanhMuc danhMuc = DanhMucDAO.Instance.LayDanhMucByMaDanhMuc(maDanhMuc);

                    cmbLoaiMon.SelectedItem = danhMuc;
                    int index = -1;
                    int i = 0;
                    foreach (DanhMuc item in cmbLoaiMon.Items)
                    {
                        if (item.MaDanhMuc == danhMuc.MaDanhMuc)
                        {
                            index = i;
                        }
                        i++;
                    }
                    cmbLoaiMon.SelectedIndex = index;
                }
            }
            catch { }
        }
     
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTau = txbTenMon.Text;
            string mieuTa = txbMieuTa.Text;
            int maDanhMuc = (cmbLoaiMon.SelectedItem as DanhMuc).MaDanhMuc;
            float donGia = (float)Convert.ToDouble(txbDonGia.Text);
            float giamGia = (float)Convert.ToDouble(txbGiamGia.Text);

            addFoodToDatabase(tenTau, mieuTa, maDanhMuc, donGia, giamGia);
        }
        public bool addFoodToDatabase(string tenTau ,string mieuTa ,int maDanhMuc ,float donGia ,float giamGia )
        {
            if (string.IsNullOrEmpty(tenTau) || string.IsNullOrWhiteSpace(tenTau) || donGia < 0 || 
                giamGia < 0 || ThucAnUongDAO.Instance.CheckExistTAU(tenTau) != null)
            {
                MessageBox.Show("Không thể nhập giá trị này!!");
                return false;
            }
            else
            {
                if (ThucAnUongDAO.Instance.InsertThucAnUong(tenTau, txbAnh.Text, maDanhMuc, donGia, mieuTa, giamGia))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDanhSachMon();
                    if (insertFood != null)
                        insertFood(this, new EventArgs());
                    return true;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                    return false;
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picThucAn.ImageLocation = openFile.FileName;
                txbAnh.Text = openFile.FileName;
            }
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int maTAU = Convert.ToInt32(txbMaMon.Text);
            string tenTau = txbTenMon.Text;
            string mieuTa = txbMieuTa.Text;
            int maDanhMuc = (cmbLoaiMon.SelectedItem as DanhMuc).MaDanhMuc;
            float donGia = (float)Convert.ToDouble(txbDonGia.Text);
            float giamGia = (float)Convert.ToDouble(txbGiamGia.Text);

            updateFoodInDatabase(maTAU, tenTau, mieuTa, maDanhMuc, donGia, giamGia);
        }
        public bool updateFoodInDatabase(int maTAU ,string tenTau ,string mieuTa ,int maDanhMuc ,float donGia,float giamGia )
        {
            ThucAnUong check = ThucAnUongDAO.Instance.CheckExistTAU(tenTau);
            if (string.IsNullOrEmpty(tenTau) || string.IsNullOrWhiteSpace(tenTau) || donGia < 0 || giamGia < 0)
            {
                MessageBox.Show("Không thể nhập giá trị này!!");
                return false;
            }
            else if (check != null && check.MaTAU == maTAU)
            {
                if (ThucAnUongDAO.Instance.UpdateThucAnUong(check.TenTAU, txbAnh.Text, maDanhMuc, donGia, mieuTa, giamGia, maTAU))
                {
                    MessageBox.Show("Sửa thành công");
                    loadDanhSachMon();
                    if (updateFood != null)
                        updateFood(this, new EventArgs());
                    return true;
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                    return false;
                }
            }
            else if (check != null)
            {
                MessageBox.Show("Tên muốn sửa đã có");
                return false;
            }
            else
            {
                if (ThucAnUongDAO.Instance.UpdateThucAnUong(tenTau, txbAnh.Text, maDanhMuc, donGia, mieuTa, giamGia, maTAU))
                {
                    MessageBox.Show("Sửa thành công");
                    loadDanhSachMon();
                    if (updateFood != null)
                        updateFood(this, new EventArgs());
                    return true;
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                    return false;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maTAU = Convert.ToInt32(txbMaMon.Text);
            deleteFoodInDatabase(maTAU);
        }
        public bool deleteFoodInDatabase(int maTau)
        {
            if (ThucAnUongDAO.Instance.DeleteTAU(maTau))
            {
                MessageBox.Show("Xóa thành công");
                loadDanhSachMon();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
                return true;
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
                return false;
            }
        }
        List<ThucAnUong> SearchTaU(string name)
        {
            List<ThucAnUong> resual = new List<ThucAnUong>();
            resual = ThucAnUongDAO.Instance.SearchTaU(name);
            return resual;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        #region Pain
        private void VeHinh(Graphics g, Rectangle rect)
        {
            Image img = Properties.Resources.coffeeBaner;
            g.DrawImage(img, rect);
        }
        private void VeChu(Graphics g, Rectangle rect)
        {
            Font font = new Font("Arial", 20);
            Color color = Color.Honeydew;
            SolidBrush br = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Near;
            g.DrawString(this.Text, font, br, rect, format);
        }
        private void fDoAnUong_SizeChanged(object sender, EventArgs e)
            {
            Invalidate();
            }

        private void fDoAnUong_Paint(object sender, PaintEventArgs e)
            {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 68);
            Rectangle rect1 = new Rectangle(0, 0, 200, 68);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
            }
       #endregion
        #region Events
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindingThucAnUong.DataSource = SearchTaU(txbSearch.Text);
        }
    }
}
