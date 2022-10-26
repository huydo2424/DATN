using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DQH_DATN
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //DSSP
            routes.MapRoute(
               name: "DanhsachSP",
               url: "danh-sach-SP",
               defaults: new { controller = "Sanpham", action = "DanhsachSP", id = UrlParameter.Optional }
           );
            //CTSP
            routes.MapRoute(
               name: "ChitietSP",
               url: "chi-tiet-SP",
               defaults: new { controller = "Sanpham", action = "ChitietSP", id = UrlParameter.Optional }
           );
            //Trang chu
            routes.MapRoute(
               name: "Trangchu",
               url: "trang-chu",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
            //Thông tin 
            routes.MapRoute(
              name: "Thongtin",
              url: "thong-tin",
              defaults: new { controller = "Home", action = "Lienhe", id = UrlParameter.Optional }
          );
            //Login
            routes.MapRoute(
              name: "Login",
              url: "login",
              defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
          );
            //Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
