using Microsoft.AspNetCore.Mvc;
using PracticeMVC.Data;
using PracticeMVC.Models;

namespace PracticeMVC.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;


        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryModel> objCatList = _db.Categories;
            return View(objCatList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
