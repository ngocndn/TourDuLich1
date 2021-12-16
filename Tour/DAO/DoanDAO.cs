using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class DoanDAO
    {
        TourENT tour = new TourENT();
        public List<DOANDL> getall()
        {
            var getD = tour.DOANDLs;
            return getD.ToList<DOANDL>();

        }
        public List<DOANDL> GetOneDoan(int DoanID)
        {
            {
                var getAllTour = tour.DOANDLs.Where(t => t.MaDOANDL == DoanID);
                return getAllTour.ToList<DOANDL>();
            }
        }
        public List<dynamic> getListDoan()
        {
            {
                var getListDoan = (from tbD in tour.DOANDLs
                                   join tbT in tour.TOURDULICHes on tbD.MaTour equals tbT.MaTour
                                   join tbN in tour.NHANVIENs on tbD.MaNV equals tbN.MaNV
                                   select new
                                   {
                                   DoanID = tbD.MaDOANDL,
                                   Ten = tbD.TenDoan ,
                                   NgayKH = tbD.NgayKhoiHanh,KT=tbD.NgayKetThuc,TenTour = tbT.TenTour, HDV = tbN.TenNV
                                   });
                return getListDoan.ToList<dynamic>();
            }
        }

        public bool Add(DOANDL D)
        {
            {
                try
                {
                    tour.DOANDLs.Add(D);
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

        public bool Edit(DOANDL D, int DoanID)
        {
            {
                try
                {
                    DOANDL d = tour.DOANDLs.Where(t => t.MaDOANDL == DoanID).SingleOrDefault();
                    d.TenDoan = D.TenDoan;
                    d.MaTour = D.MaTour;
                    d.NgayKhoiHanh = D.NgayKhoiHanh;
                    d.NgayKetThuc = D.NgayKetThuc;
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

        public bool Delete(int DoanID)
        {
            {
                try
                {
                    DOANDL D = tour.DOANDLs.Where(t => t.MaDOANDL == DoanID).SingleOrDefault();
                    tour.DOANDLs.Remove(D);
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
    }
}
