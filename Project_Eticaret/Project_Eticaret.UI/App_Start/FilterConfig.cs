﻿using System.Web;
using System.Web.Mvc;

namespace Project_Eticaret.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}