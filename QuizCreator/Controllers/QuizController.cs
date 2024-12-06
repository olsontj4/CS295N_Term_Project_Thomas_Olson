using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuizCreator.Data;
using QuizCreator.Models;
using QuizCreator.ViewModels;
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
            QuizVM vm = new QuizVM();
            vm.Quiz = quiz;
            return View(vm);
        }
        public IActionResult QuizQuestion([FromForm]Quiz quiz)
        {
            int page = quiz.Page;
            quiz = repo.GetQuizById(quiz.Id);
            quiz.Page = page;
            QuizVM vm = new QuizVM();
            vm.Quiz = quiz;
            var answers = quiz.Questions[page - 1].A;
            foreach(var a in answers)
            {
                vm.AnswerInputs.Add(a.AString, false);
            }
            return View("Quiz", vm);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}