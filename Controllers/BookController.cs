using FptBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using FptBookStore.Models;

namespace FptBookStore.Controllers;

public class BookController : Controller
{
    private readonly ApplicationDbContext _db;
    public BookController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
        var bookFromDb = _db.Books.ToList();
        return View(bookFromDb);
    }
}