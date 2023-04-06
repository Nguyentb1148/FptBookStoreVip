using Microsoft.AspNetCore.Mvc;

namespace FptBookStore.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}