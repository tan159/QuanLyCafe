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
    public partial class fNguyenLieu : Form
    {
        public fNguyenLieu()
        {
            InitializeComponent();
            LoadfNguyenLieu();
        }
        void LoadfNguyenLieu()
        {
            LoadNguyenLieu();
            BindingNguyenLieu();
        }
        BindingSource bindingNguyenLieu = new BindingSource();
        void LoadNguyenLieu()
        {
            bindingNguyenLieu.DataSource = NguyenLieuDAO.Instance.NguyenLieu();
            dtgvNguyenLieu.DataSource = bindingNguyenLieu;
        }

        void BindingNguyenLieu()
        {
            txbMaNL.DataBindings.Add(new Binding("Text", dtgvNguyenLieu.DataSource, "MaNL"));
            txbTen.DataBindings.Add(new Binding("Text", dtgvNguyenLieu.DataSource, "TenNL"));
            txbDonGia.DataBindings.Add(new Binding("Text", dtgvNguyenLieu.DataSource, "DonGia"));
            cmbDonVi.DataBindings.Add(new Binding("Text", dtgvNguyenLieu.DataSource, "DonViTinh"));
            txbMieuTa.DataBindings.Add(new Binding("Text", dtgvNguyenLieu.DataSource, "MieuTa"));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNL = txbTen.Text;
            float donGia = (float)Convert.ToDouble(txbDonGia.Text);
            string mieuTa = txbMieuTa.Text;
            string donViTinh = cmbDonVi.Text;


            if (NguyenLieuDAO.Instance.InsertNguyenLieu(tenNL, donGia, mieuTa, donViTinh))
            {
                MessageBox.Show("Thêm thành công");
                LoadNguyenLieu();
            }
            else
                MessageBox.Show("Thêm không thành công");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenNL = txbTen.Text;
            float donGia = (float)Convert.ToDouble(txbDonGia.Text);
            string mieuTa = txbMieuTa.Text;
            string donViTinh = cmbDonVi.Text;
            int maNL = Convert.ToInt32(txbMaNL.Text);


            if (NguyenLieuDAO.Instance.UpdateNguyenLieu(maNL, tenNL, donGia, mieuTa, donViTinh))
            {
                MessageBox.Show("Sửa thành công");
                LoadNguyenLieu();
            }
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNL = Convert.ToInt32(txbMaNL.Text);

            if (NguyenLieuDAO.Instance.DeleteNguyenLieu(maNL))
            {
                MessageBox.Show("Xóa thành công");
                LoadNguyenLieu();
            }
            else
                MessageBox.Show("Xóa không thành công");
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

         private void fNguyenLieu_SizeChanged(object sender, EventArgs e)
        {
             Invalidate();
        }

        private void fNguyenLieu_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }





        
        #endregion
    }
}
