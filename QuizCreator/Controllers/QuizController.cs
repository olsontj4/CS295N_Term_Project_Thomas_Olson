using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            var quizzes = repo.GetAllQuizzes();
            return View(quizzes);
        }
        public IActionResult Quiz(int id)
        {
            var quiz = repo.GetQuizById(id);
            return View(quiz);
        }
        [HttpPost]
        public IActionResult QuizQuestion([FromForm]Quiz quiz)
        {
            return View("Quiz", quiz);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
