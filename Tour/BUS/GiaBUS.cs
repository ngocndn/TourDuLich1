using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class GiaBUS
    {
        GiaDAO gd= new GiaDAO();

        //Get list tour tùy chỉnh
        public List<GIATOUR> GetGiaTour()
        {
            return gd.GetGiaTour();
        }
        public List<GIATOUR> GetGiaTourWithMaTour(int TourID)
        {
            return gd.GetGiaTourWithMaTour(TourID);
        }
        public List<dynamic> GetGiaByMa(int TourID)
        {
            return gd.GetGiaTourByMaTour(TourID);
        }

        public bool ThemGiaTour(GIATOUR G)
        {
            return gd.ThemGiaTour(G);
        }

        public bool XoaGiaTour(GIATOUR G, int TourID)
        {
            return gd.XoaGiaTour(G, TourID);
        }
        public List<dynamic> GetGia()
        {
            return gd.GetGia();
        }

    }
}
