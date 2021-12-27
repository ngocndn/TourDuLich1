using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.DAO;using Tour.BUS;
using Newtonsoft.Json;

namespace TourDuLichSite.Controllers
{
    public class NhanVienController : Controller
    {
        NhanVienDAO nvd = new NhanVienDAO();
        // GET: NhanVien
        public ActionResult Index()
        {
            List<dynamic> listResults = nvd.GetListNhanVienW();
            //convert List<dynamic> sang json
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<NhanVienView>
            var obj = JsonConvert.DeserializeObject<List<NhanVienView>>(objOld);
            ViewBag.listTemp = obj;
            return View();
        }
    }
}