using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RotasMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "All_News",
                url: "Noticias/",
                defaults: new { controller = "News", action = "AllNews", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Last_News",
                url: "Ultimas_Noticias/",
                defaults: new { controller = "News", action = "LastNews", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Select_News",
                url: "Noticias/{category}/{titleNews}/{newsIdChosed}",
                defaults: new { controller = "News", action = "ShowNews", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Select_Category",
                url: "Noticas/{category}",
                defaults: new { controller = "News", action = "ShowCategory", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
