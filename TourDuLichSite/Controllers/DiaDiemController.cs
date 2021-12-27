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
        [HttpGet]
        [Route("GetAllDiaDiemDen")]
        public JsonResult GetAllDiaDiemDen()
        {
            var getDDD = ddd.GetListDiaDiem();
            return Json(getDDD, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        [Route("GetOneDiaDiemDen")]
        public JsonResult GetOneDiaDiemDen(int MaDiaDiem)
        {
            var getDDD = ddd.GetDiaDiem(MaDiaDiem);
            return Json(getDDD, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Create")]
        public JsonResult Create(DIADIEM D)
        {
            return Json(ddd.AddDiaDiem(D), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Update")]
        public JsonResult Update(DIADIEM D, int MaDiaDiem)
        {
            return Json(ddd.Edit(D, MaDiaDiem), JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(DIADIEM D, int MaDiaDiem)
        {
            return Json(ddd.Delete(D, MaDiaDiem), JsonRequestBehavior.AllowGet);

        }
    }
}