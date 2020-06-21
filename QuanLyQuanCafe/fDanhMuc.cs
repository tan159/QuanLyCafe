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

namespace QuanLyQuanCafe
{
    public partial class fDanhMuc : Form
    {
        public fDanhMuc()
        {
            InitializeComponent();
            LoadfDanhMuc();
        }
        BindingSource bindingDanhMuc = new BindingSource();
        void LoadfDanhMuc()
        {
            LoadDanhMuc();
            BindingDanhMuc();
        }
        void LoadDanhMuc()
        {
            bindingDanhMuc.DataSource = DanhMucDAO.Instance.LayDanhMuc();
            try
            {
                dtgvDanhMuc.DataSource = bindingDanhMuc;
            }
            catch { }
        }
        void BindingDanhMuc()
        {
            txbMaDanhMuc.DataBindings.Add(new Binding("Text", dtgvDanhMuc.DataSource, "MaDanhMuc"));
            txbTenDanhMuc.DataBindings.Add(new Binding("Text", dtgvDanhMuc.DataSource, "TenDanhMuc"));
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maDanhMuc = Convert.ToInt32(txbMaDanhMuc.Text);
            string tenDanhMuc = txbTenDanhMuc.Text;
            updateDanhMucInDatabase(maDanhMuc, tenDanhMuc);
        }
        public bool updateDanhMucInDatabase(int maDanhMuc, string tenDanhMuc)
        {
            if (string.IsNullOrWhiteSpace(tenDanhMuc) || string.IsNullOrEmpty(tenDanhMuc))
            {
                MessageBox.Show("Không thể sửa !!");
                return false;
            }
            else if (DanhMucDAO.Instance.CheckExist(tenDanhMuc))
            {
                MessageBox.Show("Đã có danh mục này không thể sửa trùng");
                return false;
            }
            else
            {
                if (DanhMucDAO.Instance.UpdateDanhMuc(maDanhMuc, tenDanhMuc))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDanhMuc();
                    if (updateDanhMuc != null)
                        updateDanhMuc(this, new EventArgs());
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
            int maDanhMuc = Convert.ToInt32(txbMaDanhMuc.Text);
            deleteDanhMucInDatabase(maDanhMuc);
        }
        public bool deleteDanhMucInDatabase(int maDanhMuc)
        {
            if (DanhMucDAO.Instance.DeleteDanhMuc(maDanhMuc))
            {
                MessageBox.Show("Xóa thành công");
                LoadDanhMuc();
                if (deleteDanhMuc != null)
                    deleteDanhMuc(this, new EventArgs());
                return true;
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = txbTenDanhMuc.Text;
            addDanhMucToDatabase(tenDanhMuc);
        }
        public bool addDanhMucToDatabase(string tenDanhMuc)
        {
            if (string.IsNullOrWhiteSpace(tenDanhMuc) || string.IsNullOrEmpty(tenDanhMuc))
            {
                MessageBox.Show("Không thể thêm !");
                return false;
            }
            else if (DanhMucDAO.Instance.CheckExist(tenDanhMuc))
            {
                MessageBox.Show("Đã có danh mục này không thể thêm trùng !");
                return false;
            }
            else
            {
                if (DanhMucDAO.Instance.InsertDanhMuc(tenDanhMuc))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDanhMuc();
                    if (insertDanhMuc != null)
                        insertDanhMuc(this, new EventArgs());
                    return true;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                    return false;
                }
            }
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
            Font font = new Font("Arial", 15);
            Color color = Color.Honeydew;
            SolidBrush br = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Near;
            g.DrawString(this.Text, font, br, rect, format);
        }
        private void fDanhMuc_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void fDanhMuc_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }
        #endregion
        #region Events
        private event EventHandler insertDanhMuc;
        public event EventHandler InsertDanhMuc
        {
            add { insertDanhMuc += value; }
            remove { insertDanhMuc -= value; }
        }
        private event EventHandler deleteDanhMuc;
        public event EventHandler DeleteDanhMuc
        {
            add { deleteDanhMuc += value; }
            remove { deleteDanhMuc -= value; }
        }
        private event EventHandler updateDanhMuc;
        public event EventHandler UpdateDanhMuc
        {
            add { updateDanhMuc += value; }
            remove { updateDanhMuc -= value; }
        }

        #endregion


    }
}
