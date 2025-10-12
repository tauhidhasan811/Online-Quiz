using DataAccessLayer.Context;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class StudentRepo : ICommonRepo<Student, bool>
    {
        QuizContext context = new QuizContext();
        public bool Create(Student obj)
        {
            var user = new User();
            context.Students.Add(obj);
            if(context.SaveChanges()>0)
            {
                user.UserName = obj.UserName;
                user.Password = obj.Password;
                user.StudentId = obj.Id;
                user.Type = "Student";
                context.Users.Add(user);
                return context.SaveChanges()> 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var student = context.Students.Find(id);
            if(student != null)
            {
                context.Students.Remove(student);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Student Get(int id)
        {
            var student =context.Students.Find(id);
            return student;
        }

        public List<Student> GetALL()
        {
            var students = context.Students.ToList();
            return students;
        }

        public bool Update(Student obj)
        {
            var student = context.Students.Find(obj.Id);
            var user = context.Users.Where(u => u.StudentId == student.Id).FirstOrDefault();
            student.Name=obj.Name;
            student.Email=obj.Email;
            student.Password=obj.Password;
            student.UserName=obj.UserName;
            user.UserName=obj.UserName;
            user.Password = obj.Password;
            return context.SaveChanges() > 0;
        }
    }
}
