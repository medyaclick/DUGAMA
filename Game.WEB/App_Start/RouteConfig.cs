using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Game.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Play",
                url: "game/{id}",
                defaults: new { controller = "Game", action = "Play", id = UrlParameter.Optional }
            );

            /*routes.MapRoute(
                name: "Category",
                url: "{id}-oyunlari",
                defaults: new { controller = "Category", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "GameDesc",
                url: "{id}-oyunu",
                defaults: new { controller = "GameDescription", action = "Index", id = UrlParameter.Optional }
            );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
