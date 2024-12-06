using System.ComponentModel.DataAnnotations;

namespace QuizCreator.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        public List<Question>? Questions { get; set; }
        public EndResult? EndResult { get; set; }
        [Required]
        public AppUser? AppUser { get; set; }
        public DateTime? Date { get; set; }
        public bool IsComplete { get; set; }
    }
}