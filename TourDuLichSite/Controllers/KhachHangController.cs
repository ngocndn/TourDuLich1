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
            List<dynamic> listResults = khd.GetListKHW();
            var objOld = JsonConvert.SerializeObject(listResults);
            var obj = JsonConvert.DeserializeObject<List<KhachHangView>>(objOld);
            ViewBag.listTemp = obj;
            return View();
        }
        [HttpGet]
        [Route("GetOneKhachHang")]
        public JsonResult GetOneKhachHang(int MaKH)
        {
            var getKH = khd.GetDetailListW(MaKH);
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("Create")]
        public JsonResult Create(KHACHHANG K)
        {

            return Json(khd.ThemKhachHang(K), JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        [Route("Update")]
        public JsonResult Update(KHACHHANG K, int MaKH)
        {
            return Json(khd.SuaKhachHang(K, MaKH), JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int MaKH)
        {
            return Json(khd.XoaKhachHang(MaKH), JsonRequestBehavior.AllowGet);

        }
    }
}