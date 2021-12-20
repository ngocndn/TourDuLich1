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

        public List<CHIPHI> GetChiPhiKS()
        {
            {
                var getList = tour.CHIPHIs.Where(t => t.LoaiCP_ID == 1);
                return getList.ToList<CHIPHI>();
            }
        }
        public List<CHIPHI> GetChiPhiDC()
        {
            {
                var getList = tour.CHIPHIs.Where(t => t.LoaiCP_ID == 2);
                return getList.ToList<CHIPHI>();
            }
        }
        public List<dynamic> getListDoan()
        {
            {
                var getListDoan = (from tbD in tour.DOANDLs
                                   join tbT in tour.TOURDULICHes on tbD.MaTour equals tbT.MaTour
                                   join tbN in tour.NHANVIENs on tbD.MaNV equals tbN.MaNV
                                   join tbL in tour.CHIPHIs on tbD.Accom_ID equals tbL.CHIPHI_ID

                                   select new
                                   {
                                   DoanID = tbD.MaDOANDL,
                                   Ten = tbD.TenDoan ,
                                   NgayKH = tbD.NgayKhoiHanh,
                                   KT=tbD.NgayKetThuc,
                                   TenTour = tbT.TenTour,
                                   HDV = tbN.TenNV,
                                   //MCP1 = tbL.TenCP,MCP2 = tbL.TenCP
                                   });
                return getListDoan.ToList<dynamic>();
            }
        }

        public List<dynamic> GetDDetail(int DoanID)
        {
            using (tour = new TourENT())
            {
                var getDDetail = (from tbD in tour.DOANDLs
                                          join tbT in tour.TOURDULICHes on tbD.MaTour equals tbT.MaTour
                                          join tbN in tour.NHANVIENs on tbD.MaNV equals tbN.MaNV
                                  where tbD.MaDOANDL == DoanID
                                          select new
                                          {
                                              DoanID = tbD.MaDOANDL,
                                              Ten = tbD.TenDoan,
                                              NgayKH = tbD.NgayKhoiHanh,
                                              KT = tbD.NgayKetThuc,
                                              TenTour = tbT.TenTour,
                                              HDV = tbN.TenNV
                                          });

                return getDDetail.ToList<dynamic>();

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
