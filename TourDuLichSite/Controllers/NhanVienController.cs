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
            var objOld = JsonConvert.SerializeObject(listResults);
            var obj = JsonConvert.DeserializeObject<List<NhanVienView>>(objOld);
            ViewBag.listTemp = obj;
            return View();
        }
        [HttpGet]
        [Route("GetOneNhanVien")]
        public JsonResult GetOneNhanVien(int MaNV)
        {
            var getNhanVien = nvd.GetListDetailsNhanVienW(MaNV);
            return Json(getNhanVien, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Create")]
        public JsonResult Create(NHANVIEN NV)
        {

            return Json(nvd.ThemNhanVien(NV), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(NHANVIEN NV, int MaNV)
        {
            return Json(nvd.SuaNhanVien(NV, MaNV), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int MaNV)
        {
            return Json(nvd.XoaNhanVien(MaNV), JsonRequestBehavior.AllowGet);

        }

    }
}