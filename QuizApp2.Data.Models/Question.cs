using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp2.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public int AnswerId { get; set; }
        public virtual Answer Answer { get; set; }
    }
}
