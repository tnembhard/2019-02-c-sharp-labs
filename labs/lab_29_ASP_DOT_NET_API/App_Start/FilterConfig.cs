﻿using System.Web;
using System.Web.Mvc;

namespace lab_29_ASP_DOT_NET_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
