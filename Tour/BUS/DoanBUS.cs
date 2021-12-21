﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;

namespace Tour.BUS
{
    public class DoanBUS
    {
        DoanDAO DD = new DoanDAO();
        public List<DOANDL> getall()
        {
            return DD.getall();
        }
        public List<CHIPHI> getKS()
        {
            return DD.GetChiPhiKS();
        }

        public List<CHIPHI> getBUS()
        {
            return DD.GetChiPhiDC();
        }
        public List<DOANDL> Get1(int DoanID)
        {
            return DD.GetOneDoan(DoanID);
        }
        public List<dynamic> GetListDoan()
        {
            return DD.getListDoan();
        }
        public bool Add(DOANDL D)
        {
            return DD.Add(D);
        }

        public bool Edit(DOANDL D, int DoanID)
        {
            return DD.Edit(D, DoanID);
        }

        public bool Delete(int DoanID)
        {
            return DD.Delete(DoanID);
        }
        public bool DeletefromTour(DOANDL D,int TourID)
        {
            return DD.DeletefromTour(D,TourID);
        }
        public List<dynamic> GetDetail( int DoanID)
        {
            return DD.GetDDetail(DoanID);
        }
    }
}
