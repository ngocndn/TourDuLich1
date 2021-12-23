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
using Tour.BUS; using Tour.DAO;

namespace Tour.UI.QLLoaiHinh
{
    public partial class frmEditLH : Form
    {
        LoaiHinhBUS LHB = new LoaiHinhBUS();
        private frmQLLoaiHinh Main;
        public int LoaiHinhID { get; set; }
        public frmEditLH(int LoaiHinhID, frmQLLoaiHinh LH)
        {
            InitializeComponent();
            Main = LH;
            this.LoaiHinhID = LoaiHinhID;
            showLH();
        }
        public void showLH()
        {
            List<dynamic> loaiHinh = LHB.GetDetailList(LoaiHinhID);
            var LH = JsonConvert.SerializeObject(loaiHinh);
            DataTable L = (DataTable)JsonConvert.DeserializeObject(LH, (typeof(DataTable)));
            txtTenLH.Text = L.Rows[0][1].ToString();
            txtDD.Text = L.Rows[0][2].ToString();
        }
        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenLH.Text))
            {
                MessageBox.Show("Nhap Loai Hinh!", "Thông báo");
                txtTenLH.Focus();
                return false;
            }
            Regex regex = new Regex(@"[""!#$%&'*+,-./:;<=>?@[\\\]^_`{|}]");
            if (regex.IsMatch(txtTenLH.Text))
            {
                MessageBox.Show("!", "Thông báo");
                txtTenLH.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtDD.Text))
            {
                MessageBox.Show("Nhap Loai Hinh!", "Thông báo");
                txtTenLH.Focus();
                return false;
            }
            
            if (regex.IsMatch(txtDD.Text))
            {
                MessageBox.Show("!", "Thông báo");
                txtTenLH.Focus();
                return false;
            }
            return true;
        }
        public void Edit()
        {
            if (Checked() == true)
            {
                LOAIHINHDULICH LH = new LOAIHINHDULICH();
                LH.TenLoaiHinh = txtTenLH.Text;
                LH.LH_MoTa = txtDD.Text;
                try
                {
                    if (LHB.Edit(LH, LoaiHinhID))
                    {
                        System.Diagnostics.Debug.WriteLine("Success");
                        Main.LoadLH();
                        Clear();
                        MessageBox.Show("Success");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
        public void Clear()
        {
            txtTenLH.Text = txtDD.Text = "";
        }
        private void frmEditLH_Load(object sender, EventArgs e)
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
