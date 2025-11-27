using CNET.MVC.DataAccess;
using CNET.MVC.Models;
using CNET.MVC.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CNET.MVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation("Index method called");

            var model = new RazorViewModel
            {
                Content = "Ansatte i Nøsted &",
                AdditionalData = "Hilsen produktutviklerne av Systemet"
            };
            return View("Index", model);
        }
    }
}