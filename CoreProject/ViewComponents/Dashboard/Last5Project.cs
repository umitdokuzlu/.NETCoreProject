﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class Last5Project: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
