using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizApp2.Models
{
    public class QuestionVM
    {
        public string Prompt { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int CorrectAnswer { get; set; }

    }
}