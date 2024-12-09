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
            var creatorVM = new CreatorVM();
            creatorVM.Page = 0;
            ViewBag.ErrorMessage = "Quiz Creator is currently unavailable.";
            return View(creatorVM);
        }
        public IActionResult CreatorStart(CreatorVM creatorVM)
        {
            if (creatorVM.Quiz != null && ModelState.IsValid )  //Success condition.
            {
                ViewBag.ErrorMessage = "Quiz Creator is currently unavailable.";
                return View("Creator", creatorVM);
            }
            else  //Failure condition.
            {
                if (ModelState.Where(e => e.Value.Errors.Count > 0).ToList()[0].Value.Errors[0].ErrorMessage.ToString() != null)
                {
                    ViewBag.ErrorMessage = ModelState.Where(e => e.Value.Errors.Count > 0).ToList()[0].Value.Errors[0].ErrorMessage.ToString();
                }
                else
                {
                    ViewBag.ErrorMessage = "Error saving quiz.";
                }
                creatorVM.Page = 0;
                return View("Creator", creatorVM);
            }
        }
        public IActionResult CreatorQuestion(CreatorVM creatorVM)
        {
            if(creatorVM.AddAnswer == true)
            {
                creatorVM.Quiz.Questions[creatorVM.Page].A.Add(new());
                creatorVM.AddAnswer = false;
                creatorVM.Page = creatorVM.Quiz.Questions.Count;
                return View("Creator", creatorVM);
            }
            if (creatorVM.Quiz.Questions[creatorVM.Page - 1] != null && ModelState.IsValid)  //Success condition.
            {
                ViewBag.ErrorMessage = "Quiz Creator is currently unavailable.";
                creatorVM.Quiz.Questions.Add(new());
                creatorVM.Quiz.Questions[creatorVM.Page].A.Add(new());
                creatorVM.Quiz.Questions[creatorVM.Page].A.Add(new());
                creatorVM.Page = creatorVM.Quiz.Questions.Count;
                return View("Creator", creatorVM);
            }
            else  //Failure condition.
            {
                if (ModelState.Where(e => e.Value.Errors.Count > 0).ToList()[0].Value.Errors[0].ErrorMessage.ToString() != null)
                {
                    ViewBag.ErrorMessage = ModelState.Where(e => e.Value.Errors.Count > 0).ToList()[0].Value.Errors[0].ErrorMessage.ToString();
                }
                else
                {
                    ViewBag.ErrorMessage = "Error saving quiz.";
                }
                creatorVM.Page = creatorVM.Quiz.Questions.Count;
                return View("Creator", creatorVM);
            }
            return View("Creator"/*, quiz*/);
            repo.StoreQuiz(creatorVM.Quiz);  //TODO: Write code to store quiz in DB.
            return View();
        }
    }
}