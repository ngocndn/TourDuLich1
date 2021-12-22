using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.BUS;
using Tour.DAO;

namespace Tour.UI.QLDoan
{
    public partial class frmAdd : Form
    {
        KhachHangBUS kb = new KhachHangBUS();
        TourBUS tb = new TourBUS();
        BookingBUS bb = new BookingBUS();
        GiaBUS gb = new GiaBUS();
        public frmAdd(int DoanID,int TourID,frmEditDoan frmMain)
        {
            InitializeComponent();
            this.did = DoanID;
            this.tid = TourID;
            this.fMain = frmMain;
            LoadKH();
            LoadHK();
        }
        private frmEditDoan fMain;
        private int did { get; set; }
        private int tid { get; set; }
        public void LoadKH()
        {
            textBox1.Text = tid.ToString();
            dataGridView1.DataSource = kb.GetKhachHang();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void LoadHK()
        {
            dataGridView2.DataSource = bb.GetDetail(did);
            dataGridView2.AutoGenerateColumns = false;
        }
        public void AddHK()
        {
            try
            {
                BOOKING B = new BOOKING();
                B.MaDOANDL = did;
                B.MaTour = tid;
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    if (!String.Equals(r.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                    {
                        int KHID = Convert.ToInt32(r.Cells[0].Value.ToString());
                        B.MaKH = KHID;
                    }
                }
                B.GiaTour = 0;
                if(bb.Add(B))
                {
                    fMain.Show();
                    LoadHK();
                    fMain.LoadDSKH();
                    MessageBox.Show("Success", "Notify");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Failed", "Thông báo");
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
        public void XoaHK()
        {
            foreach (DataGridViewRow r in dataGridView2.SelectedRows)
            {
                if (!String.Equals(r.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    int bid = Convert.ToInt32(r.Cells[0].Value.ToString());
                    bb.Delete(bid);
                    LoadHK();
                    fMain.LoadDSKH();
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Chon HK muon xoa");
                }
            }
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            AddHK();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaHK();
        }
    }
}
