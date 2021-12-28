using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLichSite
{
    public class BookingView
    {
        public int id { get; set; }

        public int MaDOANDL { get; set; }

        public int MaKH { get; set; }
        public string TenKH { get; set; }

        public int MaTour { get; set; }
        public string TenTour { get; set; }

        public Nullable<int> Siso { get; set; }

        public int GiaTour { get; set; }
    }
}