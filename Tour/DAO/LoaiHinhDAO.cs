using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class LoaiHinhDAO
    {
        TourENT tour;
        public List<LOAIHINHDULICH> GetListLoaiHinh()
        {
            using (tour = new TourENT())
            {
                var getListLH = tour.LOAIHINHDULICHes;
                return getListLH.ToList<LOAIHINHDULICH>();
            }
        }
        public List<dynamic> GetList()
        {
            using (tour = new TourENT())
            {
                var getListLH = (from tbLH in tour.LOAIHINHDULICHes
                                 select new
                                 { MaLoaiHinh = tbLH.MaLoaiHinh, TenLoaiHinh = tbLH.TenLoaiHinh, LH_MoTa = tbLH.LH_MoTa });
                return getListLH.ToList<dynamic>();
            }
        }
        public List<LOAIHINHDULICH> Search(string searchValue)
        {
            using (tour = new TourENT())
            {
                var getListLH = tour.LOAIHINHDULICHes.Where(t=>t.TenLoaiHinh.Contains(searchValue));
                return getListLH.ToList<LOAIHINHDULICH>();
            }
        }

        public List<dynamic> GetDetailList (int LoaiHinhID)
        {
            using (tour = new TourENT())
            {
                var getListDetail = (from tbLoaiHinh in tour.LOAIHINHDULICHes
                                     where tbLoaiHinh.MaLoaiHinh == LoaiHinhID
                                     select new
                                     {
                                         LoaiHinhID = tbLoaiHinh.MaLoaiHinh,
                                         LoaiHinh   = tbLoaiHinh.TenLoaiHinh,
                                         LH_MoTa    = tbLoaiHinh.LH_MoTa
                                     }
                                     );
                return getListDetail.ToList<dynamic>();
            }
        }
        public List<LOAIHINHDULICH> GetOneLoaiHinhDL(int LoaiHinhID)
        {
            using (tour = new TourENT())
            {
                var getListTenLHDL = tour.LOAIHINHDULICHes.Where(t => t.MaLoaiHinh == LoaiHinhID);
                return getListTenLHDL.ToList<LOAIHINHDULICH>();
            }

        }

        public List<dynamic> GetOneLoaiHinhDLW(int LoaiHinhID)
        {
            using (tour = new TourENT())
            {
                var getListTenLHDL = (from tbL in tour.LOAIHINHDULICHes
                                      where tbL.MaLoaiHinh == LoaiHinhID
                                      select new
                                      { 
                                        MaLoaiHinh = tbL.MaLoaiHinh, TenLoaiHinh = tbL.TenLoaiHinh, LH_MoTa = tbL.LH_MoTa
                                      });
                return getListTenLHDL.ToList<dynamic>();
            }

        }

        public bool Add(LOAIHINHDULICH LH)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.LOAIHINHDULICHes.Add(LH);
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

        public bool Edit(LOAIHINHDULICH LH, int LoaiHinhID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    LOAIHINHDULICH lh = tour.LOAIHINHDULICHes.Where(t => t.MaLoaiHinh == LoaiHinhID).SingleOrDefault();
                    lh.TenLoaiHinh = LH.TenLoaiHinh;
                    lh.LH_MoTa = LH.LH_MoTa;
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

        public bool Del(LOAIHINHDULICH LH, int LoaiHinhID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    LH = tour.LOAIHINHDULICHes.Where(t => t.MaLoaiHinh == LoaiHinhID).SingleOrDefault();
                    tour.LOAIHINHDULICHes.Remove(LH);
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

