using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using Tour.DAO; using Tour.BUS;
using System.Text.RegularExpressions;

namespace Tour.UI.QLKhachHang
{
    public partial class frmKhachHang : Form
    {
        KhachHangBUS khb = new KhachHangBUS();
        BookingBUS bb = new BookingBUS();
        public frmKhachHang()
        {
            InitializeComponent();
            LoadCBBGIoiTinh();
            LoadKH();
        }
        public void LoadKH()
        {
            dataGridView1.DataSource = khb.GetKhachHang();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void LoadCBBGIoiTinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedItem = "Nam";
        }
        public void Clear()
        {
            txtTenKH.Text = txtSDT.Text = txtEmail.Text = txtDiaChi.Text = txtCMND.Text = dp_NSKH.Text = "";

        }

        private bool Checked()
        {
            if (String.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Nhập tên khách hàng!", "Lưu ý!!!");
                txtTenKH.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Nhập số điện thoại khách hàng!", "Lưu ý!!!");
                txtSDT.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(cbbGioiTinh.Text))
            {
                MessageBox.Show("Nhập giới tính khách hàng!", "Lưu ý!!!");
                cbbGioiTinh.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Nhập Email khách hàng!", "Lưu ý!!!");
                txtEmail.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Nhập địa chỉ khách hàng!", "Lưu ý!!!");
                txtDiaChi.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("Nhập CMND khách hàng!", "Lưu ý!!!");
                txtCMND.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtSDT.Text, @"^(0+[0-9]{9})$"))
            {
                MessageBox.Show("Số điện thoại gồm 10 chữ số và bắt đầu bằng 0", "Lưu ý!!!");
                txtSDT.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtCMND.Text, @"^([0-9]{9})$"))
            {

                MessageBox.Show("Số CMND gồm 9 chữ số", "Lưu ý!!!");
                txtCMND.Focus();
                return false;
            }
            return true;
        }

        public void Add()
        {
            if (Checked())
            {
                try
                {
                    KHACHHANG KH = new KHACHHANG();
                    KH.TenKH = txtTenKH.Text;
                    KH.KH_CMND = txtCMND.Text;
                    KH.KH_DiaChi = txtDiaChi.Text;
                    KH.KH_GioiTinh = cbbGioiTinh.Text;
                    KH.KH_email = txtEmail.Text;
                    KH.KH_SoDienThoai = txtSDT.Text;
                    KH.KH_NgaySinh = dp_NSKH.Value;
                    

                    if (khb.ThemKhachHang(KH))
                    {
                        LoadKH();
                        Clear();
                        MessageBox.Show("Thêm khách hàng thành công");

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm thất bại!Kiểm tra lại dữ liệu nhập!", "Lưu ý!!!");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        public void Del()
        {
            List<BOOKING> lB = bb.GetAll();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int KH_ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    khb.XoaKhachHang(KH_ID);
                    foreach (var item in lB)
                    {
                        if (KH_ID == item.MaKH)
                        {
                            if (bb.DeleteKH(item.MaKH))
                            {
                                System.Diagnostics.Debug.WriteLine("Xóa khách hàng thành công!");
                            }
                        }
                    }
                    LoadKH();
                    MessageBox.Show("Xóa thành công");

                }
            }
            else
            {
                MessageBox.Show("Chọn khách hàng để xóa!", "Lưu ý!!!");
            }
        }
        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string KH_ID = row.Cells[0].Value.ToString();

                    frmEditKhachHang formChiTietKhachHang = new frmEditKhachHang(int.Parse(KH_ID),this);

                    formChiTietKhachHang.ShowDialog();

                }
            }
        }
        public void Search()
        {
            if (!String.IsNullOrWhiteSpace(txtsearch.Text))
            {
                string searchValue = txtsearch.Text;

                dataGridView1.DataSource = khb.Searching(searchValue);

            }
            else
            {
                LoadKH();
            }
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Delete = MessageBox.Show("Dữ liệu sẽ bị xóa vĩnh viễn!", "Lưu ý!!!", MessageBoxButtons.YesNo);
            if (Delete == DialogResult.Yes)
            {
                Del();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            XemChiTiet();
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
