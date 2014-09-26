using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Angular_MVC_Flot
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      ConfigureFormatters();

      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      WebApiConfig.Register(GlobalConfiguration.Configuration);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

    private static void ConfigureFormatters()
    {
      GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

      var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

      json.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
      json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
      json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;

    }
  }
}
