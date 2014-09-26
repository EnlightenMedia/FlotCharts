using System.Web.Http;

namespace Angular_MVC_Flot
{
  public class WebApiConfig
  {
    public static void Register(HttpConfiguration configuration)
    {
      configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
          new { id = RouteParameter.Optional });
    }
  }
}