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
        public List<DOANDL> Searching(string searchValue)
        {
            var getD = tour.DOANDLs.Where(t=>t.TenDoan.Contains(searchValue));
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
                                   NgayKH = tbD.NgayKhoiHanh,
                                   KT=tbD.NgayKetThuc,
                                   TenTour = tbT.TenTour,
                                   HDV = tbN.TenNV,
                                   //MCP1 = tbL.TenCP,MCP2 = tbL.TenCP
                                   });
                return getListDoan.ToList<dynamic>();
            }
        }
        public List<dynamic> getListDoanW()
        {
            {
                var getListDoan = (from tbD in tour.DOANDLs
                                   join tbT in tour.TOURDULICHes on tbD.MaTour equals tbT.MaTour
                                   join tbN in tour.NHANVIENs on tbD.MaNV equals tbN.MaNV

                                   select new
                                   {
                                       MaDOANDL = tbD.MaDOANDL,
                                       TenDoan = tbD.TenDoan,
                                       NgayKhoiHanh = tbD.NgayKhoiHanh,
                                       NgayKetThuc = tbD.NgayKetThuc,
                                       TenTour = tbT.TenTour,
                                       TenNV = tbN.TenNV,
                                       //MCP1 = tbL.TenCP,MCP2 = tbL.TenCP
                                   });
                return getListDoan.ToList<dynamic>();
            }
        }
        public List<dynamic> Search(string searchValue)
        {
            {
                var getListDoan = (from tbD in tour.DOANDLs
                                   join tbT in tour.TOURDULICHes on tbD.MaTour equals tbT.MaTour
                                   join tbN in tour.NHANVIENs on tbD.MaNV equals tbN.MaNV

                                   select new
                                   {
                                       DoanID = tbD.MaDOANDL,
                                       Ten = tbD.TenDoan,
                                       NgayKH = tbD.NgayKhoiHanh,
                                       KT = tbD.NgayKetThuc,
                                       TenTour = tbT.TenTour,
                                       HDV = tbN.TenNV,
                                       //MCP1 = tbL.TenCP,MCP2 = tbL.TenCP
                                   }).Where(t=>t.Ten.Contains(searchValue));
                return getListDoan.ToList<dynamic>();
            }
        }

        public List<dynamic> GetDDetail(int DoanID)
        {
            using (tour = new TourENT())
            {
                var getDDetail = (from tbD in tour.DOANDLs
                                          join tbT in tour.TOURDULICHes on tbD.MaTour equals tbT.MaTour
                                          join D in tour.DIADIEMs on tbT.MaDiaDiem equals D.MaDiaDiem
                                          join tbN in tour.NHANVIENs on tbD.MaNV equals tbN.MaNV 
                                          join tbG in tour.GIATOURs on tbT.IDGiaTour equals tbG.IDGIATOUR
                                          where tbD.MaDOANDL == DoanID
                                          select new
                                          {
                                              DoanID = tbD.MaDOANDL,
                                              Ten = tbD.TenDoan,
                                              NgayKH = tbD.NgayKhoiHanh,
                                              KT = tbD.NgayKetThuc,
                                              TenTour = tbT.TenTour,
                                              HDV = tbN.TenNV,
                                              DiemDen = D.TenDiaDiem,
                                              GiaTour = tbG.ThanhTien,
                                          });

                return getDDetail.ToList<dynamic>();

            }
        }
        public List<dynamic> GetDDetailW(int DoanID)
        {
            using (tour = new TourENT())
            {
                var getDDetail = (from tbD in tour.DOANDLs
                                  join tbT in tour.TOURDULICHes on tbD.MaTour equals tbT.MaTour
                                  join D in tour.DIADIEMs on tbT.MaDiaDiem equals D.MaDiaDiem
                                  join tbN in tour.NHANVIENs on tbD.MaNV equals tbN.MaNV
                                  where tbD.MaDOANDL == DoanID
                                  select new
                                  {
                                      MaDOANDL = tbD.MaDOANDL,
                                      TenDoan = tbD.TenDoan,
                                      NgayKhoiHanh = tbD.NgayKhoiHanh,
                                      NgayKetThuc = tbD.NgayKetThuc,
                                      TenTour = tbT.TenTour,
                                      TenNV = tbN.TenNV,
                                      TenDiaDiem = D.TenDiaDiem,
                                  });

                return getDDetail.ToList<dynamic>();

            }
        }
        public bool AddKH(DOANDL D, int DoanID)
        {
            {
                try
                {
                    DOANDL d = tour.DOANDLs.Where(t => t.MaDOANDL == DoanID).SingleOrDefault();
                    //d.Soluong += D.Soluong;
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
        public bool Del(DOANDL D, int DoanID)
        {
            {
                try
                {
                    DOANDL d = tour.DOANDLs.Where(t => t.MaDOANDL == DoanID).SingleOrDefault();
                    //d.Soluong -= D.Soluong;
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
                    d.MaNV = D.MaNV;
                    d.ChiPhi = D.ChiPhi;
                    d.TongTien = D.TongTien;
                    d.Soluong = D.Soluong;
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
        public bool SoLuongChange(DOANDL D, int DoanID)
        {
            {
                try
                {
                    DOANDL d = tour.DOANDLs.Where(t => t.MaDOANDL == DoanID).SingleOrDefault();
                    d.Soluong = D.Soluong;
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
        public bool GiaOnChange(DOANDL D, int DoanID)
        {
            {
                try
                {
                    DOANDL d = tour.DOANDLs.Where(t => t.MaDOANDL == DoanID).SingleOrDefault();
                    d.ChiPhi = D.ChiPhi;
                    d.TongTien = D.TongTien;
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
        public bool DeletefromTour(DOANDL D,int TourID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    D = tour.DOANDLs.Where(t => t.MaTour == TourID).SingleOrDefault();
                    tour.DOANDLs.Remove(D);
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
