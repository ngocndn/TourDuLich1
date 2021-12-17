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
using Newtonsoft.Json;

namespace Tour.UI.QLDoan
{
    public partial class frmEditDoan : Form
    {
        DoanBUS db = new DoanBUS();
        NhanVienBUS nb = new NhanVienBUS();
        TourBUS tb = new TourBUS();
        public frmEditDoan(int DoanID, frmDoan fD)
        {
            InitializeComponent();
            Main = fD;
            this.DoanID = DoanID;
            LoadTour();LoadHDV();ShowDoan();
        }
        private frmDoan Main;
        public int DoanID { get; set; }
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

        private void ShowDoan()
        {
            List<dynamic> DoanDL = db.GetDetail(DoanID);
            var DD = JsonConvert.SerializeObject(DoanDL);
            DataTable D = (DataTable)JsonConvert.DeserializeObject(DD, (typeof(DataTable)));
            txtTenDoan.Text = D.Rows[0][1].ToString();
            dateTimePickerKH.Value =Convert.ToDateTime(D.Rows[0][2]);
            dateTimePickerKT.Value = Convert.ToDateTime(D.Rows[0][3]);
            cbbTour.SelectedIndex = cbbTour.FindString(D.Rows[0][4].ToString());
            cbbHDV.SelectedIndex = cbbHDV.FindString(D.Rows[0][5].ToString());
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

        private void Clear()
        {
            txtTenDoan.Text = dateTimePickerKH.Text = dateTimePickerKT.Text = cbbHDV.Text = cbbTour.Text = "";
        }

        private void Edit()
        {
            List<NHANVIEN> N = nb.GetAll();
            List<TOURDULICH> T = tb.GetAllTour();
            if (Checked()==true)
            {
                DOANDL d = new DOANDL();
                d.TenDoan = txtTenDoan.Text;
                d.NgayKhoiHanh = DateTime.Parse(dateTimePickerKH.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                d.NgayKetThuc = DateTime.Parse(dateTimePickerKT.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss")); ;
                foreach(var item in N)
                {
                    if (item.TenNV.Equals(cbbHDV.Text))
                    {
                        d.MaNV = item.MaNV;
                    }
                }
                foreach (var item in T)
                {
                    if (item.TenTour.Equals(cbbTour.Text))
                    {
                        d.MaTour = item.MaTour;
                    }
                }
                try
                {
                    if(db.Edit(d,DoanID))
                    {
                        System.Diagnostics.Debug.WriteLine("Sửa doan thành công!");
                        Main.LoadDoan();
                        MessageBox.Show("Sửa thành công!", "Thông báo");

                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbbHDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEditDoan_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
