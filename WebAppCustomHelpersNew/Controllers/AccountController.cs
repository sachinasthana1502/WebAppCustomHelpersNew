﻿using Microsoft.AspNetCore.Mvc;

namespace WebAppCustomHelpersNew.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {

            return View();
        }

    }
}
