using QuizApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp2.Adapters.Interfaces
{
    public interface IQuestion
    {
        QuestionVM GetQuestion(int id);
        QuestionCountVM CountQuestions();
    }
}
