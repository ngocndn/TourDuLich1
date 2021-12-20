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
        public void LoadDanhSachDoan()
        {
            dataGridView1.DataSource = db.GetListDoan();
            dataGridView1.AutoGenerateColumns = false;
        }

        public void LoadCBTour()
        {
            cbbtour.DataSource = tb.GetAllTour();
            cbbtour.DisplayMember = "TenTour";
        }
        public void LoadCBHDV()
        {
            cbbhdv.DataSource = nvb.GetAll();
            cbbhdv.DisplayMember = "TenNV";
        }


        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenDoan.Text))
            {
                MessageBox.Show("Ten is required", "Caution!!!");
                txtTenDoan.Focus();
                return false;
            }
            return true;
        }

        public void Add()
        {
            List<DOANDL> listD = db.getall();
            List<TOURDULICH> listT = tb.GetAllTour();
            List<NHANVIEN> listN = nvb.GetAll();
            if (Checked() == true)
            {
                TOURDULICH T = new TOURDULICH();
                DOANDL D = new DOANDL();

                D.TenDoan = txtTenDoan.Text;
                D.NgayKhoiHanh = DateTime.Parse(dpk1.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                D.NgayKetThuc = DateTime.Parse(dpk2.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));


                foreach (var item in listT)
                {
                    if (item.TenTour.Equals(cbbtour.Text))
                    {
                        D.MaTour = item.MaTour;
                    }
                }
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
                        System.Diagnostics.Debug.WriteLine("Success");
                        LoadDanhSachDoan();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        private void frmQLDoan_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
