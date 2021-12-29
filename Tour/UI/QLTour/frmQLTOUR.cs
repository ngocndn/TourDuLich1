using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tour.BUS;
using Tour.DAO;

namespace Tour.UI.QLTour
{
    public partial class frmQLTOUR : Form
    {
        TourBUS tb = new TourBUS();
        DiaDiemBUS db = new DiaDiemBUS();
        LoaiHinhBUS lb = new LoaiHinhBUS();
        GiaBUS gb = new GiaBUS();
        DoanBUS ddb = new DoanBUS();

        public frmQLTOUR()
        {
            InitializeComponent();
            LoadTour();
            LoadCB();
            LoadCB1();
        }
        public void LoadTour()
        {
            dataGridView1.DataSource = tb.GetTourList();
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
        private void ClearFields()
        {
            txtTenTour.Text = "";
            txtDD.Text = "";

        }
        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenTour.Text))
            {
                MessageBox.Show("Nhập tên Tour", "Lưu ý!!!");
                txtTenTour.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDD.Text))
            {
                MessageBox.Show("Nhập đặc điểm Tour", "Lưu ý!!!");
                txtDD.Focus();
                return false;
            }
            return true;
        }

        public void Add()
        {
            List<DIADIEM> listDD = db.GetListDD();
            List<LOAIHINHDULICH> listLH = lb.GetLoaiHinh();
            List<TOURDULICH> listT = tb.GetAllTour();
            if (Checked() == true)
            {
                TOURDULICH T = new TOURDULICH();
                GIATOUR G = new GIATOUR();
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
                    if (tb.AddTour(T))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadTour();
                    }

                    if (gb.ThemGiaTour(G))
                    {
                        LoadTour();
                        System.Diagnostics.Debug.WriteLine("Thêm giá tour thành công!");
                        ClearFields();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm thất bại", "Lưu ý!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }


        public void Del()
        {
            GIATOUR g = new GIATOUR();
            DOANDL d = new DOANDL();
            List<GIATOUR> lG = gb.GetGiaTour();
            List<DOANDL> lD = ddb.getall();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int T_ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    tb.DelTour(T_ID);
                    foreach(var item in lG)
                    {
                        if(T_ID==item.MaTour)
                        {
                            if (gb.XoaGiaTour(g, item.MaTour))
                            {
                                System.Diagnostics.Debug.WriteLine("Xóa giá tour thành công!");
                            }
                        }
                    } 
                    foreach(var item in lD)
                    {
                        if (T_ID == item.MaTour)
                        {
                           if(ddb.DeletefromTour(d,item.MaTour))
                            {
                                System.Diagnostics.Debug.WriteLine("Da xoa doan");
                            }
                        }
                    }
                    LoadTour();
                    MessageBox.Show("Xóa thành công");
                }
                

            }
            else
            {
                MessageBox.Show("Chọn Tour để xóa", "Lưu ý!!!");
            }
        }

        public void Search()
        {
            if(!String.IsNullOrEmpty(txtsearch.Text))
            {
                string searchValue = txtsearch.Text;
                dataGridView1.DataSource = tb.SearchTour(searchValue);
            }
            else
            {
                LoadTour();
            }
        }
        private void frmQLTOUR_Load(object sender, EventArgs e)
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Detail();
        }
        private void Detail()
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!String.Equals(r.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string ID = r.Cells[0].Value.ToString();
                    frmDETAIL fED = new frmDETAIL(int.Parse(ID), this);
                    fED.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
