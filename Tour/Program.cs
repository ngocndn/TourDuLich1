using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.UI.QLLoaiHinh;using Tour.UI.QLDiemDen;using Tour.UI.QLTour;using Tour.UI.QLNhanVien;
using Tour.UI.QLKhachHang;

namespace Tour
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmQLTOUR());
           // dtgvDetail.DataSource = 
        }
    }
}
