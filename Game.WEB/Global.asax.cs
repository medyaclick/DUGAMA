using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Game.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Application_BeginRequest(Object source, EventArgs e)
        {
            HttpApplication app = (HttpApplication)source;
            HttpContext context = app.Context;
#if DEBUG
            FirstRequestInitialisation.Initialise(context);
#else
              FirstRequestInitialisation.Initialise(context);
#endif
        }

        class FirstRequestInitialisation
        {
            private static string host = null;

            private static Object s_lock = new Object();

            // Initialise only on the first request
            public static void Initialise(HttpContext context)
            {
                if (string.IsNullOrEmpty(host))
                {
                    lock (s_lock)
                    {
                        if (string.IsNullOrEmpty(host))
                        {
                            Uri uri = HttpContext.Current.Request.Url;
                            //host = uri.Scheme + Uri.SchemeDelimiter + uri.Host + ":" + uri.Port;
                            host = uri.Host;
                            new Game.BUS.Site().SetSiteId(host);
                        }
                    }
                }
            }
        }
    }
}
