using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using Tour.BUS;using Tour.DAO;

namespace Tour.UI.QLGia
{
    public partial class frmDetailGia : Form
    {
        GiaBUS gb = new GiaBUS();
        public frmDetailGia()
        {
            InitializeComponent();
            LoadGia();
        }
        public void LoadGia()
        {
            dataGridView1.DataSource = gb.GetGia();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["Column2"].DefaultCellStyle.Format = "#,##0";
        }

        private void frmDetailGia_Load(object sender, EventArgs e)
        {

        }
    }
}
