﻿using System.ComponentModel.DataAnnotations;

namespace QuizCreator.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        [Range(1, 100)]
        public string Title { get; set; }
        [Required]
        [Range(1, 200)]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        public List<Question>? Questions { get; set; }
        public Scoring? Scoring { get; set; }
        [Required]
        public AppUser? AppUser { get; set; }
    }
}