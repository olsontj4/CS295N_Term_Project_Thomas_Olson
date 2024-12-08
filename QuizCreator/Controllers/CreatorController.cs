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
            ViewBag.ErrorMessage = "Quiz Creator is currently unavailable.";
            return View();
        }
        [HttpPost]
        public IActionResult Creator(CreatorVM quiz)
        {
            if (!ModelState.IsValid)
            {
                //ViewBag.ErrorMessage = ModelState.Where(e => e.Value.Errors.Count > 0).ToList()[0].Value.Errors[0].ErrorMessage.ToString();
                ViewBag.ErrorMessage = "Quiz Creator is currently unavailable.";
                //quiz.Page--;
                return View("Creator"/*, quiz*/);
            }
            return View("Creator"/*, quiz*/);
            repo.StoreQuiz(quiz.Quiz);  //TODO: Write code to store quiz in DB.
            return View();
        }
    }
}