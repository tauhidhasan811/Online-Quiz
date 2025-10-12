using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class QuizContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentQuiz> StudentQuizzes { get;set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
    }
}
