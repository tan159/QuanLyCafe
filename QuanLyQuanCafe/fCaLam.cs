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
    public partial class fCaLam : Form
    {
        public fCaLam()
        {
            InitializeComponent();
            LoadfCaLam();
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            int maCa = Convert.ToInt32(txbMaCa.Text);
            string loaiCa = txbLoaiCa.Text;
        
            if (CaLamDAO.Instance.UpdateCaLam(maCa,loaiCa))
            {
                MessageBox.Show("Sửa thành công");
                LoadCaLam();
            }
            else
                MessageBox.Show("Sửa không thành công");
        }

     

   
        BindingSource bindingCaLam = new BindingSource();
        void LoadfCaLam()
        {
            LoadCaLam();
            BindingCaLam();
        }
        void LoadCaLam()
        {
            bindingCaLam.DataSource = CaLamDAO.Instance.CaLam();
            dtgvCaLam.DataSource = bindingCaLam;
        }
        void BindingCaLam()
        {
            txbMaCa.DataBindings.Add(new Binding("Text", dtgvCaLam.DataSource, "MaCa"));
            txbLoaiCa.DataBindings.Add(new Binding("Text", dtgvCaLam.DataSource, "LoaiCa"));
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadCaLam();
        }

   

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maCa = Convert.ToInt32(txbMaCa.Text);
            if (CaLamDAO.Instance.DeleteCaLam(maCa))
            {
                MessageBox.Show("Xóa thành công");
                LoadCaLam();
            }
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string loaiCa = txbLoaiCa.Text;
            if (CaLamDAO.Instance.InsertCaLam(loaiCa))
            {
                MessageBox.Show("Thêm thành công");
                LoadCaLam();
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Pain
        private void VeHinh(Graphics g, Rectangle rect)
        {
            Image img =Properties.Resources.coffeeBaner;
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
        private void fCaLam_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void fCaLam_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }
        #endregion

     

       

  

       
      
    }
}
