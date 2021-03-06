using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using Tour.DAO;using Tour.BUS;using Tour.UI.QLGia;

namespace Tour.UI.QLTour
{
    public partial class frmGia : Form
    {
        GiaBUS gb = new GiaBUS();
        TourBUS tb = new TourBUS();
        public frmGia(int ID, frmDETAIL fD)
        {
            InitializeComponent();
            Main = fD;
            this.T_ID = ID;
            ShowDetail();
        }

        private frmDETAIL Main;
        public int T_ID { get; set; }

        private void ShowDetail()
        {
            txtMaTour.Text = T_ID.ToString();
            dataGridView1.DataSource = gb.GetGiaTourWithMaTour(T_ID);
            dataGridView1.Columns["Column5"].DefaultCellStyle.Format = "#,##0";
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Nhập giá", "Lưu ý!!!");
                txtGia.Focus();
                return false;
            }

            return true;
        }
     

        public void ThemGiaTour()
        {
            if (Checked()==true)
            {
                try
                {
                    GIATOUR G = new GIATOUR();
                    G.ThanhTien = Convert.ToDouble(txtGia.Text);
                    G.MaTour = T_ID;
                    G.TGKetThuc = dateTimePicker1.Value;
                    G.TGBatDau = DateTime.Now;
                    G.STT = 1;
                    if(gb.ThemGiaTour(G))
                    {
                        Main.Show();
                        ShowDetail();
                        Clear();
                        MessageBox.Show("Thêm giá thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm giá thất bại", "Lưu ý!!!");
                    }
                }
                catch(Exception e)
                {
                    //MessageBox.Show("Giá tour phải là số!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
        public void Clear()
        {
            txtGia.Text = "";
        }
        private void frmGia_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ThemGiaTour();
        }
        public void Apply()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                    {
                        int IDGIATOUR = Convert.ToInt32(row.Cells[0].Value.ToString());
                        int TID = Convert.ToInt32(txtMaTour.Text);

                        TOURDULICH T = new TOURDULICH();
                        T.IDGiaTour = IDGIATOUR;


                        if (tb.SuaGiaTour(T, TID))
                        {
                            MessageBox.Show("Áp dụng giá thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Áp dụng giá KHÔNG thành công!", "Lưu ý!!!");
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giá muốn áp dụng!", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
