using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLichSite
{
    public class TourView
    {
        public int MaTour { get; set; }

        public string TenTour { get; set; }

        public string DacDiem { get; set; }

        public Nullable<int> IDGiaTour { get; set; }

        public Nullable<int> MaDOANDL { get; set; }

        public Nullable<int> MaLoaiHinh { get; set; }

        public Nullable<int> MaDiaDiem { get; set; }
        public string TenLoaiHinh { get; set; }
        public string TenDiaDiem { get; set; }

    }
}