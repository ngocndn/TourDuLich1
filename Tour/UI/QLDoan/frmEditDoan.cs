using Newtonsoft.Json;
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
    public partial class frmEditDoan : Form
    {
        BookingBUS bb = new BookingBUS();
        DoanBUS db = new DoanBUS();
        TourBUS tb = new TourBUS();
        ChiPhiBUS cb = new ChiPhiBUS();
        DoanDAO dd = new DoanDAO();
        NhanVienBUS nvb = new NhanVienBUS();
        public frmEditDoan(int DoanID,int TourID, frmQLDoan Q)
        {
            InitializeComponent();
            this.Doanid = DoanID;
            this.Tourid = TourID;
            frmMain = Q;
            LoadCBHDV();
            LoadCBTour();
            LoadDoan();
            LoadDSKH();
        }
        private int Doanid { get; set; }
        private int Tourid { get; set; }
        private frmQLDoan frmMain;
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
        public void LoadBooking()
        {
            dataGridView1.DataSource = bb.GetAll();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void LoadDSKH()
        {
            dataGridView1.DataSource = bb.GetDetail(Doanid);
            dataGridView1.AutoGenerateColumns = false;

        }
        public void LoadDoan()
        {
            var json = JsonConvert.SerializeObject(dd.GetDDetail(Doanid));
            DataTable dataTableDetailsDoan = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            txtTenDoan.Text = dataTableDetailsDoan.Rows[0][1].ToString();
            cbbtour.SelectedIndex = cbbtour.FindString(dataTableDetailsDoan.Rows[0][4].ToString());
            cbbhdv.SelectedIndex = cbbhdv.FindString(dataTableDetailsDoan.Rows[0][5].ToString());
            dpk1.Text = dataTableDetailsDoan.Rows[0][2].ToString();
            dpk2.Text = dataTableDetailsDoan.Rows[0][3].ToString();
        }
        public bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenDoan.Text))
            {
                MessageBox.Show("Ten is required", "Caution!!!");
                txtTenDoan.Focus();
                return false;
            }
            return true;
        }
        private void Edit()
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
                try
                {
                    if (db.Edit(D, Doanid))
                    {
                        System.Diagnostics.Debug.WriteLine("Success");
                        frmMain.LoadDanhSachDoan();
                        MessageBox.Show("Success");
                    } else
                    {
                        MessageBox.Show("Failed");
                    }    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }
       
        private void btnPricing_Click(object sender, EventArgs e)
        {
            frmAdd fA = new frmAdd(Doanid,Tourid, this);
            fA.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmEditDoan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
