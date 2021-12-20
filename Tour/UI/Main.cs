using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.UI.QLDiemDen;
using Tour.UI.QLKhachHang;
using Tour.UI.QLLoaiHinh;
using Tour.UI.QLNhanVien;
using Tour.UI.QLTour;
using Tour.UI.QLDoan;
using Tour.UI.QLChiPhi;


namespace Tour.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQLTOUR fT = new frmQLTOUR();
            fT.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmNhanVien fN = new frmNhanVien();
            fN.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmChiPhi fc = new frmChiPhi();
            fc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmQLLoaiHinh fL = new frmQLLoaiHinh();
            fL.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDD fD = new frmDD();
            fD.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKhachHang fK = new frmKhachHang();
            fK.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmQLDoan fd = new frmQLDoan();
            fd.ShowDialog();
        }
    }
}
