using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Retweet.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "SignIn",                                               // Route name
                "SignIn",                                            // URL with parameters
                new { controller = "Account", action = "SignIn" }        // Parameter defaults
            );

            routes.MapRoute(
                "SignOut",                                               // Route name
                "SignOut",                                            // URL with parameters
                new { controller = "Account", action = "SignOut" }        // Parameter defaults
            );

            routes.MapRoute(
                "Callback",                                               // Route name
                "Callback",                                            // URL with parameters
                new { controller = "Account", action = "Callback" }        // Parameter defaults
            );

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}