using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.DAO;

namespace TourDuLichSite.Controllers
{
    public class DiaDiemController : Controller
    {
        DiaDiemDAO ddd = new DiaDiemDAO();
        // GET: DiaDiem
        public ActionResult Index()
        {
            List<dynamic> listResults = ddd.GetLDD();
            var objOld = JsonConvert.SerializeObject(listResults);
            var obj = JsonConvert.DeserializeObject<List<DiaDiemView>>(objOld);
            ViewBag.listTemp = obj;
            return View();
        }
    }
}