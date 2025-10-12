using DataAccessLayer.Context;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    internal class OptionRepo : ICommonRepo<Option, bool>, IOptionRepo
    {
        QuizContext context = new QuizContext();
        public bool Create(Option obj)
        {
            context.Options.Add(obj);
            return context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Option Get(int id)
        {
            var option = context.Options.Find(id);
            return option;
        }

        public List<Option> GetALL()
        {
            var options = context.Options.ToList();
            return options;
        }

        public List<Option> GetByQuesId(int qid)
        {
            var options = context.Options.Where(o => o.QuestionId == qid).ToList();
            return options;
        }

        public bool IsCorrect(int id)
        {
            return context.Options.Find(id).IsCorrect;
        }

        public bool Update(Option obj)
        {
            context.Options.AddOrUpdate(obj);
            return context.SaveChanges() > 0;

        }
        
    }
}
