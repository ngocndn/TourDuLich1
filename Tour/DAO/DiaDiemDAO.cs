using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class DiaDiemDAO
    {
        TourENT tour;

        public List<DIADIEM> GetListDiaDiem()
        {
            using (tour = new TourENT())
            {
                var getList = tour.DIADIEMs;
                return getList.ToList<DIADIEM>();
            }
        }
        public List<dynamic> GetLDD()
        {
            using(tour = new TourENT())
            {
                var getList = (from tbDD in tour.DIADIEMs
                               select new
                               { MaDD = tbDD.MaDiaDiem,TenDD = tbDD.TenDiaDiem, MoTa = tbDD.DD_MoTa });
                return getList.ToList<dynamic>();
            }
        }
        public List<DIADIEM> Search(string searchValue)
        {
            using (tour = new TourENT())
            {
                var getList = tour.DIADIEMs.Where(t=>t.TenDiaDiem.Contains(searchValue));
                return getList.ToList<DIADIEM>();
            }
        }

        public List<dynamic> GetDiaDiemDetail(int ID)
        {
            using (tour = new TourENT())
            {
                var getDetailDD = (from DD in tour.DIADIEMs
                                   where DD.MaDiaDiem == ID
                                   select new
                                   {
                                       ID = DD.MaDiaDiem,Ten=DD.TenDiaDiem,MoTa=DD.DD_MoTa
                                   });
                return getDetailDD.ToList<dynamic>();
            }
        }

        public bool AddDiaDiem(DIADIEM DD)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.DIADIEMs.Add(DD);
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

        public bool Edit(DIADIEM DD, int DiaDiemID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    DIADIEM oDD = tour.DIADIEMs.Where(t=>t.MaDiaDiem == DiaDiemID).SingleOrDefault();
                    oDD.TenDiaDiem = DD.TenDiaDiem;
                    oDD.DD_MoTa = DD.DD_MoTa;    ;tour.SaveChanges();return true;
                }
                catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }
            }
        }

        public bool Delete(DIADIEM DD, int DiaDiemID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    DD = tour.DIADIEMs.Where(t => t.MaDiaDiem == DiaDiemID).SingleOrDefault();
                    tour.DIADIEMs.Remove(DD);
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
