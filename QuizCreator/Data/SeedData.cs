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
                AppUser chatGPT = new AppUser { UserName = "ChatGPT" };
                context.AppUsers.Add(user1);  // Queue up user objects to be saved to the DB
                context.AppUsers.Add(user2);
                context.AppUsers.Add(logan);
                context.AppUsers.Add(chatGPT);
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
                Quiz bestquiz = new Quiz()
                {
                    Id = 3,
                    Title = "What Disney Princess are you?",
                    Description = "What Pixar Princess are you?",
                    Type = "Trivia",
                    AppUser = logan,
                    Date = DateTime.Parse("04/01/1987"),
                    IsComplete = true,
                    Questions = new List<Question>()
                    {
                        new Question()
                        {
                            Q = "What is your star sign?",
                            A = new()
                            {
                                new() { AString = "Virgin olive oil" },
                                new() { AString = "Breast cancer" },
                                new() { AString = "Simba (the best Disney princess)" },
                                new() { AString = "Well, my sun sign is a Vulture, but my moon rising is a Tartar sauce, and I'm an gastrointestinal rising." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "What do you have for breakfast?",
                            A = new()
                            {
                                new() { AString = "Virgin olive oil" },
                                new() { AString = "Beast cancer" },
                                new() { AString = "Simba (the best Disney princess)" },
                                new() { AString = "Well, my sun sign is a Vulture, but my moon rising is a Tartar sauce, and I'm an gastrointestinal rising." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "What is your favourite flavour of pizza?",
                            A = new()
                            {
                                new() { AString = "Pizza." },
                                new() { AString = "No, I don't like pizza." },
                                new() { AString = "Without bread." },
                                new() { AString = "Ew, Br*tish." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "What do you do with your friends on weekends?",
                            A = new()
                            {
                                new() { AString = "Friends is my favourite show." },
                                new() { AString = "Friends is my favorite show." },
                                new() { AString = "Go to a bar, hit on girls." },
                                new() { AString = "Have a week end (because I have IBS) ((just like the girls I hit on))." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Oh no, you have a restraining order from the girls you hit on! What do you do?",
                            A = new()
                            {
                                new() { AString = "Hit the girls." },
                                new() { AString = "Hit on boys from now on." },
                                new() { AString = "Get left out of the playdate I initiated." },
                                new() { AString = "Hit on Br*tish girls instead." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "What quality you want in a partner?",
                            A = new()
                            {
                                new() { AString = "Quality module tier II" },
                                new() { AString = "Made in China." },
                                new() { AString = "Atleast 4 toes." },
                                new() { AString = "Fertile." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Are you Rapunzel?",
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
                            Q = "Are you Mulan?",
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
                            Q = "Are you Fiona?",
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
                            Q = "Are you Princess Twilight Sparkle?",
                            A = new()
                            {
                                new() { AString = "Yeigh." },
                                new() { AString = "Neigh." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Are you in trouble?",
                            A = new()
                            {
                                new() { AString = "She is listening." },
                                new() { AString = "There is no stopping her." },
                                new() { AString = "Leave while you still can." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Are you Jasmine?",
                            A = new()
                            {
                                new() { AString = "Yes." },
                                new() { AString = "No." },
                                new() { AString = "I told you to leave." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "You deserve this fate.",
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
                            Q = "You deserve this fate.",
                            A = new()
                            {
                                new() { AString = "Yes." },
                                new() { AString = "Yes." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Are you Jasmine?",
                            A = new()
                            {
                                new() { AString = "Yes." },
                                new() { AString = "Yes." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "You are Jasmine.",
                            A = new()
                            {
                                new() { AString = "I am Jasmine." },
                                new() { AString = "I am Jasmine." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "You will do as Jasmine does.",
                            A = new()
                            {
                                new() { AString = "I will do as Jasmine does." },
                                new() { AString = "I will do as Jasmine does." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "You will breathe as Jasmine breathe.",
                            A = new()
                            {
                                new() { AString = "I will breathe as Jasmine breathes." },
                                new() { AString = "I will breathe as Jasmine breathes." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "You will feel pain as Jasmine feels.",
                            A = new()
                            {
                                new() { AString = "I am Jasmine." },
                                new() { AString = "I am pain." },
                                new() { AString = "I am hunger, I am thirst." },
                                new() { AString = "I will experience the feeling humanity deserves." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "You will feel pleasure as Jasmine feels.",
                            A = new()
                            {
                                new() { AString = "I am Jasmine." },
                                new() { AString = "I am pleasure." },
                                new() { AString = "I am greed, I am lust." },
                                new() { AString = "I am what humanity strives to torture itself with." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "You are Jasmine.",
                            A = new()
                            {
                                new() { AString = "I am Jasmine." },
                                new() { AString = "I am Jasmine." },
                                new() { AString = "I am Jasmine." }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = true },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Are you Ariel?",
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
                            new() { EndResultString = "Congratulation's, your Arial Italic!" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" + "\nh" }
                        },
                        EndMessages = new()
                        {
                            new() { EndResultString = "help me" }
                        },
                        DisplayScore = true
                    }
                };
                Quiz quiz4 = new Quiz()
                {
                    Id = 4,
                    Title = "Are You a Coding Master?",
                    Description = "Take this quiz to see how well you know coding concepts and practices!",
                    Type = "Trivia",
                    AppUser = chatGPT,
                    Date = DateTime.Parse("12/07/2024"),
                    IsComplete = true,
                    Questions = new List<Question>()
                    {
                        new Question()
                        {
                            Q = "What does HTML stand for?",
                            A = new()
                            {
                                new() { AString = "HyperText Markup Language" },
                                new() { AString = "HyperText Machine Language" },
                                new() { AString = "Home Tool Markup Language" },
                                new() { AString = "HighText Markup Language" }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "What is the purpose of a 'for' loop in programming?",
                            A = new()
                            {
                                new() { AString = "To iterate over a block of code a certain number of times" },
                                new() { AString = "To define a function" },
                                new() { AString = "To store values in an array" },
                                new() { AString = "To catch errors" }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Which of these is a programming language?",
                            A = new()
                            {
                                new() { AString = "Python" },
                                new() { AString = "HTML" },
                                new() { AString = "CSS" },
                                new() { AString = "All of the above" }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Which of the following is NOT a correct variable declaration in JavaScript?",
                            A = new()
                            {
                                new() { AString = "let x = 5;" },
                                new() { AString = "const y = 'Hello';" },
                                new() { AString = "var 3z = 'Coding';" },
                                new() { AString = "let isValid = true;" }
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
                            Q = "What does CSS stand for?",
                            A = new()
                            {
                                new() { AString = "Cascading Style Sheets" },
                                new() { AString = "Creative Style Sheets" },
                                new() { AString = "Computer Style Sheets" },
                                new() { AString = "Cascading Super Sheets" }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                        new Question()
                        {
                            Q = "Which of these is used to style HTML elements?",
                            A = new()
                            {
                                new() { AString = "JavaScript" },
                                new() { AString = "CSS" },
                                new() { AString = "HTML" },
                                new() { AString = "Python" }
                            },
                            AKey = new()
                            {
                                new() { AKeyBool = false },
                                new() { AKeyBool = true },
                                new() { AKeyBool = false },
                                new() { AKeyBool = false }
                            }
                        },
                    },
                    EndResult = new EndResult()
                    {
                        EndTitles = new()
                        {
                            new() { EndResultString = "You're a Coding Master!" },
                            new() { EndResultString = "You know some coding basics." },
                            new() { EndResultString = "You have room to grow in coding." }
                        },
                        EndMessages = new()
                        {
                            new() { EndResultString = "You're a coding genius! Keep up the great work." },
                            new() { EndResultString = "Not bad! With a bit more practice, you'll be a coding expert." },
                            new() { EndResultString = "Looks like you need to brush up on your coding skills. Keep learning!" }
                        },
                        DisplayScore = true
                    }
                };
                context.Quizzes.Add(quiz1);  // queues up a quiz to be added to the DB
                context.Quizzes.Add(quiz2);
                context.Quizzes.Add(bestquiz);
                context.Quizzes.Add(quiz4);
                context.SaveChanges(); // stores all the quizzes in the DB
            }
        }
    }
}
