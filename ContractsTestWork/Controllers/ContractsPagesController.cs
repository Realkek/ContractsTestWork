using Microsoft.AspNetCore.Mvc;

namespace ContractsTestWork.Controllers;

public class ContractsPagesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Import()
    {
        return View();
    }
}