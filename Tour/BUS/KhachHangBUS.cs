using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khd = new KhachHangDAO();
        public List<KHACHHANG> GetKhachHang()
        {
            return khd.GetAllKhachHang();
        }
        public List<KHACHHANG> Searching(string searchValue)
        {
            return khd.SearchKH(searchValue);
        }
        public List<dynamic> GetListDetailsKhachHang(int KH_ID)
        {
            return khd.GetDetailList(KH_ID);
        }


        public bool ThemKhachHang(KHACHHANG KH)
        {
            return khd.ThemKhachHang(KH);
        }

        public bool XoaKhachHang(int KH_ID)
        {
            return khd.XoaKhachHang(KH_ID);
        }

        public bool SuaKhachHang(KHACHHANG KH, int KH_ID)
        {
            return khd.SuaKhachHang(KH, KH_ID);
        }

    }
}
