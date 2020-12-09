using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using MvcPortal.Models;

namespace MvcPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Intervention()
        {

            string customerEmail = User.Identity.Name;
            var user = await CustomerController.GetCustomer(customerEmail);
            ViewBag.Customer = user.companyName; // Get customer for the Intervention view

            var buildingsList = await CustomerController.GetCustomerBuildingsList(user.id);
            ViewBag.Buildings = buildingsList;

            var batteriesList = await CustomerController.GetCustomerBatteriesList(user.id);
            ViewBag.Batteries = batteriesList;

            var columnsList = await CustomerController.GetCustomerColumnsList(user.id);
            ViewBag.Columns = columnsList;

            var elevatorsList = await CustomerController.GetCustomerElevatorsList(user.id);
            ViewBag.Elevators = elevatorsList;

        
            return View();
        }

        // [Authorize]
        // public async Task<IActionResult> Products()
        // {
        //     return View();
        // }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
