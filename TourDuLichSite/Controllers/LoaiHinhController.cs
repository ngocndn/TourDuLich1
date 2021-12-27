using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.DAO;using Tour.BUS;
using Newtonsoft.Json;

namespace TourDuLichSite.Controllers
{
    public class LoaiHinhController : Controller
    {
        private LoaiHinhDAO LHD = new LoaiHinhDAO();
        // GET: LoaiHinh
        public ActionResult Index()
        {
            List<dynamic> listResults = LHD.GetList();
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<NhanVienView>
            var obj = JsonConvert.DeserializeObject<List<LoaiHinhView>>(objOld);
            ViewBag.listTemp = obj;
            return View();
        }
        [HttpGet]
        [Route("GetAllLoaiHinhDuLich")]
        public JsonResult GetAllLoaiHinhDuLich()
        {
            var getKH = LHD.GetListLoaiHinh();
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Create")]
        public JsonResult Create(LOAIHINHDULICH lhd)
        {
            return Json(LHD.Add(lhd), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Update")]
        public JsonResult Update(LOAIHINHDULICH lhd, int MaLoaiHinh)
        {
            return Json(LHD.Edit(lhd, MaLoaiHinh), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(LOAIHINHDULICH lhd,int MaLoaiHinh)
        {
            return Json(LHD.Del(lhd, MaLoaiHinh), JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        [Route("GetOneLoaiHinhDuLich")]
        public JsonResult GetOneLoaiHinhDuLich(int MaLoaiHinh)
        {
            var getKH = LHD.GetOneLoaiHinhDL(MaLoaiHinh);
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }
    }
}