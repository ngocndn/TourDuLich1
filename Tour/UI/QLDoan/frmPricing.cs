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
            LoadCP();
            LoadCBB();
        }
        public void LoadCP()
        {
            dataGridView1.DataSource = cb.GetListDoanID(Doanid);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["Column3"].DefaultCellStyle.Format = "#,##0";

        }
        public void LoadCBB()
        {
            cbbcp.DataSource = cb.GetAll();
            cbbcp.DisplayMember = "TenCP";
        }
        public void LoadDetail()
        {
            txtmadoan.Text = Doanid.ToString();
            txtmatour.Text = tid.ToString();
        }
        public bool Checked()
        {
            if (String.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Nhập giá!!!!", "Lưu ý!!!");
                txtprice.Focus();
                return false;
            }
            return true;
        }
        public void Add()
        {
            List<LOAICHIPHI> ll = cb.GetAllCP();
            if(Checked() == true)
            {
                try
                {
                    CHITIETCHIPHI c = new CHITIETCHIPHI();
                    c.TenCP = cbbcp.Text;
                    c.MaDOANDL = this.Doanid;
                    c.TongCong = Convert.ToDouble(txtprice.Text);
                    foreach (var item in ll)
                    {
                        if (item.TenLoaiCP.Equals(cbbcp.Text))
                        {
                            c.ChiPhi_ID = item.LoaiCP_ID;
                        }
                    }
                    if (cb.Addct(c))
                    {
                        LoadCP();
                        fM.LoadDoan();
                        fM.GiaOnChange();
                        MessageBox.Show("Thêm chi phí thành công!", "Thông báo");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Tổng chi phí chỉ được nhập số!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("KiemTra");
            }
        }
        public void Del()
        {
            if(dataGridView1.SelectedRows.Count!=-1)
            {
                foreach(DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    if(!String.Equals(r.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                    {
                        int id = Convert.ToInt32(r.Cells[0].Value.ToString());
                            if(cb.XoaCTCP(id))
                        {
                            LoadCP();
                            fM.LoadDoan();
                            fM.GiaOnChange();
                            MessageBox.Show("Xóa chi phí thành công!", "Thông báo");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn giá");
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Del();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
