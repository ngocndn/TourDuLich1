using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.DAO
{
    public class NhanVienDAO
    {
        TourENT tour;
        public List<NHANVIEN> GetAllNhanVien()
        {
            using (tour = new TourENT())
            {
                var getAll = tour.NHANVIENs;
                return getAll.ToList<NHANVIEN>();
            }
        }
        public List<dynamic> GetListNhanVien()
        {
            using (tour = new TourENT())
            {
                var getListNhanVien = (from tbNhanVien in tour.NHANVIENs
                                       select new
                                       {
                                           MaNhanVien = tbNhanVien.MaNV,
                                           TenNhanVien = tbNhanVien.TenNV,
                                           NgaySinh = tbNhanVien.NV_NgaySinh,
                                           SDT = tbNhanVien.NV_SoDienThoai
                                       });

                return getListNhanVien.ToList<dynamic>();

            }

        }

        public List<dynamic> TimKiemTenNhanVien(string searchValue)
        {
            using (tour = new TourENT())
            {
                var getListNhanVien = (from tbNhanVien in tour.NHANVIENs
                                       select new
                                       {
                                           MaNhanVien = tbNhanVien.MaNV,
                                           TenNhanVien = tbNhanVien.TenNV,
                                           NgaySinh = tbNhanVien.NV_NgaySinh,
                                           SDT = tbNhanVien.NV_SoDienThoai
                                       }).Where(t=>t.TenNhanVien.Contains(searchValue));

                return getListNhanVien.ToList<dynamic>();

            }

        }

        public List<dynamic> GetListDetailsNhanVien(int NV_ID)
        {
            using (tour = new TourENT())
            {
                var getListDetailsNhanVien = (from tbNhanVien in tour.NHANVIENs
                                              where tbNhanVien.MaNV == NV_ID
                                              select new
                                              {
                                                  MaNhanVien = tbNhanVien.MaNV,
                                                  TenNhanVien = tbNhanVien.TenNV,
                                                  NgaySinh = tbNhanVien.NV_NgaySinh,
                                                  SDT = tbNhanVien.NV_SoDienThoai
                                              });

                return getListDetailsNhanVien.ToList<dynamic>();
            }
        }

        public bool ThemNhanVien(NHANVIEN NV)
        {
            using (tour = new TourENT())
            {
                try
                {
                    tour.NHANVIENs.Add(NV);
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

        public bool XoaNhanVien(int NV_ID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    NHANVIEN NV = tour.NHANVIENs.Where(t => t.MaNV == NV_ID).SingleOrDefault();
                    tour.NHANVIENs.Remove(NV);
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

        public bool SuaNhanVien(NHANVIEN NV, int NV_ID)
        {
            using (tour = new TourENT())
            {
                try
                {
                    NHANVIEN nv = tour.NHANVIENs.Where(t => t.MaNV == NV_ID).SingleOrDefault();
                    nv.TenNV = NV.TenNV;
                    nv.NV_NgaySinh = NV.NV_NgaySinh;
                    nv.NV_SoDienThoai = NV.NV_SoDienThoai;

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
