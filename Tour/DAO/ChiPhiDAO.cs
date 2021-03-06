using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class ChiPhiDAO
    {
        TourENT tour;
        public List<CHIPHI> GetAll()
        {
            using (tour = new TourENT())
            {
                var getAll = tour.CHIPHIs;
                return getAll.ToList<CHIPHI>();
            }
        }

        public List<LOAICHIPHI> GetAllLoai()
        {
            using (tour = new TourENT())
            {
                var getAll = tour.LOAICHIPHIs;
                return getAll.ToList<LOAICHIPHI>();
            }
        }
        public List<CHITIETCHIPHI> GetAllCT()
        {
            using(tour = new TourENT())
            {
                var GetAll = tour.CHITIETCHIPHIs;
                return GetAll.ToList<CHITIETCHIPHI>();
            }
        }

        public List<dynamic> GetList()
        {
            using (tour = new TourENT())
            {
                var getListNhanVien = (from tbChiPhi in tour.CHIPHIs
                                       
                                       select new
                                       {
                                           TenCP = tbChiPhi.TenCP , TongTien = tbChiPhi.ThanhTien
                                          
                                       });

                return getListNhanVien.ToList<dynamic>();

            }

        }

        public List<dynamic> TimKiem(string searchValue)
        {
            using (tour = new TourENT())
            {
                var getListNhanVien = (from tbcp in tour.CHIPHIs 
                                       select new
                                       {
                                           TenCP = tbcp.TenCP,
                                           TongTien = tbcp.ThanhTien
                                       }).Where(t => t.TenCP.Contains(searchValue));

                return getListNhanVien.ToList<dynamic>();

            }

        }

        public List<dynamic> GetListDetailsNhanVien(int CP_ID)
        {
            using (tour = new TourENT())
            {
                var getListDetailsNhanVien = (from tbChiPhi in tour.CHIPHIs 
                                              where tbChiPhi.CHIPHI_ID == CP_ID
                                              select new
                                              {
                                                  MaCP = tbChiPhi.CHIPHI_ID,
                                                  TenCP = tbChiPhi.TenCP,
                                                  TongTien = tbChiPhi.ThanhTien
                                              });

                return getListDetailsNhanVien.ToList<dynamic>();
            }
        }
        public List<dynamic> GetChiTietCPByMaDoan(int DoanID)
        {
            using (tour = new TourENT())
            {
                var Getlist = (from tbC in tour.CHITIETCHIPHIs
                               where tbC.MaDOANDL == DoanID
                               select new
                               { 
                                    MaCTCP = tbC.id,TenCP = tbC.TenCP,ThanhTien = tbC.TongCong
                               });
                return Getlist.ToList<dynamic>();
            }
        }
        public bool ThemChiPhi(CHIPHI cp)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.CHIPHIs.Add(cp);
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
        public bool ThemChitietCP(CHITIETCHIPHI ctcp)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.CHITIETCHIPHIs.Add(ctcp);
                    tour.SaveChanges();
                    return true;
                } 
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return false;
                }
            }
        }
        public bool XoaCTCP(int id)
        {
            using (tour = new TourENT())
            {
                try
                {
                    CHITIETCHIPHI cp = tour.CHITIETCHIPHIs.Where(t => t.id == id).SingleOrDefault();
                    tour.CHITIETCHIPHIs.Remove(cp);
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

        public bool XoaCP(int cp_id)
        {
            using (tour = new TourENT())
            {
                try
                {
                    CHIPHI cp = tour.CHIPHIs.Where(t => t.CHIPHI_ID == cp_id).SingleOrDefault();
                    tour.CHIPHIs.Remove(cp);
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

        public bool SuaChiPhi(CHIPHI cp, int cp_id)
        {
            using (tour = new TourENT())
            {
                try
                {
                    CHIPHI CP = tour.CHIPHIs.Where(t => t.CHIPHI_ID == cp_id).SingleOrDefault();
                    CP.TenCP = cp.TenCP;
                    CP.ThanhTien = cp.ThanhTien;

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
