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
        BookingDAO bd = new BookingDAO();
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
        [HttpGet]
        [Route("GetListKH")]
        public JsonResult GetListKH(int MaDOANDL)
        {
            var getKH = bd.GetDetailW(MaDOANDL);
            return Json(getKH, JsonRequestBehavior.AllowGet);
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
        public ActionResult Detail(int MaDOANDL)
        {
            List<dynamic> listResults = dd.GetDDetailW(MaDOANDL);
            var objOld = JsonConvert.SerializeObject(listResults);
            var obj = JsonConvert.DeserializeObject<List<DoanView>>(objOld);
            ViewBag.listTemp = obj;
            var GetDoan = dd.GetOneDoan(MaDOANDL);
            ViewBag.listOneDoan = GetDoan;

            var getListKHDK = bd.GetDetailW(MaDOANDL);
            //convert List<dynamic> sang json
            var getListKHDKobjOld = JsonConvert.SerializeObject(getListKHDK);
            //convert json sang List<View>
            var getListKHDKobj = JsonConvert.DeserializeObject<List<BookingView>>(getListKHDKobjOld);
            ViewBag.listKHDK = getListKHDKobj;
            return View();
        }
        
    }
}