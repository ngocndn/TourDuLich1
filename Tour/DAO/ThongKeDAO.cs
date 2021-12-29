using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class ThongKeDAO
    {
        TourENT tour;
        public List<dynamic> GetListDoanhThu()
        {
            using (tour = new TourENT())
            {
                var getall = (from tbD in tour.DOANDLs
                              select new
                              {
                              TenDoan = tbD.TenDoan, 
                              DoanhThu = tbD.Soluong*tbD.TongTien
                              }).OrderByDescending(t=>t.DoanhThu);
                return getall.ToList<dynamic>();
            }
        }

        public List<dynamic> KHTGTOUR (int N)
        {
            using (tour = new TourENT())
            {
                var getKH = (from tbB in tour.BOOKINGs 
                             from tbK in tour.KHACHHANGs
                             where tbB.MaKH == tbK.MaKH
                             group tbB by new
                             {
                                MaKH = tbB.MaKH,TenKH = tbK.TenKH
                             }
                             into tbL
                             select new
                             {
                                MaKH = tbL.Key.MaKH,TenKH = tbL.Key.TenKH,SoLanThamGia = tbL.Count()
                             }
                             ).OrderByDescending(t=>t.SoLanThamGia).Take(N);
                return getKH.ToList<dynamic>();
            }
        }
        public List<dynamic> NhanVienTheoTour(int N)
        {
            using (tour = new TourENT())
            {
                var getKH = (from tbD in tour.DOANDLs
                             from tbN in tour.NHANVIENs
                             where tbD.MaNV == tbN.MaNV
                             group tbD by new
                             {
                                 MaNV = tbD.MaNV,
                                 TenNV = tbN.TenNV
                             }
                             into tbL
                             select new
                             {
                                 MaNV = tbL.Key.MaNV,
                                 TenNV = tbL.Key.TenNV,
                                 SoLanThamGia = tbL.Count()
                             }
                             ).OrderByDescending(t => t.SoLanThamGia).Take(N);
                return getKH.ToList<dynamic>();
            }
        }

        public List<dynamic> TourTheoLoaiHinh()
        {
            using (tour = new TourENT())
            {
                var getTour = (from tbT in tour.TOURDULICHes
                               from tbL in tour.LOAIHINHDULICHes
                               where tbT.MaLoaiHinh == tbL.MaLoaiHinh
                               group tbT by new
                               { 
                                    MaLoaiHinh = tbT.MaLoaiHinh,TenLoaiHinh = tbL.TenLoaiHinh
                               }
                               into tbB select new
                               {
                                   MaLoaiHinh = tbB.Key.MaLoaiHinh,TenLoaiHinh = tbB.Key.TenLoaiHinh, SoTour = tbB.Count()
                               }
                               ).OrderByDescending(t=>t.SoTour);
                return getTour.ToList<dynamic>();
            }
        }
    }
}
