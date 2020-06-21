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
    public partial class fChucVu : Form
    {
        public fChucVu()
        {
            InitializeComponent();
            LoadfChucVu();
        }
        void LoadfChucVu()
        {
            LoadChucVu();
            BindingChucVu();
        }
        
        BindingSource bingdingChucVu = new BindingSource();
        void LoadChucVu()
        {
            bingdingChucVu.DataSource = ChucVuDAO.Instance.ChucVu();
            dataGridView1.DataSource = bingdingChucVu;
        }
        void BindingChucVu()
        {
            txbMa.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaChucVu"));
            txbTen.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenChucVu"));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadChucVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenChucVu = txbTen.Text;

            if (ChucVuDAO.Instance.InsertChucVu(tenChucVu))
            {
                MessageBox.Show("Thêm thành công");
                LoadChucVu();
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenChucVu = txbTen.Text;
            int maChucVu = Convert.ToInt32(txbMa.Text);

            if (ChucVuDAO.Instance.UpdateChucVu(maChucVu,tenChucVu))
            {
                MessageBox.Show("Thêm thành công");
                LoadChucVu();
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maChucVu = Convert.ToInt32(txbMa.Text);

            if (ChucVuDAO.Instance.DeleteChucVu(maChucVu))
            {
                MessageBox.Show("Xóa thành công");
                LoadChucVu();
            }
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChucVu_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void fChucVu_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
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

  

        
        #endregion
    }
}
