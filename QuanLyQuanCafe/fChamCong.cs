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
    public partial class fChamCong : Form
    {
        public fChamCong()
        {
            InitializeComponent();
            LoadChamCong();
        }
        void LoadChamCong()
        {
            loadNhanVien();
            loadCalam();
        }
        void loadCalam()
        {
            List<CaLam> listThucAnUong = CaLamDAO.Instance.CaLam();
            cbCa.DataSource = listThucAnUong;
            cbCa.DisplayMember = "LoaiCa";
        }
        void loadNhanVien()
        {
            dtgvChamCong.DataSource = HienThiNhanVienDAO.Instance.LayHoaDon();
            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            CheckboxColumn.TrueValue = true;
            CheckboxColumn.FalseValue = false;
            CheckboxColumn.HeaderText = "Chấm công";
            dtgvChamCong.Columns.Add(CheckboxColumn);         
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            string ngay = dtpNgay.Value.Date.ToString("yyyy-MM-dd");
            int maCa = (cbCa.SelectedItem as CaLam).MaCa;
                foreach (DataGridViewRow row in dtgvChamCong.Rows)
                {
                    if(Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        int maNV = Convert.ToInt32(row.Cells[1].Value.ToString());
                        if (ChamCongDAO.Instance.InsertCong(maNV,maCa,ngay,"Có làm"))
                        {
                            
                        }
                        else
                            MessageBox.Show("Thêm không thành công");
                    }
                    else
                    {
                        int maNV = Convert.ToInt32(row.Cells[1].Value.ToString());
                        if (ChamCongDAO.Instance.InsertCong(maNV, maCa, ngay, "Không làm"))
                        {

                        }
                        else
                            MessageBox.Show("Thêm không thành công");
                    }



            }
            MessageBox.Show("Chấm thành công");
            dtgvChamCong.EndEdit();
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            fXemChamCong f = new fXemChamCong();
            f.ShowDialog();
 
        }

        private void fChamCong_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void fChamCong_Paint(object sender, PaintEventArgs e)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngay = dtpNgay.Value.Date.ToString("yyyy-MM-dd");
            string ghiChu = cbGhiChu.SelectedItem.ToString();
            int maCa = (cbCa.SelectedItem as CaLam).MaCa;
            foreach (DataGridViewRow row in dtgvChamCong.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int maNV = Convert.ToInt32(row.Cells[1].Value.ToString());
                    if (ChamCongDAO.Instance.UpdateCong(maNV, maCa, ngay, ghiChu))
                    {
                        
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }

            }
            MessageBox.Show("Sửa thành công");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ngay = dtpNgay.Value.Date.ToString("yyyy-MM-dd");
            int maCa = (cbCa.SelectedItem as CaLam).MaCa;
            foreach (DataGridViewRow row in dtgvChamCong.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int maNV = Convert.ToInt32(row.Cells[1].Value.ToString());
                    if (ChamCongDAO.Instance.DeleteCong(maNV, maCa, ngay))
                    {

                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }

            }
            MessageBox.Show("Xóa thành công");

        }
    }
}
