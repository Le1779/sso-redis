﻿using DynaFlowWeb.Web.Filter;
using System.Web.Mvc;

namespace WebServer1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new DynacwAuthenticationFilter());
        }
    }
}