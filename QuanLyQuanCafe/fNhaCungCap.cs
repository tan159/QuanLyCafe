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
    public partial class fNhaCungCap : Form
    {
        public fNhaCungCap()
        {
            InitializeComponent();
            LoadfNhaCungCap();
        }
     
        void LoadfNhaCungCap()
        {
            LoadNhaCungCap();
            BindingNhaCungCap();
        }
        BindingSource bindingNhaCungCap = new BindingSource();
        void LoadNhaCungCap()
        {
            bindingNhaCungCap.DataSource = NhaCungCapDAO.Instance.NhaCungCap();
            dtgvNCC.DataSource = bindingNhaCungCap;
        }

        void BindingNhaCungCap()
        {
            txbMaNCC.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "MaNCC"));
            txbTenNCC.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "TenNhaCC"));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "DiaChi"));
            txbSdt.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "Phone"));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvNCC.DataSource, "Email"));
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txbTenNCC.Text;
            string diaChi =txbDiaChi.Text;
            string sdt = txbSdt.Text;
            string email =txbEmail.Text;

            if (NhaCungCapDAO.Instance.InsertNhaCungCap(ten,sdt,email,diaChi))
            {
                MessageBox.Show("Thêm thành công");
                LoadNhaCungCap();
            }
            else
                MessageBox.Show("Thêm không thành công");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txbMaNCC.Text);
            string ten = txbTenNCC.Text;
            string diaChi = txbDiaChi.Text;
            string sdt = txbSdt.Text;
            string email = txbEmail.Text;

            if (NhaCungCapDAO.Instance.UpdateNhaCungCap(ma, ten, sdt, email, diaChi))
            {
                MessageBox.Show("Sửa thành công");
                LoadNhaCungCap();
            }
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNCC = Convert.ToInt32(txbMaNCC.Text);

            if (NhaCungCapDAO.Instance.DeleteNCC(maNCC))
            {
                MessageBox.Show("Xóa thành công");
                LoadNhaCungCap();
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

         private void fNhaCungCap_SizeChanged(object sender, EventArgs e)
        {
             Invalidate();
        }

        private void fNhaCungCap_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }

        
        #endregion

  

    }
}
