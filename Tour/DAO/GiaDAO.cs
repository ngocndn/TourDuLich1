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

        public List<GIATOUR> GetAll()
        {
            using (tour = new TourENT())
            {
                var gat = tour.GIATOURs;
                return gat.ToList<GIATOUR>();
            }
        }
        public List<dynamic> GetListGiaTour()
        {
            using (tour = new TourENT())
            {
                var getListGiaTour = (from tbTour in tour.TOURDULICHes
                                      join tbLoaiHinhDuLich in tour.LOAIHINHDULICHes on tbTour.MaLoaiHinh equals tbLoaiHinhDuLich.MaLoaiHinh
                                      join tbGiaTour in tour.GIATOURs on tbTour.IDGiaTour equals tbGiaTour.IDGIATOUR
                                      select new
                                      {
                                          MaTour = tbTour.MaTour,
                                          TenTour = tbTour.TenTour,
                                          tenLoaiHinhDuLich = tbLoaiHinhDuLich.TenLoaiHinh,
                                          giaTour = tbGiaTour.ThanhTien,
                                          thoiGianBatDau = tbGiaTour.TGBatDau,
                                          thoiGianKetThuc = tbGiaTour.TGKetThuc
                                      });

                return getListGiaTour.ToList<dynamic>();

            }
        }
        public bool ThemGiaTour(GIATOUR GT)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.GIATOURs.Add(GT);
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

        public bool SuaGiaTour(GIATOUR GT, int G_ID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    GIATOUR gt = tour.GIATOURs.Where(t => t.IDGIATOUR == G_ID).SingleOrDefault(); ;
                    gt.TGBatDau = GT.TGBatDau;
                    gt.TGKetThuc = GT.TGKetThuc;
                    gt.ThanhTien = GT.ThanhTien;
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


        public bool XoaGiaTour(GIATOUR GT, int G_ID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    GT = tour.GIATOURs.Where(t => t.IDGIATOUR == G_ID).SingleOrDefault();
                    tour.GIATOURs.Remove(GT);

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
