﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using Analytics.App_Start;
//using Analytics.App_Start;
namespace Analytics
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }
    }
    //public class WebApiApplication : System.Web.HttpApplication
    //{
    //    protected void Application_Start()
    //    {
    //        WebApiConfig.Register(GlobalConfiguration.Configuration);
    //    }

    //    protected void Application_BeginRequest()
    //    {
    //        //if(Request.Headers.AllKeys.Contains("Orgin")&&Request.HttpMethod=="OPTIONS")
    //        //{
    //            Response.Flush();
    //        //}
    //    }
   // }
}
