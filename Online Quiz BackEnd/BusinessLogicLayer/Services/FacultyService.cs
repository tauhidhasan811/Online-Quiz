using BusinessLogicLayer.DTO;
using BusinessLogicLayer.CreateMap;
using DataAccessLayer;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class FacultyService
    {
        public static string Create(FacultyDTO faculty)
        {
            var fac = CreateMap<Faculty, FacultyDTO>.GetMap().Map<Faculty>(faculty);
            var check = DataAccessFactory.FacultyCommonFeature().Create(fac);
            if(check)
            {
                return "Faculty added successfully";
            }
            return "Failed to add";
        }
        public static string Delete(int id)
        {
            bool check = DataAccessFactory.FacultyCommonFeature().Delete(id);
            if(check)
            {
                return "Faculty Deleted successfully";
            }
            return "Failed to delete";
        }
        public static FacultyDTO Get(int id)
        {
            var faculty = DataAccessFactory.FacultyCommonFeature().Get(id);
            var fac = CreateMap<Faculty, FacultyDTO>.GetMap().Map<FacultyDTO>(faculty);
            return fac;
        }
        public static List<FacultyDTO> GetAll()
        {
            var faculties = DataAccessFactory.FacultyCommonFeature().GetALL();
            var facts = CreateMap<Faculty, FacultyDTO>.GetMap().Map<List<FacultyDTO>>(faculties);
            return facts;
        }
        public static string Update(FacultyDTO faculty)
        {
            var fac = CreateMap<Faculty, FacultyDTO>.GetMap().Map<Faculty>(faculty);
            bool check = DataAccessFactory.FacultyCommonFeature().Update(fac);
            if(check)

            {
                return "Faculty Updated Successfully";
            }
            return "Failed to Update";
        }
    }
}
