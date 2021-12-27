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
            List<dynamic> listResults = td.GetListTourW();
            var objOld = JsonConvert.SerializeObject(listResults);
            var obj = JsonConvert.DeserializeObject<List<TourView>>(objOld);

            ViewBag.listTemp = obj;

            return View();
        }
        [HttpGet]
        [Route("GetAllTour")]
        public JsonResult GetAllTour()
        {
            var getTour = td.GetAllTour();
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Create")]
        public JsonResult Create(TOURDULICH T)
        {

            return Json(td.ThemTour(T), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(TOURDULICH T, int MaTour)
        {
            return Json(td.SuaTour(T, MaTour), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int MaTour)
        {
            return Json(td.XoaTour(MaTour), JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        [Route("GetOneTour")]
        public JsonResult GetOneTour(int MaTour)
        {
            var getTour = td.GetOneTour(MaTour);
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        [Route("GetBangGiaTour")]
        public JsonResult GetBangGiaTour(int MaTour)
        {
            var getGiaTour = gd.GetGiaTourWithMaTour(MaTour);
            return Json(getGiaTour, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("CreateGiaTour")]
        public JsonResult CreateGiaTour(GIATOUR G)
        {
            var getGiaTour = gd.ThemGiaTour(G);
            return Json(getGiaTour, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("UpdateGiaTour")]
        public JsonResult UpdateGiaTour(TOURDULICH T, int MaTour)
        {
            var getTour = td.SuaGiaTour(T, MaTour);
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }
    }
}