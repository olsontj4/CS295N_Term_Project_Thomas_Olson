using Microsoft.AspNetCore.Mvc;
using QuizCreator.Data;
using QuizCreator.Models;
using System.Diagnostics;

namespace QuizCreator.Controllers
{
    public class QuizController : Controller
    {
        private readonly IRepo repo;
        public QuizController(IRepo r)
        {
            repo = r;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Creator()
        {
            return View();
        }
        [HttpPut]
        public IActionResult CreatorUpdate(Quiz quiz)
        {
            if (quiz.Page == 0)
            {
                return View(quiz);
            }
            return View(quiz);
        }
        [HttpPost]
        public IActionResult CreatorSubmit(Quiz quiz)
        {
            repo.StoreQuiz(quiz);
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
