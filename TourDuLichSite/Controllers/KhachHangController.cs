using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.DAO;

namespace TourDuLichSite.Controllers
{
    public class KhachHangController : Controller
    {
        KhachHangDAO khd = new KhachHangDAO();
        // GET: KhachHang
        public ActionResult Index()
        {
            List<dynamic> listResults = khd.GetListKH();
            var objOld = JsonConvert.SerializeObject(listResults);
            var obj = JsonConvert.DeserializeObject<List<KhachHangView>>(objOld);
            ViewBag.listTemp = obj;
            return View();
        }
    }
}