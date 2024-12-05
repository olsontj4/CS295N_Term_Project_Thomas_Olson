﻿using Microsoft.EntityFrameworkCore;
using QuizCreator.Models;

namespace QuizCreator.Data
{
    public class Repo : IRepo
    {
        private readonly AppDbContext context;
        public Repo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public List<Quiz> GetAllQuizzes()
        {
            var quizzes = context.Quizzes
                .Include(q => q.Questions)
                .Include(q => q.EndResults)
                .Include(q => q.AppUser)
                .ToList();
            return quizzes;
        }
        public Quiz GetQuizById(int id)
        {
            var quiz = context.Quizzes
                .Include(q => q.Questions)
                .Include(q => q.EndResults)
                .Include(q => q.AppUser)
                .Where(q => q.Id == id)
                .SingleOrDefault();
            return quiz;
        }
        public int StoreQuiz(Quiz model)
        {
            model.Date = DateTime.Now;
            context.Quizzes.Add(model);
            return context.SaveChanges();
            // returns a positive value if succussful
        }
    }
}