using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class TourBUS
    {
        TourDAO TD = new TourDAO();
        public List<TOURDULICH> GetAllTour()
        {
            return TD.GetAllTour();
        }
        public List<TOURDULICH> Get1Tour(int T_ID)
        {
            return TD.GetOneTour(T_ID);
        }


        public List<dynamic> GetTourList()
        {
            return TD.GetListTour();
        }

        public List<dynamic> GetTourDetailList(int T_ID)
        {
            return TD.GetListDetailsTour(T_ID);
        }
        public List<dynamic> SearchTour(string searchValue)
        {
            return TD.SearchTour(searchValue);
        }
        public bool AddTour(TOURDULICH T)
        {
            return TD.ThemTour(T);
        }

        public bool DelTour( int T_ID)
        {
            return TD.XoaTour(T_ID);
        }
        public bool EditTour(TOURDULICH T, int T_ID)
        {
            return TD.SuaTour(T, T_ID);
        }
        public bool SuaGiaTour(TOURDULICH T, int T_ID)
        {
            return TD.SuaGiaTour(T, T_ID);
        }

    }
}
