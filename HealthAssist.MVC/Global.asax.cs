using HealthAssist.MVC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]

namespace HealthAssist.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        } 

        protected void Application_BeginRequest()
        {
            Debug.WriteLine("Begin request");
        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map Handler");
        }

        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Post Map Handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Acquiring Request State");
        }


        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Pre Request Handler");
        }

        protected void Application_PostRequestHandlerState()
        {
            Debug.WriteLine("Post Handler Execute");
        }

        protected void Application_End()
        {
            Debug.WriteLine("Ended application");
        }


    }
}
