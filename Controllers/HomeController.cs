using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DQH_DATN.Models;

namespace DQH_DATN.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DQH_DATNEntities db = new DQH_DATNEntities();
            List<tblSanpham> sanpham = db.tblSanpham.ToList();
            return View(sanpham);
        }
        public ActionResult Lienhe()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}