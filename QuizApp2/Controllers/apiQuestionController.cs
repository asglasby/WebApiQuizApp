using QuizApp2.Adapters.Adapters;
using QuizApp2.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizApp2.Controllers
{
    public class apiQuestionController : ApiController
    {
        private IQuestion _adapter;
        public apiQuestionController()
        {
            _adapter = new QuestionAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            if (id == -1)
            {
                return Ok(_adapter.CountQuestions());
            }
            else
            {
                return Ok(_adapter.GetQuestion(id));
            }
        }
    }
}
