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
        public int GetMaxIDGiaTour(List<GIATOUR> list)
        {
            if (list.Count == 0)
            {
                return 1;
            }
            int maxID = 0;
            foreach (GIATOUR type in list)
            {
                if (type.IDGIATOUR > maxID)
                {
                    maxID = type.IDGIATOUR;
                }
            }
            return maxID;
        }

        public int GetMaxIDTour(List<TOURDULICH> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }
            int maxID = 0;
            foreach (TOURDULICH type in list)
            {
                if (type.MaTour > maxID)
                {
                    maxID = type.MaTour;
                }
            }
            return maxID;
        }

        public void Add()
        {
            List<DIADIEM> listDD = db.GetListDD();
            List<LOAIHINHDULICH> listLH = lb.GetLoaiHinh();
            List<TOURDULICH> listT = tb.GetAllTour();
            List<GIATOUR> listG = gb.GetAllGiaTour();
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

                //Lấy maLoaiHinhDuLich
                foreach (var itemLHDL in listLH)
                {
                    if (itemLHDL.TenLoaiHinh.Equals(comboBox_LoaiHinh.Text))
                    {
                        T.MaLoaiHinh = itemLHDL.MaLoaiHinh;
                    }
                }
                G.ThanhTien = float.Parse(txtGiaTour.Text);
                T.IDGiaTour = GetMaxIDGiaTour(listG)+1;
                G.MaTour = GetMaxIDTour(listT) + 1;
                try
                {
                    if (tb.AddTour(T))
                    {
                        MessageBox.Show("Success", "Notify");
                        LoadTour();
                    }

                    if (gb.ThemGiaTour(G))
                    {
                        LoadTour();
                        System.Diagnostics.Debug.WriteLine("Thêm giá tour thành công!");
                        MessageBox.Show("Thêm tour thành công!", "Thông báo");
                        ClearFields();

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("FAILED", "Caution!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }


        public void Del()
        {
            List<GIATOUR> listG = gb.GetAllGiaTour();
            GIATOUR g = new GIATOUR();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int T_ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    tb.DelTour(T_ID);
                    LoadTour();
                    MessageBox.Show("Deleted", "Notify");
                    foreach (var itemGiaTour in listG)
                    {
                        if (T_ID == itemGiaTour.MaTour)
                        {
                            if (gb.XoaGiaTour(g, itemGiaTour.IDGIATOUR))
                            {
                                System.Diagnostics.Debug.WriteLine("Xóa giá tour thành công!");
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Choose someone to delete", "Caution!!!");
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
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string T_ID = row.Cells[0].Value.ToString();
                    frmDETAIL formChiTietTour = new frmDETAIL(int.Parse(T_ID), this);
                    formChiTietTour.ShowDialog();

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
