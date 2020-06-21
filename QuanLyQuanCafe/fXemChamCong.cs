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
    public partial class fXemChamCong : Form
    {
        public fXemChamCong()
        {
            InitializeComponent();
            LoadData();
            
        }
    
        void LoadData()
        {
            DateTime today = DateTime.Now;
            dtgvXemChamCong.DataSource = ChamCongDAO.Instance.XemChamCong(today);
        }
   
    }
}
