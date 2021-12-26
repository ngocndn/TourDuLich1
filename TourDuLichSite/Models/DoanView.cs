using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLichSite
{
    public class DoanView
    {
        public int DoanID { get; set; }
        public string Ten { get; set; }
        public DateTime NgayKH { get; set; }
        public DateTime KT { get; set; }
        public string TenTour { get; set; }
        public string HDV { get; set; }
    }
}