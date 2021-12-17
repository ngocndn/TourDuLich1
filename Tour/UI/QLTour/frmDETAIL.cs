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

namespace Tour.UI.QLTour
{
    public partial class frmDETAIL : Form
    {
        TourBUS tb = new TourBUS();
        DiaDiemBUS db = new DiaDiemBUS();
        LoaiHinhBUS lb = new LoaiHinhBUS();
        public frmDETAIL(int T_ID, frmQLTOUR fT)
        {
            InitializeComponent();
            Main = fT;
            this.ID = T_ID;
            LoadCB();LoadCB1();
            ShowT();

        }
        public void LoadCB()
        {
            comboBox_DiaDiem.DataSource = db.GetListDD();
            comboBox_DiaDiem.DisplayMember = "TenDiaDiem";
        }
        public void LoadCB1()
        {
            comboBox_LoaiHinh.DataSource = lb.GetLoaiHinh();
            comboBox_LoaiHinh.DisplayMember = "TenLoaiHinh";
        }
        private frmQLTOUR Main;
        public int ID { get; set; }

        public void ShowT()
        {
            List<dynamic> listDetailsTour = tb.GetTourDetailList(ID);
            var json = JsonConvert.SerializeObject(listDetailsTour);
            DataTable dataTableDetailsTour = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            txtTenTour.Text = dataTableDetailsTour.Rows[0][1].ToString();
            txtDD.Text = dataTableDetailsTour.Rows[0][4].ToString();
            comboBox_DiaDiem.SelectedIndex = comboBox_DiaDiem.FindString(dataTableDetailsTour.Rows[0][3].ToString());
            comboBox_LoaiHinh.SelectedIndex = comboBox_LoaiHinh.FindString(dataTableDetailsTour.Rows[0][2].ToString());
        }
        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenTour.Text))
            {
                MessageBox.Show("Ten is required", "Caution!!!");
                txtTenTour.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDD.Text))
            {
                MessageBox.Show("DD is required", "Caution!!!");
                txtDD.Focus();
                return false;
            }
            return true;
        }

        private void Edit()
        {
            List<DIADIEM> listDD = db.GetListDD();
            List<LOAIHINHDULICH> listLH = lb.GetLoaiHinh();
            List<TOURDULICH> listT = tb.GetAllTour();
            if(Checked()==true)
            {
                TOURDULICH T = new TOURDULICH();
                T.TenTour = txtTenTour.Text;
                T.DacDiem = txtDD.Text;
                foreach (var itemDD in listDD)
                {
                    if (itemDD.TenDiaDiem.Equals(comboBox_DiaDiem.Text))
                    {
                        T.MaDiaDiem = itemDD.MaDiaDiem;
                    }
                }
                foreach (var itemLHDL in listLH)
                {
                    if (itemLHDL.TenLoaiHinh.Equals(comboBox_LoaiHinh.Text))
                    {
                        T.MaLoaiHinh = itemLHDL.MaLoaiHinh;
                    }
                }
                    try
                {
                    if(tb.EditTour(T, ID))
                    {
                        System.Diagnostics.Debug.WriteLine("Sửa tour thành công!");
                        Main.LoadTour();
                        MessageBox.Show("Success!", "Notify");

                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("FAILED!", "CAUTION!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        private void frmDETAIL_Load(object sender, EventArgs e)
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

        private void btnPricing_Click(object sender, EventArgs e)
        {
            frmGia fG = new frmGia(ID, this);
            fG.ShowDialog();
        }
    }
}
