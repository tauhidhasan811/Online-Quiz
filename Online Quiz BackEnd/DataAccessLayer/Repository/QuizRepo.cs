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
    public class QuizRepo : ICommonRepo<Quiz, int>, IQuizSpecificFeature
    {
        QuizContext context = new QuizContext();
        public int Create(Quiz obj)
        {
            context.Quizzes.Add(obj);
            
            if(context.SaveChanges() > 0)
            {
                return obj.Id;
            }
            return -1;
        }

        public bool Delete(int id)
        {
            var quz = context.Quizzes.Find(id);
            context.Quizzes.Remove(quz);
            return context.SaveChanges() > 0;
        }

        public Quiz Get(int id)
        {
            var quiz = context.Quizzes.Find(id);
            //quiz.Questions = context.Questions.Where(q => q.QuizId == id).ToList();
            quiz.studentquiz = context.StudentQuizzes.Where(sq => sq.QuizId == id).ToList();
            return quiz;
        }

        public List<Quiz> GetALL()
        {
            var quizzes = context.Quizzes.ToList();
            return quizzes;
        }

        public List<Quiz> GetByFacultyId(int fid)
        {
            var quizzes = context.Quizzes.Where(q => q.FacultyId == fid).ToList();
            return quizzes;
        }

        public int SearchQuiz(string name)
        {
            int id = (from q in context.Quizzes
                      where q.Title == name
                      select q.Id).FirstOrDefault();
            if(id > 0)
            {
                return id;
            }
            return -1;
        }

        public int SearchQuizFidTitle(int fid, string title)
        {
            int id = (from q in context.Quizzes where q.Title == title &&  q.FacultyId == fid select q.Id).FirstOrDefault();
            if (id > 0)
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        public bool Update(Quiz obj)
        {
            /*
            var quz = Get(obj.Id);
            //quz.Equals(obj);
            quz.Title = obj.Title;
            quz.Course = obj.Course;
            quz.Date = obj.Date;
            quz.Duration = obj.Duration;
            quz.StartTime = obj.StartTime;
            quz.EndTime = obj.EndTime;
            context.Quizzes.AddOrUpdate(quz);
            */
            context.Quizzes.AddOrUpdate(obj);
            return context.SaveChanges() > 0;

        }
    }
}
