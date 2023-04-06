using FptBookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace FptBookStore.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;

    public CategoryController(ApplicationDbContext db)
    {
        _db = db;

    }
    // GET
    public IActionResult Index()
    {
        var objCategoryList = _db.Category.ToList();
        return View();
    }
}