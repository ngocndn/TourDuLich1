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
        DoanBUS db = new DoanBUS();
        public frmThongKe()
        {
            InitializeComponent();
            LoadChart();
        }
        public void LoadChart()
        {
            chart1.DataSource = db.getall();
            chart1.Series["DOANDL"].XValueMember = "TenDoan";
            chart1.Series["DOANDL"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["DOANDL"].YValueMembers = "Soluong";
            chart1.Series["DOANDL"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
