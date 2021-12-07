using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.BUS;using Tour.DAO;

namespace Tour.UI.QLNhanVien
{
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvb = new BUS.NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
            LoadNV();
        }

        public void LoadNV()
        {
            dataGridView1.DataSource = nvb.GetListNV();
            dataGridView1.AutoGenerateColumns = false;

        }

        public void Clear()
        {
            txtTenNV.Text = txtSDT.Text = dp_NSNV.Text = "";
        }

        bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Name is required!", "Caution!!!");
                txtTenNV.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("SDT is required!", "Caution!!!");
                txtSDT.Focus();
                return false;
            }

            //Kiểm tra kí tự đặc biệt và số
            Regex regex = new Regex(@"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]");

            if (regex.IsMatch(txtTenNV.Text))
            {
                MessageBox.Show("No Special Character!", "Caution!!!");
                txtTenNV.Focus();
                return false;
            }
       
            return true;
        }

        public void Add()
        {
            List<NHANVIEN> listNV = new List<NHANVIEN>();
            if(Checked() == true)
            {
                NHANVIEN NV = new NHANVIEN();
                NV.TenNV = txtTenNV.Text;
                NV.NV_NgaySinh = dp_NSNV.Value;
                NV.NV_SoDienThoai = txtSDT.Text;
                try
                {
                    if(nvb.Add(NV))
                    {
                        Clear();
                        LoadNV();
                        MessageBox.Show("Success", "Notify");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("FAILED", "CAUTION!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        public void Del()
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // lấy row đã click
                {
                    int NV_ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    nvb.XoaNhanVien(NV_ID);
                    LoadNV();
                    MessageBox.Show("Success", "Notify");
                }
            }
            else
            {
                MessageBox.Show("Select tour!", "Caution");
            }
        }
        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string NV_ID = row.Cells[0].Value.ToString();

                    frmEditNV formChiTietNhanVien = new frmEditNV(int.Parse(NV_ID), this);

                    formChiTietNhanVien.ShowDialog();

                }
            }
        }



        private void frmNhanVien_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
