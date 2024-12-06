using QuizCreator.Models;
using System.Runtime.CompilerServices;

namespace QuizCreator.Data
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Quizzes.Any())  // this is to prevent adding duplicate data
            {
                AppUser user1 = new AppUser { UserName = "Thomasj041" };  // Create User objects
                context.AppUsers.Add(user1);  // Queue up user objects to be saved to the DB
                context.SaveChanges();  // Saving adds UserId to User objects
                Quiz quiz1 = new Quiz()
                {
                    Id = 1,
                    Title = "Are you in the Kool Kids Klub?",
                    Description = "Take this quiz to figure out if you're a true Kool Kid!",
                    Type = "Trivia",
                    AppUser = user1,
                    Date = DateTime.Parse("12/04/2024"),
                    IsComplete = true,
                    Questions = new List<Question>()
                    {
                        new Question()
                        {
                            QuizId = 1,
                            Q = "Are you in the Kool Kids Klub?",
                            A = new List<string>()
                            {
                                "Yes.",
                                "No."
                            },
                            AKey = new List<bool>()
                            {
                                true,
                                false
                            },
                            MultipleAnswers = false
                        },
                        new Question()
                        {
                            QuizId = 1,
                            Q = "Do you want to be in the Kool Kids Klub?",
                            A = new List<string>()
                            {
                                "Yes.",
                                "No."
                            },
                            AKey = new List<bool>()
                            {
                                true,
                                false
                            },
                            MultipleAnswers = false
                        },
                    },
                    EndResults = new EndResults()
                    {
                        QuizId = 1,
                        EndResult = new List<string>()
                        {
                            "You are in the Kool Kids Klub!"
                        },
                        EndMessage = new List<string>()
                        {
                            "I knew you always were a Kool Kid."
                        },
                        DisplayScore = false
                    }
                };
                context.Quizzes.Add(quiz1);  // queues up a quiz to be added to the DB
                context.SaveChanges(); // stores all the quizzes in the DB
            }
        }
    }
}
