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
    public partial class fBanAn : MetroFramework.Forms.MetroForm
    {
        BindingSource bindingTable = new BindingSource();
        public fBanAn()
        {
            InitializeComponent();
            LoadfBanAn();

        }
        void LoadfBanAn()
        {
            LoadListTalbe();
            BindingTalbe();

        }
        void LoadListTalbe()
        {
            bindingTable.DataSource = TableDAO.Instance.LoadTableList();
            try { dtgvBanAn.DataSource = bindingTable; }
            catch { }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListTalbe();
        }
        void BindingTalbe()
        {
            txbMaBan.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "MaBan"));
            txbTenBan.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "TenBan"));
            nmKhuVuc.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "KhuVuc"));
            txbMieuTa.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "MieuTa"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBan = txbTenBan.Text;
            string khuVuc = nmKhuVuc.Value.ToString();
            string mieuTa = txbMieuTa.Text;
            addTableToDatabase(tenBan, khuVuc, mieuTa);

        }
        public bool addTableToDatabase(string tenBan,string khuVuc,string mieuTa)
        {
            if (string.IsNullOrEmpty(tenBan))
            {
                MessageBox.Show("Vui lòng nhập tên bàn");
                return false;
            }
            else if (TableDAO.Instance.InsertBanAn(tenBan, khuVuc, mieuTa))
            {
                MessageBox.Show("Thêm thành công");
                LoadListTalbe();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
                return true;
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
                return false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenBan = txbTenBan.Text;
            string khuVuc = nmKhuVuc.Text;
            string mieuTa = txbMieuTa.Text;
            int maBan = Convert.ToInt32(txbMaBan.Text);

            if (string.IsNullOrEmpty(tenBan))
            {
                MessageBox.Show("Vui lòng nhập tên bàn");
            }
            else if (TableDAO.Instance.UpdateBanAn(maBan, tenBan, khuVuc, mieuTa))
            {
                MessageBox.Show("Sửa thành công");
                LoadListTalbe();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txbMaBan.Text != "")
            {
                int maBan = Convert.ToInt32(txbMaBan.Text);

                if (TableDAO.Instance.DeleteBanAn(maBan))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadListTalbe();
                    if (deleteTable != null)
                        deleteTable(this, new EventArgs());
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                MessageBox.Show("Không có bàn để xóa");

        }

        #region events
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }








        #endregion

        private void fBanAn_Load(object sender, EventArgs e)
        {

        }

        private void dtgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

