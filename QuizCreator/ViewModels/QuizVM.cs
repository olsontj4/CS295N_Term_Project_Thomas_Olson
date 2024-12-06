using QuizCreator.Models;

namespace QuizCreator.ViewModels
{
    public class QuizVM
    {
        public Quiz? Quiz { get; set; }
        public Dictionary<string, bool>? AnswerInputs { get; set; } = new();
    }
}
