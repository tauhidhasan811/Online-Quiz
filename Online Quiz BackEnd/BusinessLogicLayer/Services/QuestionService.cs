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
    public class QuestionService
    {
        public static int Create(QuestionDTO question)
        {
            var que = CreateMap<Question, QuestionDTO>.GetMap().Map<Question>(question);
            int id = DataAccessFactory.QuestionCommonFeature().Create(que);
            return id;
        }
        public static List<QuestionDTO> GetByQuizId(int quzId)
        {
            var quzs = DataAccessFactory.QuestionFeature().GetByQuiz(quzId);
            var quizzes = CreateMap<Question, QuestionDTO>.GetMap().Map<List<QuestionDTO>>(quzs);
            return quizzes;
        }
        public static QuestionDTO Get(int id)
        {
            var quz = CreateMap<QuestionDTO, Question>.GetMap().Map<QuestionDTO>( DataAccessFactory.QuestionCommonFeature().Get(id));
            return quz;
        }
        public static bool Update(QuestionDTO question)
        {
            var que = CreateMap<Question, QuestionDTO>.GetMap().Map<Question>(question);
            bool check = DataAccessFactory.QuestionCommonFeature().Update(que);
            return check;
        }
        public static bool Delete(int id)
        {
            var check = DataAccessFactory.CourseCommonFeature().Delete(id) ;
            return check;
        }

    }
}
