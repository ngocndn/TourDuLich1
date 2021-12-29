using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class TourDAO
    {
        TourENT tour;

        public List<TOURDULICH> GetAllTour()
        {
            using (tour = new TourENT())
            {
                var getAllTour = tour.TOURDULICHes;
                return getAllTour.ToList<TOURDULICH>();
            }
        }
        public List<TOURDULICH> GetOneTour(int TourID)
        {
            using (tour = new TourENT())
            {
                var getAllTour = tour.TOURDULICHes.Where(t => t.MaTour == TourID);
                return getAllTour.ToList<TOURDULICH>();
            }
        }

        public List<dynamic> GetListTour()
        {
            using (tour = new TourENT())
            {
                var getListTour = (from tbTour in tour.TOURDULICHes
                                   join tbDiaDiemDen in tour.DIADIEMs on tbTour.MaDiaDiem equals tbDiaDiemDen.MaDiaDiem
                                   join tbLoaiHinhDuLich in tour.LOAIHINHDULICHes on tbTour.MaLoaiHinh equals tbLoaiHinhDuLich.MaLoaiHinh
                                   select new
                                   {
                                       MaTour = tbTour.MaTour,
                                       TenTour = tbTour.TenTour,
                                       tenLoaiHinhDuLich = tbLoaiHinhDuLich.TenLoaiHinh,
                                       tenDiaDiem = tbDiaDiemDen.TenDiaDiem,
                                       DacDiem = tbTour.DacDiem
                                   });

                return getListTour.ToList<dynamic>();

            }

        }
        public List<dynamic> GetListTourW()
        {
            using (tour = new TourENT())
            {
                var getListTour = (from tbTour in tour.TOURDULICHes
                                   join tbDiaDiemDen in tour.DIADIEMs on tbTour.MaDiaDiem equals tbDiaDiemDen.MaDiaDiem
                                   join tbLoaiHinhDuLich in tour.LOAIHINHDULICHes on tbTour.MaLoaiHinh equals tbLoaiHinhDuLich.MaLoaiHinh
                                   //join tbGia in tour.GIATOURs on tbTour.IDGiaTour equals tbGia.IDGIATOUR
                                   select new
                                   {
                                       MaTour = tbTour.MaTour,
                                       TenTour = tbTour.TenTour,
                                       TenLoaiHinh = tbLoaiHinhDuLich.TenLoaiHinh,
                                       TenDiaDiem = tbDiaDiemDen.TenDiaDiem,
                                       DacDiem = tbTour.DacDiem,
                                       //ThanhTien = tbGia.ThanhTien
                                   });

                return getListTour.ToList<dynamic>();

            }

        }
        public List<dynamic> SearchTour(string searchValue)
        {
            using(tour = new TourENT())
            {
                var getListTour = (from tbTour in tour.TOURDULICHes
                                   join tbDiaDiemDen in tour.DIADIEMs on tbTour.MaDiaDiem equals tbDiaDiemDen.MaDiaDiem
                                   join tbLoaiHinhDuLich in tour.LOAIHINHDULICHes on tbTour.MaLoaiHinh equals tbLoaiHinhDuLich.MaLoaiHinh
                                   select new
                                   {
                                       MaTour = tbTour.MaTour,
                                       TenTour = tbTour.TenTour,
                                       tenLoaiHinhDuLich = tbLoaiHinhDuLich.TenLoaiHinh,
                                       tenDiaDiem = tbDiaDiemDen.TenDiaDiem,
                                       DacDiem = tbTour.DacDiem
                                   }).Where(t => t.TenTour.Contains(searchValue));

                return getListTour.ToList<dynamic>();
            }
        }
        public List<dynamic> GetListDetailsTour(int T_ID)
        {
            using (tour = new TourENT())
            {
                var getListDetailsTour = (from tbTour in tour.TOURDULICHes
                                          join tbDiaDiemDen in tour.DIADIEMs on tbTour.MaDiaDiem equals tbDiaDiemDen.MaDiaDiem
                                          join tbLoaiHinhDuLich in tour.LOAIHINHDULICHes on tbTour.MaLoaiHinh equals tbLoaiHinhDuLich.MaLoaiHinh
                                          where tbTour.MaTour == T_ID
                                          select new
                                          {
                                              MaTour = tbTour.MaTour,
                                              TenTour = tbTour.TenTour,
                                              tenLoaiHinhDuLich = tbLoaiHinhDuLich.TenLoaiHinh,
                                              tenDiaDiem = tbDiaDiemDen.TenDiaDiem,
                                              DacDiem = tbTour.DacDiem
                                          });

                return getListDetailsTour.ToList<dynamic>();

            }
        }
        public bool ThemTour(TOURDULICH T)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.TOURDULICHes.Add(T);
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

        public bool SuaTour(TOURDULICH T, int T_ID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    TOURDULICH x = tour.TOURDULICHes.Where(t => t.MaTour == T_ID).SingleOrDefault();
                    x.TenTour = T.TenTour;
                    x.DacDiem = T.DacDiem;
                    x.MaLoaiHinh = T.MaLoaiHinh;
                    x.MaDiaDiem = T.MaDiaDiem;
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


        public bool XoaTour(int T_ID)
        {
            using (tour= new TourENT())
            {
                try
                {
                    TOURDULICH T = tour.TOURDULICHes.Where(t => t.MaTour == T_ID).SingleOrDefault();
                    tour.TOURDULICHes.Remove(T);
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
        public bool SuaGiaTour(TOURDULICH T, int T_ID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    TOURDULICH to = tour.TOURDULICHes.Where(t => t.MaTour == T_ID).SingleOrDefault();
                    to.IDGiaTour = T.IDGiaTour;
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
