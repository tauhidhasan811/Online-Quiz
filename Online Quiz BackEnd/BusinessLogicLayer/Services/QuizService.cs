using BusinessLogicLayer.CreateMap;
using BusinessLogicLayer.DTO;
using DataAccessLayer;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class QuizService
    {
        public static int Create(QuizDTO quiz)
        {

            DateTime endtime = quiz.StartTime.AddMinutes(quiz.Duration);
            quiz.EndTime = endtime;
            var quz = CreateMap<Quiz, QuizDTO>.GetMap().Map<Quiz>(quiz);
            int id = DataAccessFactory.QuizCommonFeature().Create(quz);
            return id;
        }
        public static List<QuizDTO> GetAll()
        {
            var quizzes = DataAccessFactory.QuizCommonFeature().GetALL();
            var quzzes = CreateMap<Quiz, QuizDTO>.GetMap().Map<List<QuizDTO>>(quizzes);
            return quzzes;
        }
        public static QuizDTO Get(int id)
        {
            var quiz = DataAccessFactory.QuizCommonFeature().Get(id);
            var quz = CreateMap<Quiz, QuizDTO, StudentQuiz, StudentQuizDTO>.GetMap().Map<QuizDTO>(quiz);
            quz.Count = quz.studentquiz.Count();
            return quz;
        }
        public static List<QuizDTO> GetByFacultyId(int fid)
        {
            var quzs = DataAccessFactory.QuizRepoFeature().GetByFacultyId(fid);
            var quizzes = CreateMap<Quiz, QuizDTO>.GetMap().Map<List<QuizDTO>>(quzs);
            return quizzes;
        }
        public static string Delete(int id)
        {
            bool check = DataAccessFactory.QuizCommonFeature().Delete(id);
            if(check)
            {
                return "Deleted successfully";
            }
            return "Failed to delete";
        }
        public static QuizDTO SearchQuiz(string title)
        {
            var id = DataAccessFactory.QuizRepoFeature().SearchQuiz(title);
            if (id == -1)
            {
                return new QuizDTO();
            }
            else
            {
                var quiz = DataAccessFactory.QuizCommonFeature().Get(id);
                var quz = CreateMap<Quiz, QuizDTO, StudentQuiz, StudentQuizDTO>.GetMap().Map<QuizDTO>(quiz);
                quz.Count = quz.studentquiz.Count();
                return quz;
            }
        }
        public static QuizDTO SearchQuizFidTitle(int fid, string title)
        {
            var id = DataAccessFactory.QuizRepoFeature().SearchQuizFidTitle(fid, title);
            if (id == -1)
            {
                return new QuizDTO();
            }
            else
            {
                var quiz = DataAccessFactory.QuizCommonFeature().Get(id);
                var quz = CreateMap<Quiz, QuizDTO, StudentQuiz, StudentQuizDTO>.GetMap().Map<QuizDTO>(quiz);
                quz.Count = quz.studentquiz.Count();
                return quz;
            }
        }
    }
}
