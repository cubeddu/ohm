using System;
using Xunit;
using cal.Controllers;
using Microsoft.AspNetCore.Mvc;
using cal.Models;

namespace caltests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidateIndexAsView()
        {
            HomeController method = new cal.Controllers.HomeController();

            IActionResult result = method.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ValidateOhmValueCalculator()
        {
            HomeController method = new cal.Controllers.HomeController();

            Assert.Equal(110, method.CalculateOhmValue("1","1","10","5"));

        }

    }
}
