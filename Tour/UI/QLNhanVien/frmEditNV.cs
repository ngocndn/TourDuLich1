using Newtonsoft.Json;
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
    public partial class frmEditNV : Form
    {
        NhanVienBUS nvb = new NhanVienBUS();
        public frmEditNV(int NV_ID,frmNhanVien fM)
        {
            InitializeComponent();
            Main = fM;
            this.NV_ID = NV_ID; ShowNV();
        }
        private frmNhanVien Main;
        public int NV_ID { get; set; }
        public void ShowNV()
        {
            List<dynamic> listDetailsNhanVien = nvb.GetDetail(NV_ID);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsNhanVien);
            DataTable dataTableDetailsNhanVien = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            txtTenNV.Text = dataTableDetailsNhanVien.Rows[0][1].ToString();
            dp_NSNV.Value = Convert.ToDateTime(dataTableDetailsNhanVien.Rows[0][2]);
            txtSDT.Text = dataTableDetailsNhanVien.Rows[0][3].ToString();
        }

        bool KiemTraRangBuoc()
        {
            if (String.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Lưu ý!!!");
                txtTenNV.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập nhiệm vụ!", "Lưu ý!!!");
                txtSDT.Focus();
                return false;
            }

            //Kiểm tra kí tự đặc biệt và số
            Regex regex = new Regex(@"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]");
            if (regex.IsMatch(txtTenNV.Text))
            {
                MessageBox.Show("Tên nhân viên không được có số và kí tự đặc biệt!", "Lưu ý!!!");
                txtTenNV.Focus();
                return false;
            }


            return true;
        }
        public void Clear()
        {
            txtTenNV.Text = txtSDT.Text = "";
        }

        public void SuaNhanVien()
        {

            if (KiemTraRangBuoc() == true)
            {

                //Khai báo object
                NHANVIEN NV = new NHANVIEN();

                NV.TenNV = txtTenNV.Text;
                NV.NV_SoDienThoai = txtSDT.Text;
                NV.NV_NgaySinh = dp_NSNV.Value;
                //Bắt đầu sửa các dữ liệu
                try
                {
                    if (nvb.SuaNhanVien(NV, NV_ID))
                    {
                        System.Diagnostics.Debug.WriteLine("Sửa nhân viên thành công!");
                        Clear();
                        Main.LoadNV();
                        MessageBox.Show("Sửa nhân viên thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công!", "Lưu ý!!!");
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
        }

        private void frmEditNV_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SuaNhanVien();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
