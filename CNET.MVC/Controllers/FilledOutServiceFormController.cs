using Microsoft.AspNetCore.Mvc;
using CNET.MVC.Repositories;

namespace CNET.MVC.Controllers;

public class FilledOutServiceFormController : Controller
{
    private readonly IServiceFormRepository _repository;

    public FilledOutServiceFormController(IServiceFormRepository repository)
    {
        _repository = repository;
    }
    
    public IActionResult Index(int id)
    {
        var ServiceFormEntry = _repository.GetOneRowById(id);
        if (ServiceFormEntry == null)
        {
            return NotFound();
        }
        return View(ServiceFormEntry);
    }
}