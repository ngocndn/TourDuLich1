using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLichSite
{
    public class KhachHangView
    {
        public int MaKH { get; set; }

        public string TenKH { get; set; }

        public Nullable<System.DateTime> KH_NgaySinh { get; set; }

        public string KH_DiaChi { get; set; }

        public string KH_SoDienThoai { get; set; }

        public string KH_GioiTinh { get; set; }

        public string KH_email { get; set; }

        public string KH_CMND { get; set; }

    }
}