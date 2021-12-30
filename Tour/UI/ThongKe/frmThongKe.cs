using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.DAO;using Tour.BUS;

namespace Tour.UI.ThongKe
{
    public partial class frmThongKe : Form
    {
        ThongKeBUS tb = new ThongKeBUS();
        DoanBUS db = new DoanBUS();
        public frmThongKe()
        {
            InitializeComponent();
            LoadChart();
            loading();
        }
        public void loading()
        {
            int N = 10;
            dataGridView1.DataSource = tb.GetLanThamGia(N);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.DataSource = tb.GetDoanhThu();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns["Column2"].DefaultCellStyle.Format = "#,##0";
            dataGridView2.Columns["Column7"].DefaultCellStyle.Format = "#,##0";
        }
        public void LoadChart()
        {
            chart1.DataSource = db.getall();
            chart1.Series["DOANDL"].XValueMember = "TenDoan";
            chart1.Series["DOANDL"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["DOANDL"].YValueMembers = "Soluong";
            chart1.Series["DOANDL"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chart2.DataSource = tb.GetDoanhThu();
            chart2.Series["DOANHTHU"].XValueMember = "TenDoan";
            chart2.Series["DOANHTHU"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series["DOANHTHU"].YValueMembers = "DoanhThu";
            chart2.Series["DOANHTHU"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            int N = 5;
            chart3.DataSource = tb.GetLanThamGia(N);
            chart3.Series["KHACHHANG"].XValueMember = "TenKH";
            chart3.Series["KHACHHANG"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart3.Series["KHACHHANG"].YValueMembers = "SoLanThamGia";
            chart3.Series["KHACHHANG"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            chart4.DataSource = tb.GetLanThamGiaNV(N);
            chart4.Series["HDV"].XValueMember = "TenNV";
            chart4.Series["HDV"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart4.Series["HDV"].YValueMembers = "SoLanThamGia";
            chart4.Series["HDV"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            chart5.DataSource = tb.GetTourTheoLH();
            chart5.Series["TourLH"].XValueMember = "TenLoaiHinh";
            chart5.Series["TourLH"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart5.Series["TourLH"].YValueMembers = "SoTour";
            chart5.Series["TourLH"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
