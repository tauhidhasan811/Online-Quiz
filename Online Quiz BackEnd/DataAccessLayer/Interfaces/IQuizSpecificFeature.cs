using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IQuizSpecificFeature
    {
        List<Quiz> GetByFacultyId(int fid);
        int SearchQuiz(string name);
        int SearchQuizFidTitle(int fid, string title);
    }
}
