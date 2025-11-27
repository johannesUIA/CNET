using Microsoft.AspNetCore.Mvc;

namespace CNET.MVC.Controllers;

public class PrivacyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}