using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using Tour.DAO;

namespace Tour.BUS
{
    public class ChiPhiBUS
    {
        ChiPhiDAO cpd = new ChiPhiDAO();
        public List<CHIPHI> GetAll()
        {
            return cpd.GetAll();
        }

        public List<LOAICHIPHI> GetAllCP()
        {
            return cpd.GetAllLoai();
        }

        public List<dynamic> GetList()
        {
            return cpd.GetList();
        }
        public List<dynamic> GetDetail(int CP_ID)
        {
            return cpd.GetListDetailsNhanVien(CP_ID);
        }

        public bool Add(CHIPHI cp)
        {
            return cpd.ThemChiPhi(cp);
        }

        public bool Sua(CHIPHI cp, int cp_id)
        {
            return cpd.SuaChiPhi(cp, cp_id);
        }

        public bool Xoa(int cp_id)
        {
            return cpd.XoaCP(cp_id);
        }

        public List<dynamic> TimKiemTenNhanVien(string searchValue)
        {
            return cpd.TimKiem(searchValue);
        }
    }
}
