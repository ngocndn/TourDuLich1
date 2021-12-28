using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLichSite
{
    public class DoanView
    {
        public int MaDOANDL { get; set; }

        public System.DateTime NgayKhoiHanh { get; set; }

        public System.DateTime NgayKetThuc { get; set; }

        public int MaNV { get; set; }

        public int MaTour { get; set; }

        public string TenDoan { get; set; }

        public Nullable<int> Soluong { get; set; }
        public string TenNV { get; set; }
        public string TenTour { get; set; }
        public int id { get; set; }
    
    }
}