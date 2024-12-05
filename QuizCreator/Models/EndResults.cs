using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizCreator.Models
{
    public class EndResults
    {
        public int Id { get; set; }
        [Required]
        public int QuizId { get; set; }
        [Required]
        [NotMapped]
        public List<string> EndResult { get; internal set; }
        [Required]
        [NotMapped]
        public List<string> EndMessage { get; set; }
        [Range(0, 100)]
        public int Score { get; set; }
        [Required]
        public bool DisplayScore { get; set; }
    }
}