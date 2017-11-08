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
        public IActionResult Submit()
        {
            OhmValueCalculator viewModel = new OhmValueCalculator()
            {
                bandAColor = HttpContext.Request.Form["band1"].ToString(),
                bandBColor = HttpContext.Request.Form["band2"].ToString(),
                bandCColor = HttpContext.Request.Form["multiplier"].ToString(),
                bandDColor = HttpContext.Request.Form["tolerance"].ToString()
            };

            Int64 ohm = CalculateOhmValue(viewModel.bandAColor,viewModel.bandBColor,viewModel.bandCColor,viewModel.bandDColor);

            ViewBag.ohmValue = ohm.ToString();
            ViewBag.Tolerance = viewModel.bandDColor + "%";

            return View("Index");
        }

        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            //convert String to int
            int bandAColorInt = Convert.ToInt32(bandAColor);
            int bandBColorInt = Convert.ToInt32(bandBColor);
            decimal bandCColorInt = decimal.Parse(bandCColor);

            Int64 ohmValue = (Int64)((bandAColorInt * 10 + bandBColorInt) * bandCColorInt);
         
            return (int)ohmValue;
        }

    }
}
