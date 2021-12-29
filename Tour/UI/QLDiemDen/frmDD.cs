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
using Tour.BUS;
using Tour.DAO;

namespace Tour.UI.QLDiemDen
{
    public partial class frmDD : Form
    {
        DiaDiemBUS DDB = new DiaDiemBUS();
        public frmDD()
        {
            InitializeComponent();
            LoadDiaDiem();
        }
        public void LoadDiaDiem()
        {
            dataGridView_DiaDiem.DataSource = DDB.GetListDD();
        }
        public void Clear()
        {
            txtTenDD.Text = "";
            txtDD.Text = "";
        }
        public bool Checked()
        {
            if(String.IsNullOrEmpty(txtTenDD.Text))
            {
                MessageBox.Show("Nhập tên địa điểm","Lưu ý!!!");
                txtTenDD.Focus();
                return false;
            }
            if(String.IsNullOrEmpty(txtDD.Text))
            {
                MessageBox.Show("Nhập đặc điểm", "Lưu ý!!!");
                txtDD.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTenDD.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt", "Lưu ý!!!");
                txtTenDD.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDD.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt", "Lưu ý!!!");
                txtDD.Focus();
                return false;
            }


            return true;
        }

        public void AddDiaDiem()
        {
            if(Checked()==true)
            {
                try
                {
                    DIADIEM DD = new DIADIEM();
                    DD.TenDiaDiem = txtTenDD.Text;
                    DD.DD_MoTa = txtDD.Text;
                    if(DDB.AddDiaDiem(DD))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadDiaDiem();
                        Clear();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm thất bại", "Lưu ý!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        public void DelDiaDiem()
        {
            DIADIEM DD = new DIADIEM();
            if(dataGridView_DiaDiem.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow r in dataGridView_DiaDiem.SelectedRows)
                {
                    int ID = Convert.ToInt32(r.Cells[0].Value.ToString());
                    DDB.DelDiaDiem(DD, ID);
                    LoadDiaDiem();
                    MessageBox.Show("Đã xóa");
                    Clear();
                }
            }
        }

        public void Detail()
        {
            foreach (DataGridViewRow r in dataGridView_DiaDiem.SelectedRows)
            {
                if (!String.Equals(r.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string ID = r.Cells[0].Value.ToString();
                    frmEditDD fED = new frmEditDD(int.Parse(ID), this);
                    fED.ShowDialog();
                }
            }
        }
        public void Search()
        {
            if (!String.IsNullOrWhiteSpace(txtsearch.Text))
            {
                string searchValue = txtsearch.Text;

                dataGridView_DiaDiem.DataSource = DDB.Search(searchValue);

            }
            else
            {
                LoadDiaDiem();
            }
        }

        private void frmDD_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDiaDiem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DelDiaDiem();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Detail();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
