using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using Tour.BUS;using Tour.DAO;

namespace Tour.UI.QLChiPhi
{
    public partial class frmChiPhi : Form
    {
        ChiPhiBUS cb = new ChiPhiBUS();
        public frmChiPhi()
        {
            InitializeComponent();
            Loadcbb();Loadcp();
        }
        public void Loadcp()
        {
            dataGridView1.DataSource = cb.GetAll();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void Loadcbb()
        {
            cbbcp.DataSource = cb.GetAllCP();
            cbbcp.DisplayMember = "TenLoaiCP";
        }
        private void Clear()
        {
            txtGia.Text = txtTencp.Text = " ";
        }

        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Gia is required", "Caution!!!");
                txtGia.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtTencp.Text))
            {
                MessageBox.Show("Ten is required", "Caution!!!");
                txtTencp.Focus();
                return false;
            }
            return true;
        }

        public void Add()
        {
            List<CHIPHI> lc = cb.GetAll();
            List < LOAICHIPHI > lcb = cb.GetAllCP();
            if (Checked() == true)
            {
                CHIPHI c = new CHIPHI();
                c.TenCP = txtTencp.Text;
                c.ThanhTien = float.Parse(txtGia.Text);
                foreach (var item in lcb)
                {
                    if (item.TenLoaiCP.Equals(cbbcp.Text))
                    {
                        c.LoaiCP_ID = item.LoaiCP_ID;
                    }
                }
                try
                {
                    if (cb.Add(c))
                    {
                        MessageBox.Show("Success", "Notify");
                        Loadcp();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("FAILED", "Caution!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        public void Delete()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // lấy row đã click
                {
                    int cp_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    cb.Xoa(cp_id);
                    Loadcp();
                    MessageBox.Show("Success", "Notify");
                }
            }
            else
            {
                MessageBox.Show("Select price!", "Caution");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmChiPhi_Load(object sender, EventArgs e)
        {

        }
        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string cp_id = row.Cells[0].Value.ToString();

                    frmEditCP formChiTietNhanVien = new frmEditCP(int.Parse(cp_id), this);

                    formChiTietNhanVien.ShowDialog();

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }
    }
}
