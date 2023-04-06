using FptBookStore.Data;
using FptBookStore.Models;
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
        IEnumerable<Category> objCategoryList = _db.Category.ToList();
        return View(objCategoryList);
    }
}