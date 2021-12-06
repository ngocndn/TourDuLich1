using Newtonsoft.Json;
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
    public partial class frmEditDD : Form
    {
        DiaDiemBUS DDB = new DiaDiemBUS();
        private frmDD Main;
        public int ID { get; set; }
        public frmEditDD(int ID, frmDD DD)
        {
            InitializeComponent();
            Main = DD;
            this.ID = ID;
            ShowDD();
        }
        public void ShowDD()
        {
            List<dynamic> DiaDiem = DDB.GetDiaDiemDetailList(ID);
            var DD = JsonConvert.SerializeObject(DiaDiem);
            DataTable D = (DataTable)JsonConvert.DeserializeObject(DD, (typeof(DataTable)));
            txtTenDD.Text = D.Rows[0][1].ToString();
            txtDD.Text = D.Rows[0][2].ToString();
        }
        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenDD.Text))
            {
                MessageBox.Show("TenDD is required!", "Caution!!!");
                txtTenDD.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDD.Text))
            {
                MessageBox.Show("DD is required!", "Caution!!!");
                txtDD.Focus();
                return false;
            }
            Regex regex = new Regex(@"[""!#$%&'*+,-./:;<=>?@[\\\]^_`{|}]");
            if (regex.IsMatch(txtTenDD.Text))
            {
                MessageBox.Show("No Special Char!", "Caution!!!");
                txtTenDD.Focus();
                return false;
            }
            if (regex.IsMatch(txtDD.Text))
            {
                MessageBox.Show("No Special Char!", "Caution!!!");
                txtDD.Focus();
                return false;
            }
            return true;
        }
        public void Edit()
        {
            if(Checked()==true)
            {
                DIADIEM DD = new DIADIEM();
                DD.TenDiaDiem = txtTenDD.Text;
                DD.DD_MoTa = txtDD.Text;
                try
                {
                    if(DDB.EditDiaDiem(DD,ID))
                    {
                        System.Diagnostics.Debug.Write("Success");
                        Main.LoadDiaDiem();
                        MessageBox.Show("Success", "Notify");
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("Failed!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        private void frmEditDD_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
