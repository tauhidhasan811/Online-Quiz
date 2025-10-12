using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IOptionRepo
    {
        List<Option> GetByQuesId(int qid);
        bool IsCorrect(int id);
    }
}
