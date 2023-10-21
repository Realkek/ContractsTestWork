using Microsoft.AspNetCore.Mvc;

namespace ContractsTestWork.Controllers;

public class ContractsPagesController : Controller
{
    // Метод Index
    public IActionResult Index()
    {
        // Здесь можно реализовать отображение списка договоров и их этапов через JavaScript.
        // Вам также потребуется соответствующий представление (View) для этого действия.
        return View();
    }

    // Метод Import
    public IActionResult Import()
    {
        // Здесь можно создать статичную страницу для загрузки файла Excel.
        // Вам также потребуется соответствующий представление (View) для этого действия.
        return View();
    }
}