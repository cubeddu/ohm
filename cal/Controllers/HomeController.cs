using System;
using System.Diagnostics.Contracts;
using cal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cal.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult add()
        {
            int band1 = Convert.ToInt32(HttpContext.Request.Form["band1"].ToString());
            int band2 = Convert.ToInt32(HttpContext.Request.Form["band2"].ToString());
            int band3 = Convert.ToInt32(HttpContext.Request.Form["band3"].ToString());
            String band4 = HttpContext.Request.Form["band4"].ToString();

            String result = (band1 * 10 + band2) * band3 + " Ohms";
            String tolerance = band4 + "%";

            ViewBag.SumResult = result.ToString();
            ViewBag.Tolerance = tolerance.ToString();
            return View("Index");
        }
    }
}
