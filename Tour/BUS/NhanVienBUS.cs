using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvd = new NhanVienDAO();
        public List<NHANVIEN> GetAll()
        {
            return nvd.GetAllNhanVien();
        }

        public List<dynamic> GetListNV()
        {
            return nvd.GetListNhanVien();
        }
        public List<dynamic> GetDetail(int NV_ID)
        {
            return nvd.GetListDetailsNhanVien(NV_ID);
        }

        public bool Add(NHANVIEN NV)
        {
            return nvd.ThemNhanVien(NV);
        }

        public bool SuaNhanVien(NHANVIEN NV, int NV_ID)
        {
            return nvd.SuaNhanVien(NV, NV_ID);
        }

        public bool XoaNhanVien(int NV_ID)
        {
            return nvd.XoaNhanVien(NV_ID);
        }

        public List<dynamic> TimKiemTenNhanVien(string searchValue)
        {
            return nvd.TimKiemTenNhanVien(searchValue);
        }
    }
}
