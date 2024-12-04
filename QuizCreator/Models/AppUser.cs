using System.ComponentModel.DataAnnotations.Schema;

namespace QuizCreator.Models
{
    public class AppUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserName { get; set; }
        private protected string? Password { get; set; }
    }
}