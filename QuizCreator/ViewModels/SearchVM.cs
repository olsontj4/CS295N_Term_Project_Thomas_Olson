using QuizCreator.Models;

namespace QuizCreator.ViewModels
{
    public class SearchVM
    {
        public List<Quiz>? Quizzes { get; set; } 
        public string? Search { get; set; }
    }
}
