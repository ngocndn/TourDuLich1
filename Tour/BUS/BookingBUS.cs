using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class BookingBUS
    {
        BookingDAO bd = new BookingDAO();
        public List<BOOKING> GetAll()
        {
            return bd.GetAll();
        }
        public List<dynamic> GetList()
        {
            return bd.GetList();
        }
        public List<dynamic> GetDetail(int id)
        {
            return bd.GetDetail(id);
        }
        public bool Add(BOOKING B)
        {
            return bd.Book(B);
        }
        public bool Delete(int id)
        {
            return bd.Delete(id);
        }
    }
}
