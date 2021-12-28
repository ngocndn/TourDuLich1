using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class BookingDAO
    {
        TourENT tour;
        public List<BOOKING> GetAll()
        {
            using (tour = new TourENT())
            {
                var getall = tour.BOOKINGs;
                return getall.ToList<BOOKING>();
            }
        }
        public List<dynamic> GetList()
        {
            using (tour = new TourENT())
            {
                var getlist = (from tbBooking in tour.BOOKINGs
                               join tbKhachHang in tour.KHACHHANGs on tbBooking.MaKH equals tbKhachHang.MaKH
                               join tbTour in tour.TOURDULICHes on tbBooking.MaTour equals tbTour.MaTour
                               join tbDoan in tour.DOANDLs on tbBooking.MaDOANDL equals tbDoan.MaDOANDL
                               select new
                               {
                                   id= tbBooking.id,TenKH = tbKhachHang.TenKH, tbDoan.TenDoan, tbTour.TenTour
                               });
                return getlist.ToList<dynamic>();
            }

        }
        public List<dynamic> GetDetail(int id)
        {
            using (tour = new TourENT())
            {
                var getlist = (from tbBooking in tour.BOOKINGs
                              join tbKhachHang in tour.KHACHHANGs on tbBooking.MaKH equals tbKhachHang.MaKH
                              join tbTour in tour.TOURDULICHes on tbBooking.MaTour equals tbTour.MaTour
                              join tbDoan in tour.DOANDLs on tbBooking.MaDOANDL equals tbDoan.MaDOANDL
                               where tbBooking.MaDOANDL == id
                               select new
                              {
                                  id = tbBooking.id,
                                  TenKH = tbKhachHang.TenKH,
                                  tbDoan.TenDoan,
                                  tbTour.TenTour
                              });
                return getlist.ToList<dynamic>();
            }
        }
        public List<dynamic> GetDetailW(int id)
        {
            using (tour = new TourENT())
            {
                var getlist = (from tbBooking in tour.BOOKINGs
                               join tbKhachHang in tour.KHACHHANGs on tbBooking.MaKH equals tbKhachHang.MaKH
                               join tbTour in tour.TOURDULICHes on tbBooking.MaTour equals tbTour.MaTour
                               join tbDoan in tour.DOANDLs on tbBooking.MaDOANDL equals tbDoan.MaDOANDL
                               where tbBooking.MaDOANDL == id
                               select new
                               {
                                   id = tbBooking.id,
                                   TenKH = tbKhachHang.TenKH,
                                   TenDoan= tbDoan.TenDoan,
                                   TenTour = tbTour.TenTour
                               });
                return getlist.ToList<dynamic>();
            }
        }
        public List<BOOKING> GetKHQuaMaDOAN(int MaDOANDL)
        {
            using (tour = new TourENT())
            {
                var getList = tour.BOOKINGs.Where(t => t.MaDOANDL == MaDOANDL);

                return getList.ToList<BOOKING>();
            }

        }
        public List<dynamic> GetGiaByTour(int TourID)
        {
            using (tour = new TourENT())
            {
                var getPrice = (from tbTour in tour.TOURDULICHes
                                join tbGia in tour.GIATOURs on tbTour.IDGiaTour equals tbGia.IDGIATOUR
                                where tbTour.MaTour == TourID
                                select new
                                {
                                    MaTour = tbTour.MaTour,GiaTour = tbGia.ThanhTien
                                });
                return getPrice.ToList<dynamic>();
            }
        }
        public List<dynamic> GetChiPhi(int DoanID)
        {
            using (tour = new TourENT())
            {
                var getPrice = (from tbDoan in tour.DOANDLs
                                join tbChiPhi in tour.CHITIETCHIPHIs on tbDoan.MaDOANDL equals tbChiPhi.MaDOANDL
                                where tbDoan.MaDOANDL == DoanID
                                select new
                                {
                                    MaDoan = tbDoan.MaDOANDL,
                                    ChiPhiID = tbChiPhi.id,
                                    TongTien = tbChiPhi.TongCong
                                });
                return getPrice.ToList<dynamic>();
            }
        }
        public bool Book(BOOKING B)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.BOOKINGs.Add(B);
                    tour.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }
            }
        }
        public bool Delete(int id)
        {
            using (tour = new TourENT())
            {
                try
                {
                    BOOKING B = tour.BOOKINGs.Where(t => t.id == id).SingleOrDefault();
                    tour.BOOKINGs.Remove(B);
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
}
