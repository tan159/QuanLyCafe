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
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
            SetTime();
        
        }
        void SetTime()
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year,today.Month,1);       
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
            nmThang.Value = Convert.ToInt32(today.ToString("MM"));
        }
        void LoadData(DateTime checkIn,DateTime checkOut)
        {
            dataGridView1.DataSource = HoaDonDAO.Instance.ThongKeBill(checkIn,checkOut);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
            LoadData(dateTimePicker1.Value, dateTimePicker2.Value);
            float sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sum = sum + (float)Convert.ToDouble(row.Cells[1].Value);
            }
            txbTongTienBan.Text = sum.ToString();
        }
        
        private void btnThongKePn_Click(object sender, EventArgs e)
        {
            int thang = (int)nmThang.Value;
            float sum = 0;
            dtgvThongKePn.DataSource = PhieuNhapDAO.Instance.ThongKePhieuNhap(thang);
             foreach (DataGridViewRow row in dtgvThongKePn.Rows)
             {
                 sum = sum + (float)Convert.ToDouble(row.Cells[5].Value);
             }
             txbTongTien.Text = sum.ToString();
        }

    }
}
