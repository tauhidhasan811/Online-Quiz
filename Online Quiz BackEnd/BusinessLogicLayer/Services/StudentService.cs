using AutoMapper;
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
    public class StudentService
    {
        /*public static Mapper GetMap()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>().ReverseMap();
            });
            return new Mapper(config);
        }*/
        public static string Create(StudentDTO student)
        {
            //var stud = GetMap().Map<Student>(student);
            /*
            try
            {
                var stud = CreateMap<Student, StudentDTO>.GetMap().Map<Student>(student);

                bool check = DataAccessFactory.StudentCommonFeature().Create(stud);
                if (check)
                {
                    return "Student Added Successfully";
                }
                return "Failed to Added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }*/
            var stud = CreateMap<Student, StudentDTO>.GetMap().Map<Student>(student);

            bool check = DataAccessFactory.StudentCommonFeature().Create(stud);
            if (check)
            {
                return "Student Added Successfully";
            }
            return "Failed to Added";
        }
        public static string Update(StudentDTO student)
        {
            try
            {
                var stud = CreateMap<Student, string>.GetMap().Map<Student>(student);
                bool check = DataAccessFactory.StudentCommonFeature().Update(stud);
                if (check)
                {
                    return "Updated successfully";
                }
                return "Failed to update";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
        public static string Delete(int id)
        {
            try
            {
                var check = DataAccessFactory.StudentCommonFeature().Delete(id);
                if (check)
                {
                    return "Student Deleted successfully";
                }
                return "Failed to delete";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        public static StudentDTO Get(int id)
        {
            var student = DataAccessFactory.StudentCommonFeature().Get(id);
            var stud = CreateMap<Student, StudentDTO>.GetMap().Map<StudentDTO>(student);
            if (stud != null) 
            {
                return stud;
            }
            return new StudentDTO();

        }
        public static List<StudentDTO> GetAllStudent()
        {
            var students = DataAccessFactory.StudentCommonFeature().GetALL();
            //var stud = GetMap().Map<List<StudentDTO>>(students);
            var stud = CreateMap<Student, StudentDTO>.GetMap().Map<List<StudentDTO>>(students);
            if(stud != null)
            {
                return stud;
            }
            return new List<StudentDTO>();
        }
    }
}
