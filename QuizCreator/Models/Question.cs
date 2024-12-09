﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace QuizCreator.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Q {  get; set; }
        [Required]
        public List<A> A { get; set; } = new();
        [Required]
        public List<AKey>? AKey { get; set; } = new();
    }
    public class A
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string AString { get; set; }
    }
    public class AKey
    {
        private bool aKeyBool;
        public int Id { get; set; }
        [Required]
        public bool AKeyBool { get; set; } = false;
        /*{
            get { return aKeyBool; }
            set { aKeyBool = value ?? false; }
        }*/
    }
}