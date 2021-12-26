using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; using Tour.BUS;using Tour.DAO;

namespace TourWeb.Controllers
{
    public class LoaiHinhController : Controller
    {
        LoaiHinhDAO LHD = new LoaiHinhDAO();
        public ActionResult Index()
        {
            List<LOAIHINHDULICH> listResult = LHD.GetListLoaiHinh();
            ViewBag.listTemp = listResult;
            return View();
        }
        [HttpGet]
        [Route("GetAllLoaiHinhDuLich")]
        public JsonResult GetAllLoaiHinhDuLich()
        {
            var getLH = LHD.GetListLoaiHinh();
            return Json(getLH, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Create")]
        public JsonResult Create(LOAIHINHDULICH LH)
        {

            return Json(LHD.Add(LH), JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        [Route("Update")]
        public JsonResult Update(LOAIHINHDULICH LH, int MaLH)
        {
            return Json(LHD.Edit(LH, MaLH), JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(LOAIHINHDULICH LH, int MaLH)
        {
            return Json(LHD.Del(LH, MaLH), JsonRequestBehavior.AllowGet);

        }
    }
}