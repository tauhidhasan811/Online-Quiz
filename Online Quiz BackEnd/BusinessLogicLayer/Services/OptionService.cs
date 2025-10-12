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
    public class OptionService
    {
        public static bool Create(OptionDTO option)
        {
            bool check = DataAccessFactory.OptionCommonFeature().Create(CreateMap<OptionDTO, Option>.GetMap().Map<Option>(option));
            return check;
        }

        public static List<OptionDTO> GetALL()
        {
            var options = DataAccessFactory.OptionCommonFeature().GetALL();
            var opts = CreateMap<Option, OptionDTO>.GetMap().Map<List<OptionDTO>>(options);
            return opts;
        }
        public static List<OptionDTO> GetByQuesId(int qid)
        {
            var options = DataAccessFactory.OptionRepoFeature().GetByQuesId(qid);
            var opts = CreateMap<Option, OptionDTO>.GetMap().Map<List<OptionDTO>>(options);
            return opts;
        }
        public static int Iscorrect(List<int> ids)
        {
            int correctCount = 0;
            foreach(int id in ids)
            {
                if (DataAccessFactory.OptionRepoFeature().IsCorrect(id))
                {
                    correctCount++;
                }
            }
            return correctCount;
        }
        public static bool Update(OptionDTO option)
        {
            bool check = DataAccessFactory.OptionCommonFeature().Update(CreateMap<OptionDTO, Option>.GetMap().Map<Option>(option));
            return check;
        }
        public static OptionDTO Get(int id)
        {
            var option = DataAccessFactory.OptionCommonFeature().Get(id);
            var opt = CreateMap<OptionDTO, Option>.GetMap().Map<OptionDTO>(option);
            return opt;
        }
        public static bool Delete(int id)
        {
            bool check = DataAccessFactory.OptionCommonFeature().Delete(id);
            return check;
        }
    }
}
