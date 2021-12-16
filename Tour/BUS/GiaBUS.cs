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
        public List<GIATOUR> GetAllGiaTour()
        {
            return gd.GetAll();
        }

        public List<dynamic> GetGT()
        {
            return gd.getGT();
        }

        public List<dynamic> GetListGiaTour()
        {
            return gd.GetListGiaTour();
        }

        public bool ThemGiaTour(GIATOUR GT)
        {
            return gd.ThemGiaTour(GT);
        }

        public bool SuaGiaTour(GIATOUR GT, int G_ID)
        {
            return gd.SuaGiaTour(GT, G_ID);
        }

        public bool XoaGiaTour(GIATOUR GT, int G_ID)
        {
            return gd.XoaGiaTour(GT, G_ID);
        }

    }
}
