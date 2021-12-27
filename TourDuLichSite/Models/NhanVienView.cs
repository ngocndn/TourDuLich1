using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLichSite
{
    public class NhanVienView
    {
        public int MaNV { get; set; }

        public string TenNV { get; set; }

        public Nullable<System.DateTime> NV_NgaySinh { get; set; }

        public string NV_SoDienThoai { get; set; }

        public string NV_NhiemVu { get; set; }
    }
}