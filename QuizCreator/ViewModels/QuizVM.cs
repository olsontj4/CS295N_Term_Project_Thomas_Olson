using QuizCreator.Models;

namespace QuizCreator.ViewModels
{
    public class QuizVM
    {
        public Quiz? Quiz { get; set; }
        public Dictionary<string, bool>? AnswerInputs { get; set; } = new();
        public List<string>? UserA { get; set; } = new();
        public string? AnswerInput { get; set; }
        public int Page { get; set; }
        public int Score { get; set; }
        public string? EndTitle { get; set; }
        public string? EndMessage { get; set; }
    }
}