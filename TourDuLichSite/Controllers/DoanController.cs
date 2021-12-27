using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.DAO;using Tour.BUS;
using Newtonsoft.Json;

namespace TourDuLichSite.Controllers
{
    public class DoanController : Controller
    {
        DoanDAO dd = new DoanDAO();
        // GET: Doan
        public ActionResult Index()
        {
            List<dynamic> listResults = dd.getListDoanW();
            var objOld = JsonConvert.SerializeObject(listResults);
            var obj = JsonConvert.DeserializeObject<List<DoanView>>(objOld);
            ViewBag.listTemp = obj;
            return View();
        }
    }
}