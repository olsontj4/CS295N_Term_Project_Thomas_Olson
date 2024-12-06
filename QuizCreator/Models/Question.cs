using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizCreator.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public bool MultipleAnswers { get; set; }
        [Required]
        public string Q {  get; set; }
        [Required]
        public List<A> A { get; set; } = new();
        public List<UserA>? UserA { get; set; }
        [Required]
        public List<AKey> AKey { get; set; } = new();
    }
    public class A
    {
        public int Id { get; set; }
        [Required]
        public string AString { get; set; }
    }
    public class UserA
    {
        public int Id { get; set; }
        public bool UserABool { get; set; }
    }
    public class AKey
    {
        public int Id { get; set; }
        [Required]
        public bool AKeyBool { get; set; }
    }
}