using DataAccessLayer.Interfaces;
using DataAccessLayer.Repository;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static ICommonRepo<Student,bool> StudentCommonFeature()
        {
            return new StudentRepo();
        }
        public static ICommonRepo<Quiz,int> QuizCommonFeature()
        {
            return new QuizRepo();
        }
        public static ICommonRepo<Faculty, bool> FacultyCommonFeature()
        {
            return new FacultyRepo();
        }
        public static ICommonRepo<Course, bool> CourseCommonFeature()
        {
            return new CourseRepo();
        }
        public static IAuthRepo AuthFeature()
        {
            return new AuthRepo();
        }
        public static ICommonRepo<Token, bool> AuthCommonFeature()
        {
            return new AuthRepo();
        }
        public static ICommonRepo<Question, int> QuestionCommonFeature()
        {
            return new QuestionRepo();
        }
        public static IQuestionRepo QuestionFeature()
        {
            return new QuestionRepo();
        }
        public static ICommonRepo<User, bool> UserCommonFeature()
        {
            return new UserRepo();
        }
        public static ICommonRepo<Option, bool> OptionCommonFeature()
        {
            return new OptionRepo();
        }
        public static IOptionRepo OptionRepoFeature()
        {
            return new OptionRepo();
        }
        public static ICommonRepo<StudentQuiz, int> StudentQuizCommonFeature()
        {
            return new StudentQuizRepo();
        }
        public static IQuizSpecificFeature QuizRepoFeature()
        {
            return new QuizRepo();
        }
        public static IStudentQuizRepo StudentQuizFeature()
        {
            return new StudentQuizRepo();
        }

    }
}
