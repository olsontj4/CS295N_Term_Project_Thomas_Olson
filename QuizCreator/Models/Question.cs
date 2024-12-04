using System.ComponentModel.DataAnnotations;

namespace QuizCreator.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public int QuizId { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public bool MultipleAnswers { get; set; }
        [Required]
        public List<string> Q {  get; set; }
        [Required]
        public List<string> A { get; set; }
        public List<string> UserA { get; set; }
    }
}