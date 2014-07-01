namespace QuizApp2.Data.Migrations
{
    using QuizApp2.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuizApp2.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuizApp2.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Answers.AddOrUpdate(
                q => q.Id,
                new Answer { Id = 1, Answer1 = "Mewtwo", Answer2 = "Mew", Answer3 = "Charmander", Answer4 = "Snorlax", CorrectAnswer = 1},
                new Answer { Id = 2, Answer1 = "AppAcademy", Answer2 = "CoderCamps", Answer3 = "DivBootcamp", Answer4 = "IronYard", CorrectAnswer = 2},
                new Answer { Id = 3, Answer1 = "Sleeping", Answer2 = "Alien Abduction", Answer3 = "Helping friend", Answer4 = "On his way to Haiti", CorrectAnswer = 4},
                new Answer { Id = 4, Answer1 = "Alaska", Answer2 = "Colorado", Answer3 = "Virginia", Answer4 = "Hawaii", CorrectAnswer = 4},
                new Answer { Id = 5, Answer1 = "Juniper", Answer2 = "Uranius", Answer3 = "Neptune", Answer4 = "Saturn", CorrectAnswer = 1}
                );
            context.SaveChanges();
            context.Questions.AddOrUpdate(
                q => q.AnswerId,
                new Question {Prompt = "Who is the 150th Pokemon?", AnswerId = 1 },
                new Question {Prompt = "What camp is this?", AnswerId = 2 },
                new Question {Prompt = "Where is Josh?", AnswerId = 3 },
                new Question {Prompt = "What is the 50th State?", AnswerId = 4 },
                new Question {Prompt = "What gas giant is the closest to the Sun?", AnswerId = 5 }
                );
            context.SaveChanges();
        }
    }
}
