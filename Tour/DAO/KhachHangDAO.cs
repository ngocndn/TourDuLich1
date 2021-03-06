using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class KhachHangDAO
    {
        TourENT tour;
        public List<KHACHHANG> GetAllKhachHang()
        {
            using (tour = new TourENT())
            {
                var getall = tour.KHACHHANGs;
                return getall.ToList<KHACHHANG>();
            }
        }
        public List<KHACHHANG> SearchKH(string searchValue)
        {
            using (tour = new TourENT())
            {
                var getall = tour.KHACHHANGs.Where(t=>t.TenKH.Contains(searchValue));
                return getall.ToList<KHACHHANG>();
            }
        }

        public List<dynamic> GetListKH()
        {
            using (tour = new TourENT())
            {
                var getlist = (from KH in tour.KHACHHANGs
                               select new
                               { MaKH = KH.MaKH, TenKH = KH.TenKH,
                                 NgaySinh = KH.KH_NgaySinh, DiaChi = KH.KH_DiaChi,
                                 SDT = KH.KH_SoDienThoai, Gioitinh = KH.KH_GioiTinh,
                                 Email = KH.KH_email, CMND = KH.KH_CMND});
                return getlist.ToList<dynamic>();
            }
        }
        public List<dynamic> GetListKHW()
        {
            using (tour = new TourENT())
            {
                var getlist = (from KH in tour.KHACHHANGs
                               select new
                               {
                                   MaKH = KH.MaKH,
                                   TenKH = KH.TenKH,
                                   KH_NgaySinh = KH.KH_NgaySinh,
                                   KH_DiaChi = KH.KH_DiaChi,
                                   KH_SoDienThoai = KH.KH_SoDienThoai,
                                   KH_GioiTinh = KH.KH_GioiTinh,
                                   KH_email = KH.KH_email,
                                   KH_CMND = KH.KH_CMND
                               });
                return getlist.ToList<dynamic>();
            }
        }


        public List<dynamic> GetDetailList(int KH_ID)
        {
            using (tour = new TourENT())
            {
                var getdetail = (from KH in tour.KHACHHANGs where KH.MaKH == KH_ID
                               select new
                               {
                                   MaKH = KH.MaKH,
                                   TenKH = KH.TenKH,
                                   NgaySinh = KH.KH_NgaySinh,
                                   DiaChi = KH.KH_DiaChi,
                                   SDT = KH.KH_SoDienThoai,
                                   Gioitinh = KH.KH_GioiTinh,
                                   Email = KH.KH_email,
                                   CMND = KH.KH_CMND
                               });
                return getdetail.ToList<dynamic>();
            }
        }
        public List<dynamic> GetDetailListW(int KH_ID)
        {
            using (tour = new TourENT())
            {
                var getdetail = (from KH in tour.KHACHHANGs
                                 where KH.MaKH == KH_ID
                                 select new
                                 {
                                     MaKH = KH.MaKH,
                                     TenKH = KH.TenKH,
                                     KH_NgaySinh = KH.KH_NgaySinh,
                                     KH_DiaChi = KH.KH_DiaChi,
                                     KH_SoDienThoai = KH.KH_SoDienThoai,
                                     KH_Gioitinh = KH.KH_GioiTinh,
                                     KH_email = KH.KH_email,
                                     KH_CMND = KH.KH_CMND
                                 });
                return getdetail.ToList<dynamic>();
            }
        }

        public bool ThemKhachHang(KHACHHANG KH)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.KHACHHANGs.Add(KH);
                    tour.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return false;
                }


            }

        }
        public bool XoaKhachHang(int KH_ID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    KHACHHANG KH = tour.KHACHHANGs.Where(kh => kh.MaKH == KH_ID).SingleOrDefault();
                    tour.KHACHHANGs.Remove(KH);
                    tour.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return false;
                }

            }
        }

        public bool SuaKhachHang(KHACHHANG KH, int KH_ID)
        {
            using (tour = new TourENT())
                try
                {
                    KHACHHANG kh = tour.KHACHHANGs.Where(t => t.MaKH == KH_ID).SingleOrDefault();
                    kh.TenKH = KH.TenKH;
                    kh.KH_NgaySinh = KH.KH_NgaySinh;
                    kh.KH_DiaChi = KH.KH_DiaChi;
                    kh.KH_SoDienThoai = KH.KH_SoDienThoai;
                    kh.KH_GioiTinh = KH.KH_GioiTinh;
                    kh.KH_email = KH.KH_email;
                    kh.KH_CMND = KH.KH_CMND;

                    tour.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }

        }
    }
}
