using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizCreator.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public int QuizId { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public bool MultipleAnswers { get; set; }
        [Required]
        public string Q {  get; set; }
        [Required]
        [NotMapped]
        public List<string> A { get; set; }
        [NotMapped]
        public List<bool>? UserA { get; set; }
        [Required]
        [NotMapped]
        public List<bool> AKey { get; set; }
    }
}