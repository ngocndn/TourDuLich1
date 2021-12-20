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

namespace Tour.UI.QLChiPhi
{
    public partial class frmEditCP : Form
    {
        ChiPhiBUS cb = new ChiPhiBUS();
        public frmEditCP(int cp_id, frmChiPhi Main)
        {
            InitializeComponent();
            frmMain = Main;
            this.CP_ID = cp_id;
            Loadcbb();
            ShowCP();
        }
        public int CP_ID { get; set; }
        private frmChiPhi frmMain;
        public void Loadcbb()
        {
            cbbcp.DataSource = cb.GetAllCP();
            cbbcp.DisplayMember = "TenLoaiCP";
        }
        public void ShowCP()
        {
            List<dynamic> listDetailsNhanVien = cb.GetDetail(CP_ID);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsNhanVien);
            DataTable dataTableDetailsNhanVien = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            txtTencp.Text = dataTableDetailsNhanVien.Rows[0][1].ToString();
            txtGia.Text = dataTableDetailsNhanVien.Rows[0][3].ToString();
            cbbcp.SelectedIndex = cbbcp.FindString(dataTableDetailsNhanVien.Rows[0][2].ToString());
            
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

        public void EditCP()
        {
            List<CHIPHI> lc = cb.GetAll();
            List<LOAICHIPHI> lcb = cb.GetAllCP();

            if (Checked() == true)
            {
                CHIPHI cp = new CHIPHI();
                cp.TenCP = txtTencp.Text;
                cp.ThanhTien = float.Parse(txtGia.Text);
                foreach (var item in lcb)
                {
                    if (item.TenLoaiCP.Equals(cbbcp.Text))
                    {
                        cp.LoaiCP_ID = item.LoaiCP_ID;
                    }
                }
                //Bắt đầu sửa các dữ liệu
                try
                {
                    if (cb.Sua(cp, CP_ID))
                    {
                        System.Diagnostics.Debug.WriteLine("Sửa nhân viên thành công!");

                        frmMain.Loadcp();
                        MessageBox.Show("Sửa nhân viên thành công!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
        }
        private void frmEditCP_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditCP();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
