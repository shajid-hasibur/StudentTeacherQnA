using Microsoft.AspNetCore.Mvc;

namespace StudentTeacherQnA.Controllers
{
    public class AnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
