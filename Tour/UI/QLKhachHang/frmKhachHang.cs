using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using Tour.DAO; using Tour.BUS;

namespace Tour.UI.QLKhachHang
{
    public partial class frmKhachHang : Form
    {
        KhachHangBUS khb = new KhachHangBUS();
        public frmKhachHang()
        {
            InitializeComponent();
            LoadCBBGIoiTinh();
            LoadKH();
        }
        public void LoadKH()
        {
            dataGridView1.DataSource = khb.GetKhachHang();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void LoadCBBGIoiTinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedItem = "Nam";
        }
        public void Clear()
        {
            txtTenKH.Text = txtSDT.Text = txtEmail.Text = txtDiaChi.Text = txtCMND.Text = dp_NSKH.Text = "";

        }

        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Ten is required", "Caution!!!");
                txtTenKH.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("SDT is required", "Caution!!!");
                txtSDT.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(cbbGioiTinh.Text))
            {
                MessageBox.Show("GT is required", "Caution!!!");
                cbbGioiTinh.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is required", "Caution!!!");
                txtEmail.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("DiaChi is required", "Caution!!!");
                txtDiaChi.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("CMND is required", "Caution!!!");
                txtCMND.Focus();
                return false;
            }
            return true;
        }

        public void Add()
        {
            if (Checked())
            {
                try
                {
                    KHACHHANG KH = new KHACHHANG();
                    KH.TenKH = txtTenKH.Text;
                    KH.KH_CMND = txtCMND.Text;
                    KH.KH_DiaChi = txtDiaChi.Text;
                    KH.KH_GioiTinh = cbbGioiTinh.Text;
                    KH.KH_email = txtEmail.Text;
                    KH.KH_SoDienThoai = txtSDT.Text;
                    KH.KH_NgaySinh = dp_NSKH.Value;
                    

                    if (khb.ThemKhachHang(KH))
                    {
                        LoadKH();
                        Clear();
                        MessageBox.Show("Success", "Notify");

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed", "Caution");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        public void Del()
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int KH_ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    khb.XoaKhachHang(KH_ID);
                    LoadKH();
                    MessageBox.Show("Deleted", "Notify");

                }
            }
            else
            {
                MessageBox.Show("Choose someone to delete", "Caution!!!");
            }
        }
        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string KH_ID = row.Cells[0].Value.ToString();

                    frmEditKhachHang formChiTietKhachHang = new frmEditKhachHang(int.Parse(KH_ID),this);

                    formChiTietKhachHang.ShowDialog();

                }
            }
        }
        public void Search()
        {
            if (!String.IsNullOrWhiteSpace(txtsearch.Text))
            {
                string searchValue = txtsearch.Text;

                dataGridView1.DataSource = khb.Searching(searchValue);

            }
            else
            {
                LoadKH();
            }
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Del();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
