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
                AppUser user2 = new AppUser { UserName = "Than" };
                AppUser logan = new AppUser { UserName = "Logan" };
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
                            Q = "Are you in the Kool Kids Klub?",
                            A = new()
                            {
                                new() { AString = "Yes." },
                                new() { AString = "No." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Do you want to be in the Kool Kids Klub?",
                            A = new()
                            {
                                new() { AString = "Yes." },
                                new() { AString = "No." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                    },
                    EndResult = new EndResult()
                    {
                        EndTitles = new()
                        {
                            new() { EndResultString = "You are in the Kool Kids Klub!" }
                        },
                        EndMessages = new()
                        {
                            new() { EndResultString = "I knew you always were a Kool Kid. (There's no other option.)" }
                        },
                        DisplayScore = false
                    }
                };
                Quiz quiz2 = new Quiz()
                {
                    Id = 2,
                    Title = "Are you Than?",
                    Description = "Take this quiz to figure out if you're a certified Than!",
                    Type = "Trivia",
                    AppUser = user2,
                    Date = DateTime.Parse("12/06/2024"),
                    IsComplete = true,
                    Questions = new List<Question>()
                    {
                        new Question()
                        {
                            Q = "What's your name?",
                            A = new()
                            {
                                new() { AString = "Dylan." },
                                new() { AString = "Logan." },
                                new() {AString = "Than." },
                                new() {AString = "Thomas." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "What's your opinion on toast?",
                            A = new()
                            {
                                new() { AString = "I love it." },
                                new() { AString = "I hate it." },
                                new() { AString = "I'm toast." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = true }
                            }
                        },
                        new Question()
                        {
                            Q = "What's your profile picture?",
                            A = new()
                            {
                                new() { AString = "Aubrey." },
                                new() { AString = "Basil." },
                                new() { AString = "Kel." },
                                new() { AString = "Sprout mole." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = false },
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Yummy Thomas?",
                            A = new()
                            {
                                new() { AString = "Yummy Thomas. >:3" },
                                new() { AString = "Yes." },
                                new() { AString = "Maybe." },
                                new() { AString = "Not really." },
                                new() { AString = "No." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                    },
                    EndResult = new EndResult()
                    {
                        EndTitles = new()
                        {
                            new() { EndResultString = "You're a certified Than!!" },
                            new() { EndResultString = "You might be a Than." },
                            new() { EndResultString = "You're not a Than." }
                        },
                        EndMessages = new()
                        {
                            new() { EndResultString = "You're the coolest guy bestest guy." },
                            new() { EndResultString = "Not a fully fledged one, though." },
                            new() { EndResultString = "What's wrong with you?" }
                        },
                        DisplayScore = false
                    }
                };
                context.Quizzes.Add(quiz1);  // queues up a quiz to be added to the DB
                context.Quizzes.Add(quiz2);
                context.SaveChanges(); // stores all the quizzes in the DB
            }
        }
    }
}
