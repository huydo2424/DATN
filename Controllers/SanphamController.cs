using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DQH_DATN.Models;

namespace DQH_DATN.Controllers
{
    public class SanphamController : Controller
    {
        // GET: Sanpham
        public ActionResult DanhsachSP(int id)
        {
            DQH_DATNEntities db = new DQH_DATNEntities();
            tblDanhmucSP danhmuc = db.tblDanhmucSP.Find(id);
            ViewBag.danhmuc = danhmuc;
            ViewBag.dsSP = db.spSanpham_getbyDanhmuc(1);
            ViewBag.id = id;
            //Lấy ra danh sách các sản phẩm
            List<tblSanpham> sanpham = db.tblSanpham.ToList();
            var ds = db.spSanpham_getbyDanhmuc(id);
            if (ds.Count() ==0)
            {
                ViewBag.soluong = 0;
            }    
            return View(sanpham);
        }
        public ActionResult ChitietSP(int id)
        {
            //Tìm đối tượng trong DB
            DQH_DATNEntities db = new DQH_DATNEntities();
            tblSanpham chitiet = db.tblSanpham.Find(id);
            return View(chitiet);
        }
        public ActionResult Theloai(string theLoai)
        {
            ViewBag.theLoai = theLoai;
            return View();
        }
         
        public ActionResult Insert()
        {
            return View(new tblSanpham());
        }
    }
}