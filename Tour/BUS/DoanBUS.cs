using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class DoanBUS
    {
        DoanDAO DD = new DoanDAO();
        public List<DOANDL> getall()
        {
            return DD.getall();
        }
        public List<DOANDL> Searching(string searchValue)
        {
            return DD.Searching(searchValue);
        }
        public List<DOANDL> Get1(int DoanID)
        {
            return DD.GetOneDoan(DoanID);
        }
        public List<dynamic> Search(string searchValue)
        {
            return DD.Search(searchValue);
        }
        public List<dynamic> GetListDoan()
        {
            return DD.getListDoan();
        }
        public bool Add(DOANDL D)
        {
            return DD.Add(D);
        }

        public bool Edit(DOANDL D, int DoanID)
        {
            return DD.Edit(D, DoanID);
        }
        public bool SoLuong(DOANDL D, int DoanID)
        {
            return DD.SoLuongChange(D, DoanID);
        }
        public bool GiaOnChange(DOANDL D, int DoanID)
        {
            return DD.GiaOnChange(D, DoanID);
        }

        public bool Delete(int DoanID)
        {
            return DD.Delete(DoanID);
        }
        public bool DeletefromTour(DOANDL D,int TourID)
        {
            return DD.DeletefromTour(D,TourID);
        }
        public List<dynamic> GetDetail( int DoanID)
        {
            return DD.GetDDetail(DoanID);
        }
        public bool AddKH(DOANDL D, int DoanID)
        {
          return  DD.AddKH(D, DoanID);
        }
        public bool DelKH(DOANDL D, int DoanID)
        {
            return DD.Del(D, DoanID);
        }
    }
}
