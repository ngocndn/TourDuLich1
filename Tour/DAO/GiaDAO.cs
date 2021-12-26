using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class GiaDAO
    {
        TourENT tour;

        public List<GIATOUR> GetGiaTour()
        {
            using (tour = new TourENT())
            {
                var getListDetailsTour = from tbGiaTour in tour.GIATOURs select tbGiaTour;

                return getListDetailsTour.ToList<GIATOUR>();

            }

        }
        public List<dynamic> GetGia()
        {
            using (tour = new TourENT())
            {
                var getListDetailsTour = (from tbGiaTour in tour.GIATOURs join tbTour in tour.TOURDULICHes on tbGiaTour.IDGIATOUR equals tbTour.IDGiaTour select new
                {
                    TenTour = tbTour.TenTour,GiaTour = tbGiaTour.ThanhTien
                });

                return getListDetailsTour.ToList<dynamic>();

            }
        }


        //Get giá tour qua mã số tour
        public List<GIATOUR> GetGiaTourWithMaTour(int TourID)
        {
            using (tour = new TourENT())
            {
                var getList = tour.GIATOURs.Where(t => t.MaTour == TourID);

                return getList.ToList<GIATOUR>();
            }

        }

        public List<dynamic> GetGiaTourByMaTour(int TourID)
        {
            using (tour = new TourENT())
            {
                var getList = (from tbTour in tour.TOURDULICHes
                               join tbGia in tour.GIATOURs on tbTour.IDGiaTour equals tbGia.IDGIATOUR
                               where tbTour.MaTour == TourID
                               select new
                               { MaTour = tbTour.MaTour, TenTour = tbTour.TenTour , GiaTour = tbGia.ThanhTien });
                return getList.ToList <dynamic>();
            }

        }

        public bool ThemGiaTour(GIATOUR G)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.GIATOURs.Add(G);
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

        public bool XoaGiaTour(GIATOUR G, int TourID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    G = tour.GIATOURs.Where(t =>t.MaTour == TourID).SingleOrDefault();
                    tour.GIATOURs.Remove(G);
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



    }
}
