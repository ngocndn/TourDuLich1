using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using Tour.BUS;using Tour.DAO;

namespace Tour.UI.QLDoan
{

    public partial class frmQLDoan : Form
    {
        DoanBUS db = new DoanBUS();
        TourBUS tb = new TourBUS();
        ChiPhiBUS cb = new ChiPhiBUS();
        DoanDAO dd = new DoanDAO();
        NhanVienBUS nvb = new NhanVienBUS();
        public frmQLDoan()
        {
            InitializeComponent();
            LoadDanhSachDoan();
            LoadCBHDV();
            LoadCBTour();
        }
        //public void LoadDanhSachDoan()
        //{
            //dataGridView1.DataSource = db.getall();
           // dataGridView1.Columns["Column8"].DefaultCellStyle.Format = "#,##0";
           // dataGridView1.Columns["Column9"].DefaultCellStyle.Format = "#,##0";
       // }
        public void LoadDanhSachDoan()
        {
            dataGridView1.DataSource = db.GetListDoan();
            dataGridView1.Columns["Column8"].DefaultCellStyle.Format = "#,##0";
            dataGridView1.Columns["Column9"].DefaultCellStyle.Format = "#,##0";
            dpk1.MinDate = DateTime.Today;
            dpk2.MinDate = DateTime.Today;
        }

        public void LoadCBTour()
        {
            cbbtour.DataSource = tb.GetAllTour();
            cbbtour.DisplayMember = "TenTour";
            cbbtour.ValueMember = "MaTour";
        }
        public void LoadCBHDV()
        {
            cbbhdv.DataSource = nvb.GetAll();
            cbbhdv.DisplayMember = "TenNV";
        }
        public void Clear()
        {
            txtTenDoan.Text = "";
        }

        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenDoan.Text))
            {
                MessageBox.Show("Nhập tên đoàn!!!", "Lưu ý!!!");
                txtTenDoan.Focus();
                return false;
            }
            return true;
        }
        public void Del()
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    int DoanID = Convert.ToInt32(r.Cells[0].Value.ToString());
                    db.Delete(DoanID);
                    LoadDanhSachDoan();
                    MessageBox.Show("Xóa thành công!!");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoàn muốn xóa!", "Lưu ý!!!");
            }
        }
        public void Add()
        {
            List<DOANDL> listD = db.getall();
            List<TOURDULICH> listT = tb.GetAllTour();
            List<NHANVIEN> listN = nvb.GetAll();
            if (Checked() == true)
            { 
                if(Checkday() == true)
                {
                    TOURDULICH T = new TOURDULICH();
                    DOANDL D = new DOANDL();

                    D.TenDoan = txtTenDoan.Text;
                    D.NgayKhoiHanh = DateTime.Parse(dpk1.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                    D.NgayKetThuc = DateTime.Parse(dpk2.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                    D.Soluong = 0;
                    D.MaTour = (int)cbbtour.SelectedValue;
                    D.ChiPhi = 0;
                    //foreach (var item in listT)
                    //{
                    //if (item.TenTour.Equals(cbbtour.Text))
                    //{
                    //  D.MaTour = item.MaTour;
                    // }
                    // }
                    foreach (var item in listN)
                    {
                        if (item.TenNV.Equals(cbbhdv.Text))
                        {
                            D.MaNV = item.MaNV;
                        }
                    }
                    //D.MaTour = Convert.ToInt32(cbbTour.SelectedValue);
                    //D.MaNV = Convert.ToInt32(cbbHDV.SelectedValue);

                    try
                    {
                        if (db.Add(D))
                        {
                            LoadDanhSachDoan();
                            Clear();
                            MessageBox.Show("Thêm đoàn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!", "Lưu ý!!!");
                        }
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine(e);
                    }
                }
            else
                {
                    MessageBox.Show("Thêm không thành công!! Kiểm tra lại dữ liệu nhập!!!", "Lưu ý!!!");
                }
            }
        }

        private void frmQLDoan_Load(object sender, EventArgs e)
        {

        }
        public void Detail()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                String DoanID = row.Cells[0].Value.ToString();
                String TourID = row.Cells[2].Value.ToString();

                frmEditDoan fE = new frmEditDoan(int.Parse(DoanID), int.Parse(TourID) , this);
                fE.ShowDialog();

            }
        }
        public bool Checkday()
        {
            if(dpk2.Value <= dpk1.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Lưu ý!!!");
                return false;
            }
            return true;
        }
        public void Search()
        {
            if (!String.IsNullOrWhiteSpace(txtsearch.Text))
            {
                string searchValue = txtsearch.Text;
                dataGridView1.DataSource = db.Searching(searchValue);
            }
            else
            {
                LoadDanhSachDoan();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Delete = MessageBox.Show("Dữ liệu sẽ bị xóa vĩnh viễn!", "Lưu ý!!!", MessageBoxButtons.YesNo);
            if (Delete == DialogResult.Yes)
            {
                Del();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Detail();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRf_Click(object sender, EventArgs e)
        {
            LoadDanhSachDoan();
        }
    }
}
