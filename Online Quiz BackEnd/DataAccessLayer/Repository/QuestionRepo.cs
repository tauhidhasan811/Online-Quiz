using DataAccessLayer.Context;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataAccessLayer.Repository
{
    internal class QuestionRepo : ICommonRepo<Question, int>, IQuestionRepo
    {
        QuizContext context = new QuizContext();
        public int Create(Question questions)
        {
            context.Questions.Add(questions);
            if (context.SaveChanges() > 0)
            {
                return questions.Id;
            }
            return -1;
        }


        public bool Delete(int id)
        {
            var question = context.Questions.Find(id);
            context.Questions.AddOrUpdate(question);
            return context.SaveChanges() > 0;
        }

        public Question Get(int id)
        {
            var question = context.Questions.Find(id);
            return question;
        }

        public List<Question> GetALL()
        {
            throw new NotImplementedException();
        }
        public List<Question> GetByQuiz(int quizId)
        {
            var questions = context.Questions.Where(q => q.QuizId == quizId).ToList();
            return questions;
        }

        public bool Update(Question question)
        {
            /*var que = context.Questions.Find(question.Id);
            que.Title = question.Title;
            que.Option1 = question.Option1;
            que.Option2 = question.Option2;
            que.Option3 = question.Option3;
            que.Option4 = question.Option4;
            context.Questions.AddOrUpdate(que);*/
            context.Questions.AddOrUpdate(question);
            return context.SaveChanges() > 0;
        }
    }
}
