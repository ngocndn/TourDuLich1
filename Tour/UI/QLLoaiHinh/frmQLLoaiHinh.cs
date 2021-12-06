using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.BUS; using Tour.DAO;

namespace Tour.UI.QLLoaiHinh
{
    public partial class frmQLLoaiHinh : Form
    {
        LoaiHinhBUS LHB = new LoaiHinhBUS();
        public frmQLLoaiHinh()
        {
            InitializeComponent();
            LoadLH();
        }
        public void LoadLH()
        {
            dataGridView_LoaiHinh.DataSource = LHB.GetLoaiHinh();
        }
        public void Clear()
        {
            txtTenLH.Text = "";
            txtDD.Text = "";
        }

        public bool Checked()
        {
            if(String.IsNullOrEmpty(txtTenLH.Text))
            {
                MessageBox.Show("Name is required!", "Caution");
                txtTenLH.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtDD.Text))
            {
                MessageBox.Show("Dac Diem is required!", "Caution");
                txtDD.Focus();
                return false;
            }
            return true;
        }

        public void Add()
        {
            if (Checked()==true)
            {
                try
                {
                    LOAIHINHDULICH LH = new LOAIHINHDULICH();
                    LH.TenLoaiHinh = txtTenLH.Text;
                    LH.LH_MoTa = txtDD.Text;
                    if(LHB.Add(LH))
                    {
                        MessageBox.Show("Success", "Notify");
                        LoadLH();
                        Clear();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed", "Caution");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
        public void Detail()
        {
            foreach (DataGridViewRow r in dataGridView_LoaiHinh.SelectedRows)
            {
                if (!String.Equals(r.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string LoaiHinhID = r.Cells[0].Value.ToString();
                    frmEditLH fE = new frmEditLH(int.Parse(LoaiHinhID), this);
                    fE.ShowDialog();
                }
            }
        }

        public void Del()
        {
            LOAIHINHDULICH LH = new LOAIHINHDULICH();
            if (dataGridView_LoaiHinh.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_LoaiHinh.SelectedRows)
                {
                    int LoaiHinhID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    LHB.Del(LH, LoaiHinhID);
                    LoadLH();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hình du lịch cần xóa", "Thông báo");
            }
        }


        private void frmQLLoaiHinh_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Detail();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Del();
            LoadLH();
        }
    }
}
