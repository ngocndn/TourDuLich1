using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.DAO;using Tour.BUS;
using Newtonsoft.Json;

namespace TourDuLichSite.Controllers
{
    public class TourController : Controller
    {
        TourDAO td = new TourDAO();
        GiaDAO gd = new GiaDAO();
        // GET: Tour
        public ActionResult Index()
        {
            List<dynamic> listResults = td.GetListTour();

            //convert List<dynamic> sang json
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<NhanVienView>
            var obj = JsonConvert.DeserializeObject<List<TourView>>(objOld);

            ViewBag.listTemp = obj;

            return View();
        }
        [HttpPost]
        [Route("Create")]
        public JsonResult Create(TOURDULICH T)
        {

            return Json(td.ThemTour(T), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(TOURDULICH T, int ID)
        {
            return Json(td.SuaTour(T, ID), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int ID)
        {
            return Json(td.XoaTour(ID), JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        [Route("GetOneTour")]
        public JsonResult GetOneTour(int ID)
        {
            var getTour = td.GetOneTour(ID);
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }
    }
}