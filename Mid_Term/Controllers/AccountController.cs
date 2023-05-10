using Microsoft.AspNetCore.Mvc;
using Mid_Term.Models;
using Microsoft.Data.SqlClient;


namespace Mid_Term.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContex _db;
        public AccountController(ApplicationDbContex db)
        {
            _db = db;
        }
        public IActionResult Create()
        {
            return View();
        }
        //POST method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account obj)
        {
            if (ModelState.IsValid) // Server Side Validation... This checks the Account model properties to see whether any of the data annotations ([Key] or [Required]) are vaild
            {
                _db.Account.Add(obj); // These two lines of code are needed when you want to add a user into the database you created
                _db.SaveChanges();       // The first one adds the new entries created and the second piece of codes saves the changes made
                                         //
            }
            TempData["success"] = "Account Created Successfully";
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(string username, string password) 
        {
            if (ModelState.IsValid)
            {
                var user = _db.Account.FirstOrDefault(u => u.UserName == username && u.Password == password);
                if (user == null)
                {
                    TempData["failed"] = "Wrong User Name or Password";
                    return View("Login");
                }
                TempData["success"] = $"Welcome {user.UserName}!! ";
                return RedirectToAction("Index", "Products");
            }
            TempData["failed"] = "Wrong User Name or Password";
            return View("Login");
        }
    }
}
