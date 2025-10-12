using BusinessLogicLayer.CreateMap;
using BusinessLogicLayer.DTO;
using DataAccessLayer;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class StudentQuizService
    {
        public static int Create(int StudentId, int QuizId)
        {
            StudentQuizDTO obj = new StudentQuizDTO();
            obj.StudentId = StudentId;
            obj.QuizId = QuizId;
            obj.StartTime = DateTime.Now;
            var squiz = CreateMap<StudentQuizDTO, StudentQuiz>.GetMap().Map<StudentQuiz>(obj);
            int id = DataAccessFactory.StudentQuizCommonFeature().Create(squiz);
            return id;
        }
        public static List<StudentQuizDTO> GetAll()
        {
            var squizzes = DataAccessFactory.StudentQuizCommonFeature().GetALL();
            var squzzes = CreateMap<StudentQuiz, StudentQuizDTO>.GetMap().Map<List<StudentQuizDTO>>(squizzes);
            return squzzes;
        }
        public static StudentQuizDTO Get(int id)
        {
            var squiz = DataAccessFactory.StudentQuizCommonFeature().Get(id);
            var sqz = CreateMap<StudentQuiz, StudentQuizDTO>.GetMap().Map<StudentQuizDTO>(squiz);
            return sqz;
        }
        public static float Update(int sqid, int Mark)
        {
            var squiz = CreateMap<StudentQuiz, StudentQuizDTO>.GetMap().Map<StudentQuizDTO>(DataAccessFactory.StudentQuizCommonFeature().Get(sqid));
            var quz = DataAccessFactory.QuizCommonFeature().Get(squiz.QuizId);
            if (quz.EndTime.TimeOfDay > DateTime.Now.TimeOfDay)
            {
                squiz.Mark = 0;
            }
            else
            {
                squiz.Mark = Mark;
            }
                squiz.EndTime = DateTime.Now;
            var qu = CreateMap<StudentQuiz, StudentQuizDTO>.GetMap().Map<StudentQuiz>(squiz);
            bool check = DataAccessFactory.StudentQuizCommonFeature().Update(qu);
            if (check)
            {
                return squiz.Mark.Value;
            }
            return -1;

        }
        public static List<StudentQuizDTO> GetByStudentId(int studentId)
        {
            var squizzes = DataAccessFactory.StudentQuizFeature().GetByStudentId(studentId);
            var squzzes = CreateMap<StudentQuiz, StudentQuizDTO>.GetMap().Map<List<StudentQuizDTO>>(squizzes);
            return squzzes;
        }
    }
}
