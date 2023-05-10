using Microsoft.AspNetCore.Mvc;
using Mid_Term.Models;

namespace Mid_Term.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContex _db;
        public ProductsController(ApplicationDbContex db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Products> objProductsList = _db.Produtcs; // Creates a list using the DbSet called Products from the applicationDbContext file.
            /* var objCategoryList = _db.Categories.ToList();*/ // Creates a list using the DbSet called Products from the applicationDbContext file.
            return View(objProductsList);
        }
    }
}
