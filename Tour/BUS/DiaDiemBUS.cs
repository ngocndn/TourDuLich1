using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class DiaDiemBUS
    {
        DiaDiemDAO DDD = new DiaDiemDAO();
        public List<DIADIEM> GetListDD()
        {
            return DDD.GetListDiaDiem();
        }
        public List<DIADIEM> Search(string searchValue)
        {
            return DDD.Search(searchValue);
        }
        public List<dynamic> GetDiaDiemDetailList(int ID)
        {
            return DDD.GetDiaDiemDetail(ID);
        }
        public bool AddDiaDiem(DIADIEM DD)
        {
            return DDD.AddDiaDiem(DD);
        }
        public bool DelDiaDiem(DIADIEM DD, int ID)
        {
            return DDD.Delete(DD, ID);
        }
        public bool EditDiaDiem(DIADIEM DD, int ID)
        {
            return DDD.Edit(DD, ID);
        }

    }
}
