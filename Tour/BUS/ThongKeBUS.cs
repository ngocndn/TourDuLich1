using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class ThongKeBUS
    {
        ThongKeDAO tkd = new ThongKeDAO();
        public List<dynamic> GetDoanhThu()
        {
            return tkd.GetListDoanhThu();
        }
        public List<dynamic> GetLanThamGia(int N)
        {
            return tkd.KHTGTOUR(N);
        }
        public List<dynamic> GetLanThamGiaNV(int N)
        {
            return tkd.NhanVienTheoTour(N);
        }
        public List<dynamic> GetTourTheoLH ()
        {
            return tkd.TourTheoLoaiHinh();
        }
    }
}
