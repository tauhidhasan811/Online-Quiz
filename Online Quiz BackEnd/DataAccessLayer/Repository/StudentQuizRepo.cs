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
    internal class StudentQuizRepo : ICommonRepo<StudentQuiz, int>, IStudentQuizRepo
    {
        QuizContext context = new QuizContext();
        public int Create(StudentQuiz obj)
        {
            context.StudentQuizzes.Add(obj);
            if (context.SaveChanges() > 0)
            {
                return obj.Id;
            }
            return -1;
        }

        public bool Delete(int id)
        {
            var studentQuiz = context.StudentQuizzes.Find(id);  
            context.StudentQuizzes.Remove(studentQuiz);
            return context.SaveChanges() > 0;
        }

        public StudentQuiz Get(int id)
        {
            var studentQuiz = context.StudentQuizzes.Find(id);
            return studentQuiz;
        }

        public List<StudentQuiz> GetALL()
        {
            var studentQuizzes = context.StudentQuizzes.ToList();
            return studentQuizzes;
        }

        public List<StudentQuiz> GetByStudentId(int studentId)
        {
            var studentQuizzes = context.StudentQuizzes.Where(sq => sq.StudentId == studentId).ToList();
            return studentQuizzes;
        }

        public bool Update(StudentQuiz obj)
        {
            context.StudentQuizzes.AddOrUpdate(obj);
            return context.SaveChanges() > 0;
        }
    }
}
