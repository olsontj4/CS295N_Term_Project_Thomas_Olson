using Microsoft.AspNetCore.Mvc;
using QuizCreator.Data;
using QuizCreator.Models;
using QuizCreator.ViewModels;

namespace QuizCreator.Controllers
{
    public class CreatorController : Controller
    {
        private readonly IRepo repo;
        public CreatorController(IRepo r)
        {
            repo = r;
        }
        public IActionResult Creator()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Creator(QuizVM quiz)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine(ModelState.Where(e => e.Value.Errors.Count > 0).ToList()[0].Value.Errors[0].ErrorMessage.ToString());
                quiz.Page--;
                return View("Creator", quiz);
            }
            return View("Creator", quiz);
            repo.StoreQuiz(quiz.Quiz);  //TODO: Write code to store quiz in DB.
            return View();
        }
    }
}
