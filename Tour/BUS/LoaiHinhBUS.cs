using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class LoaiHinhBUS
    {
        LoaiHinhDAO LHD = new LoaiHinhDAO();
        public List<LOAIHINHDULICH> GetLoaiHinh()
        {
            return LHD.GetListLoaiHinh();
        }
        public List<dynamic> GetDetailList(int LoaiHinhID)
        {
            return LHD.GetDetailList(LoaiHinhID);
        }
        public bool Add(LOAIHINHDULICH LH)
        {
            return LHD.Add(LH);
        }

        public bool Edit(LOAIHINHDULICH LH, int LoaiHinhID)
        {
            return LHD.Edit(LH, LoaiHinhID);
        }
        public bool Del (LOAIHINHDULICH LH, int LoaiHinhID)
        {
            return LHD.Del(LH,LoaiHinhID);
        }
    }
}
