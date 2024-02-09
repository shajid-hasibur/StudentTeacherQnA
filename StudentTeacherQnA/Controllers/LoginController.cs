using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentTeacherQnA.Data;
using StudentTeacherQnA.Models;

namespace StudentTeacherQnA.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public LoginController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Create(User user)

        {

            if (ModelState.IsValid)
            {
                user.Password = _userManager.PasswordHasher.HashPassword(user, user.Password);
                _context.Users.Add(user);
                _context.SaveChanges();

                // Redirect to a confirmation page or homepage
                return RedirectToAction("Index");
            }
            return View("Register", user);
        }
    }
}
