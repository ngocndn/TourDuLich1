using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.DAO;using Tour.BUS;

namespace Tour.UI.QLDoan
{
    public partial class frmDoan : Form
    {
        TourBUS tb = new TourBUS();
        DoanBUS db = new DoanBUS();
        NhanVienBUS nb = new NhanVienBUS();

        public frmDoan()
        {
            InitializeComponent();
            Load();
            LoadHDV();
            LoadTour();
        }

        public void Load()
        {
            dataGridView1.DataSource = db.GetListDoan();
        }
        public void LoadHDV()
        {
            cbbHDV.DataSource = nb.GetListNV();
            cbbHDV.DisplayMember = "TenNhanVien";
        }
        public void LoadTour()
        {
            cbbTour.DataSource = tb.GetTourList();
            cbbTour.DisplayMember = "TenTour";
        }
        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenDoan.Text))
            {
                MessageBox.Show("Ten is required", "Caution!!!");
                txtTenDoan.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(cbbHDV.Text))
            {
                MessageBox.Show("HDV is required", "Caution!!!");
                cbbHDV.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(cbbTour.Text))
            {
                MessageBox.Show("Tour is required", "Caution!!!");
                cbbTour.Focus();
                return false;
            }
            return true;
        }
        private void Add()
        {
            List<DOANDL> listD = db.getall();
            List<TOURDULICH> listT =tb.GetAllTour();
            List<NHANVIEN> listN = nb.GetAll();
            if(Checked()==true)
            {
                TOURDULICH T = new TOURDULICH();
                DOANDL D = new DOANDL();

                D.TenDoan = txtTenDoan.Text;
                D.NgayKhoiHanh = DateTime.Parse(dateTimePickerKH.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                D.NgayKetThuc = DateTime.Parse(dateTimePickerKT.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                foreach (var item in listT)
                {
                    if (item.TenTour.Equals(cbbTour.Text))
                    {
                        D.MaTour = item.MaTour;
                    }
                }
                foreach (var item in listN)
                {
                    if (item.TenNV.Equals(cbbHDV.Text))
                    {
                        D.MaNV = item.MaNV;
                    }
                }
                //D.MaTour = Convert.ToInt32(cbbTour.SelectedValue);
                //D.MaNV = Convert.ToInt32(cbbHDV.SelectedValue);

                try
                {
                    if(db.Add(D))
                     {
                        System.Diagnostics.Debug.WriteLine("Success");
                        Load();
                    }
                } catch(Exception e)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
        public void Del()
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // lấy row đã click
                {
                    int DoanID = Convert.ToInt32(row.Cells[0].Value.ToString());

                    db.Delete(DoanID);

                    Load();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
        }

        private void t_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmDoan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void frmDoan_Load_1(object sender, EventArgs e)
        {

        }

        private void Detail()
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!String.Equals(r.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string DoanID = r.Cells[0].Value.ToString();
                    frmEditDoan fED = new frmEditDoan(int.Parse(DoanID), this);
                    fED.ShowDialog();
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Detail();
        }
    }
}
