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
        TourBUS tb = new TourBUS();
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
        public void Search()
        {
            if (!String.IsNullOrWhiteSpace(txtsearch.Text))
            {
                string searchValue = txtsearch.Text;

                dataGridView_LoaiHinh.DataSource = LHB.Search(searchValue);

            }
            else
            {
                LoadLH();
            }
        }
        public bool Checked()
        {
            if(String.IsNullOrEmpty(txtTenLH.Text))
            {
                MessageBox.Show("Nhập tên!", "Lưu ý!!!");
                txtTenLH.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtDD.Text))
            {
                MessageBox.Show("Nhập đặc điểm!", "Lưu ý!!!");
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
                        MessageBox.Show("Thêm thành công");
                        LoadLH();
                        Clear();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm thất bại!", "Lưu ý!!!");
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
            TOURDULICH T = new TOURDULICH();
            List<TOURDULICH> listT = tb.GetAllTour();
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
            var Delete = MessageBox.Show("Dữ liệu sẽ bị xóa vĩnh viễn!", "Lưu ý!!!", MessageBoxButtons.YesNo);
            if (Delete == DialogResult.Yes)
            {
                Del();
                LoadLH();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
