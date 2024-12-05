using Microsoft.AspNetCore.Mvc;
using QuizCreator.Models;
using System.Diagnostics;

namespace QuizCreator.Controllers
{
    public class QuizController : Controller
    {
        private readonly ILogger<QuizController> _logger;
        public QuizController(ILogger<QuizController> logger)
        {
            _logger = logger;
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
        public IActionResult Creator(Quiz quiz)
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
