using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WDL.Models
{
    public class Doan
    {
        public int ID { get; set; }
        public string TenDoan { get; set; }
        public string TenTour { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public DateTime thoiGianKetThuc { get; set; }
    }
}