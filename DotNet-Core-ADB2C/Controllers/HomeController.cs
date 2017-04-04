using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "My Web Site";
            ViewBag.DisplayName = "Default User";
            return View();
        }

        public IActionResult Fonts()
        {
            return View();
        }

        public IActionResult Icons()
        {
            return View();
        }

        public IActionResult Colors()
        {
            return View();
        }

        public IActionResult Error(string message)
        {
            ViewBag.Message = message;
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
