﻿using Microsoft.AspNetCore.Mvc;

namespace MindTrade.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
