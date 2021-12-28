using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.DAO;

namespace TourDuLichSite.Controllers
{
    public class BookingController : Controller
    {
        BookingDAO bd = new BookingDAO();
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("GetListKH")]
        public JsonResult GetListKH(int MaDOANDL)
        {
            var getKH = bd.GetDetailW(MaDOANDL);
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }
    }
}