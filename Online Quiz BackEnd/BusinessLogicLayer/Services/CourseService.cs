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
    public class CourseService
    {
        public static string Create(CourseDTO Course)
        {
            var fac = CreateMap<Course, CourseDTO>.GetMap().Map<Course>(Course);
            var check = DataAccessFactory.CourseCommonFeature().Create(fac);
            if (check)
            {
                return "Course added successfully";
            }
            return "Failed to add";
        }
        public static string Delete(int id)
        {
            bool check = DataAccessFactory.CourseCommonFeature().Delete(id);
            if (check)
            {
                return "Course Deleted successfully";
            }
            return "Failed to delete";
        }
        public static CourseDTO Get(int id)
        {
            var Course = DataAccessFactory.CourseCommonFeature().Get(id);
            var fac = CreateMap<Course, CourseDTO>.GetMap().Map<CourseDTO>(Course);
            return fac;
        }
        public static List<CourseDTO> GetAll()
        {
            var faculties = DataAccessFactory.CourseCommonFeature().GetALL();
            var facts = CreateMap<Course, CourseDTO>.GetMap().Map<List<CourseDTO>>(faculties);
            return facts;
        }
        public static string Update(CourseDTO Course)
        {
            var fac = CreateMap<Course, CourseDTO>.GetMap().Map<Course>(Course);
            bool check = DataAccessFactory.CourseCommonFeature().Update(fac);
            if (check)

            {
                return "Course Updated Successfully";
            }
            return "Failed to Update";
        }
    }
}

