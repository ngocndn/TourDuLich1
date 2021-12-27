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
        [HttpGet]
        [Route("GetOneDoan")]
        public JsonResult GetOneDoan(int MaDOANDL)
        {
            var getDoan = dd.GetOneDoan(MaDOANDL);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        [Route("GetAllDoan")]
        public JsonResult GetAllDoan()
        {
            var getDoan = dd.getall();
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Create")]
        public JsonResult Create(DOANDL D)
        {

            return Json(dd.Add(D), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(DOANDL D, int MaDOANDL)
        {
            return Json(dd.Edit(D, MaDOANDL), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int MaDOANDL)
        {
            return Json(dd.Delete(MaDOANDL), JsonRequestBehavior.AllowGet);

        }
    }
}