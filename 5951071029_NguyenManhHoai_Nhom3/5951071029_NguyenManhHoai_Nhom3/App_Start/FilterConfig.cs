﻿using System.Web;
using System.Web.Mvc;

namespace _5951071029_NguyenManhHoai_Nhom3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
