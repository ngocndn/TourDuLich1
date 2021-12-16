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

namespace Tour.UI.QLGia
{
    public partial class frmGia : Form
    {
        GiaBUS gb = new GiaBUS();
        public frmGia()
        {
            InitializeComponent();
            LoadGia();
        }

        public void LoadGia()
        {
            dataGridView1.DataSource = gb.GetGT();
            //dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
