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

namespace Tour.UI.QLKhachHang
{
    public partial class frmEditKhachHang : Form
    {
        KhachHangBUS khb = new KhachHangBUS();   
        public frmEditKhachHang(int KH_ID, frmKhachHang fK)
        {
            InitializeComponent();
            Main = fK;
            this.KH_ID = KH_ID;
            ShowKH();
        }
        private frmKhachHang Main;
        public int KH_ID { get; set; }

        public void ShowKH()
        {
            List<dynamic> listDetailsKhachhang = khb.GetListDetailsKhachHang(KH_ID);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsKhachhang);
            DataTable dataTableDetailsKhachHang = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            txtTenKH.Text = dataTableDetailsKhachHang.Rows[0][1].ToString();
            dp_NSKH.Value = Convert.ToDateTime(dataTableDetailsKhachHang.Rows[0][2]);
            txtDiaChi.Text = dataTableDetailsKhachHang.Rows[0][3].ToString();
            txtSDT.Text = dataTableDetailsKhachHang.Rows[0][4].ToString();
            txtGioiTinh.Text = dataTableDetailsKhachHang.Rows[0][5].ToString();
            txtEmail.Text = dataTableDetailsKhachHang.Rows[0][6].ToString();
            txtCMND.Text = dataTableDetailsKhachHang.Rows[0][7].ToString();
        }
        public void Clear()
        {
            txtTenKH.Text = txtSDT.Text = txtEmail.Text = txtDiaChi.Text = txtCMND.Text = "";
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

            if (String.IsNullOrEmpty(txtGioiTinh.Text))
            {
                MessageBox.Show("GT is required", "Caution!!!");
                txtGioiTinh.Focus();
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
        public void SuaKhachHang()
        {
            if (Checked())
            {
                try
                {
                    KHACHHANG KH = new KHACHHANG();
                    KH.TenKH = txtTenKH.Text;
                    KH.KH_NgaySinh = dp_NSKH.Value;
                    KH.KH_DiaChi = txtDiaChi.Text;
                    KH.KH_SoDienThoai = txtSDT.Text;
                    KH.KH_GioiTinh = txtGioiTinh.Text;
                    KH.KH_email = txtEmail.Text;
                    KH.KH_CMND = txtCMND.Text;
                   
                    if (khb.SuaKhachHang(KH, KH_ID))
                    {
                        Main.LoadKH();
                        Clear();
                        MessageBox.Show("Success", "Notify");

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed", "Caution!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        private void frmEditKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SuaKhachHang();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
