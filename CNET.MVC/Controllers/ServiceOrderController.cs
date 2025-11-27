using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CNET.MVC.Repositories;

namespace CNET.MVC.Controllers
{
    [Authorize]
    public class ServiceOrderController : Controller
    {
        private readonly IServiceFormRepository _repository;

        public ServiceOrderController(IServiceFormRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var serviceFormEntry = _repository.GetSomeOrderInfo();
            return View(serviceFormEntry);
        }

        
    }
}