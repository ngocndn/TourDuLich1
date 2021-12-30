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
            //OnRowNumberChanged();
        }
        private int Doanid { get; set; }
        private int Tourid { get; set; }
        private frmQLDoan frmMain;
        public void Formate()
        {
            txtPrice.Text = string.Format("{0:#,##0}",txtPrice.Text.ToString());
            txtGiaTour.Text = string.Format("{0:#,##0}", txtGiaTour.Text.ToString());
            txtTongCong.Text = string.Format("{0:#,##0}", txtTongCong.Text.ToString());
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
        public void LoadBooking()
        {
            dataGridView1.DataSource = bb.GetAll();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void LoadDSKH()
        {
            List<BOOKING> B = bb.GetAll();
            dataGridView1.DataSource = bb.GetDetail(Doanid);
            dataGridView1.AutoGenerateColumns = false;
            int Soluong = 0;
            foreach (var item in B)
            {
                if (item.MaDOANDL == Doanid)
                {
                    Soluong += item.Siso;
                }
            }
            txtTotal.Text = Soluong.ToString();
        }
        public void LoadDoan()
        {
            List<CHITIETCHIPHI> cp = cb.GetAlls();
           // List<BOOKING> B = bb.GetAll();
            double TongCong = 0;
            double GiaTour = 0;
            //int Soluong = 0;
            var json = JsonConvert.SerializeObject(dd.GetDDetail(Doanid));
            DataTable dataTableDetailsDoan = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            txtTenDoan.Text = dataTableDetailsDoan.Rows[0][1].ToString();
            cbbtour.SelectedIndex = cbbtour.FindString(dataTableDetailsDoan.Rows[0][4].ToString());
            cbbhdv.SelectedIndex = cbbhdv.FindString(dataTableDetailsDoan.Rows[0][5].ToString());
            dpk1.Text = dataTableDetailsDoan.Rows[0][2].ToString();
            dpk2.Text = dataTableDetailsDoan.Rows[0][3].ToString();
            GiaTour += Convert.ToDouble(dataTableDetailsDoan.Rows[0][7]);
            //txtGiaTour.Text = GiaTour.ToString();
            txtGiaTour.Text = String.Format("{0:n0}", GiaTour);
            foreach (var item in cp)
            {
                if (item.MaDOANDL == Doanid)
                {
                    TongCong += item.TongCong;
                }
            }
            txtTongCong.Text = String.Format("{0:n0}", TongCong);
            
            int A = (Convert.ToInt32(GiaTour) + Convert.ToInt32(TongCong));
            txtPrice.Text = String.Format("{0:n0}", A);

        }
        public void OnRowNumberChanged()
        {
            txtTotal.Text = dataGridView1.Rows.Count.ToString();
        }
        public bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenDoan.Text))
            {
                MessageBox.Show("Bắt buộc phải nhập tên!!!", "Caution!!!");
                txtTenDoan.Focus();
                return false;
            }
            return true;
        }
        public void Clear()
        {
            txtTenDoan.Text = "";
        }
        private void Edit()
        {
            List<DOANDL> listD = db.getall();
            List<TOURDULICH> listT = tb.GetAllTour();
            List<NHANVIEN> listN = nvb.GetAll();
            List<BOOKING> listB = bb.GetAll();
            if (Checked() == true)
            {
                TOURDULICH T = new TOURDULICH();
                DOANDL D = new DOANDL();
                BOOKING B = new BOOKING();
                D.TenDoan = txtTenDoan.Text;
                D.NgayKhoiHanh = DateTime.Parse(dpk1.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                D.NgayKetThuc = DateTime.Parse(dpk2.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                D.ChiPhi = Convert.ToDouble(txtTongCong.Text);
                D.TongTien = Convert.ToDouble(txtPrice.Text);
                D.Soluong = Convert.ToInt32(txtTotal.Text);
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
                        frmMain.LoadDanhSachDoan();
                        System.Diagnostics.Debug.WriteLine("Success");
                        Clear();
                        MessageBox.Show("Sửa thông tin thành công!");

                    } else
                    {
                        MessageBox.Show("Sửa thông tin thất bại ! Vui lòng kiểm tra lại thông tin!");
                    }    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Sửa thông tin thất bại ! Vui lòng kiểm tra lại thông tin!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }
        public void SoluongOnChange()
        {
            List<TOURDULICH> listT = tb.GetAllTour();
            List<NHANVIEN> listN = nvb.GetAll();
            DOANDL D = new DOANDL();
            D.Soluong = Convert.ToInt32(txtTotal.Text);   
               try
                {
                    if (db.SoLuong(D, Doanid))
                    {
                        frmMain.LoadDanhSachDoan();
                        System.Diagnostics.Debug.WriteLine("Success");
                        MessageBox.Show("Cập nhật số lượng thành công");
                    }
                    else
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
        public void GiaOnChange()
        {
            DOANDL D = new DOANDL();
            D.ChiPhi = Convert.ToDouble(txtTongCong.Text);
            D.TongTien = Convert.ToDouble(txtPrice.Text);
            try
            {
                if (db.GiaOnChange(D, Doanid))
                {
                    frmMain.LoadDanhSachDoan();
                    System.Diagnostics.Debug.WriteLine("Success");
                    MessageBox.Show("Cập nhật số lượng thành công");
                }
                else
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

        private void btnPrice_Click(object sender, EventArgs e)
        {
            frmPricing fP = new frmPricing(Doanid, Tourid, this);
            fP.ShowDialog();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
