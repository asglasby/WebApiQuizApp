using QuizApp2.Adapters.Interfaces;
using QuizApp2.Data;
using QuizApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizApp2.Adapters.Adapters
{
    public class QuestionAdapter : IQuestion
    {
        public QuestionVM GetQuestion(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            QuestionVM question = db.Questions.Where(q => q.Id == id).Select(
                q => new QuestionVM
                {
                    Prompt = q.Prompt,
                    Answer1 = q.Answer.Answer1,
                    Answer2 = q.Answer.Answer2,
                    Answer3 = q.Answer.Answer3,
                    Answer4 = q.Answer.Answer4,
                    CorrectAnswer = q.Answer.CorrectAnswer
                }).FirstOrDefault();
            return question;
        }

        public QuestionCountVM CountQuestions()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            QuestionCountVM Count = new QuestionCountVM();
            Count.QuestionCount = db.Questions.Count();
            return Count;
        }
    }
}
