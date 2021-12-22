using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.BUS;using Tour.DAO;

namespace Tour.UI.QLDoan
{
    public partial class frmPricing : Form
    {
        KhachHangBUS kb = new KhachHangBUS();
        TourBUS tb = new TourBUS();
        BookingBUS bb = new BookingBUS();
        GiaBUS gb = new GiaBUS();
        ChiPhiBUS cb = new ChiPhiBUS();
        private int Doanid { get; set; }
        private int tid { get; set; }
        private frmEditDoan fM;
        public frmPricing(int DoanID, int TourID, frmEditDoan fMain)
        {
            InitializeComponent();
            this.Doanid = DoanID;
            this.tid = TourID;
            this.fM = fMain;
            LoadDetail();
            ShowGiaTour();
        }
        public void LoadDetail()
        {
            txtmadoan.Text = Doanid.ToString();
            txtmatour.Text = tid.ToString();
        }

        public void ShowGiaTour()
        {
            List<dynamic> listT = gb.GetGiaByMa(tid);
            var json = JsonConvert.SerializeObject(listT);
            DataTable dataTableDetailsDoan = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            txtgiatour.Text = dataTableDetailsDoan.Rows[0][2].ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPricing_Load(object sender, EventArgs e)
        {

        }

    }
}
