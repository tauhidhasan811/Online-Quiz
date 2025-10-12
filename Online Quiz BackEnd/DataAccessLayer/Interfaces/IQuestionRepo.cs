using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IQuestionRepo
    {
        List<Question> GetByQuiz(int quizId);
    }
}
