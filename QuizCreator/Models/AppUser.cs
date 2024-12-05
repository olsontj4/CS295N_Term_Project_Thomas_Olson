using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizCreator.Models
{
    public class AppUser
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserName { get; set; }
    }
}