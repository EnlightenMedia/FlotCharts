﻿using System.Web;
using System.Web.Mvc;

namespace Angular_MVC_Flot
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
