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
    internal class CourseRepo : ICommonRepo<Course, bool>
    {
        QuizContext context = new QuizContext();
        public bool Create(Course obj)
        {
            context.Courses.Add(obj);
            return context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var course = context.Courses.Find(id);
            context.Courses.Remove(course);
            return context.SaveChanges() > 0;
        }

        public Course Get(int id)
        {
            var course = context.Courses.Find(id);
            return course;
        }

        public List<Course> GetALL()
        {
            var course = context.Courses.ToList();
            return course;
        }

        public bool Update(Course obj)
        {
            /*var course = context.Courses.Find(obj.Id);
            course.Name = obj.Name;
            course.CourseCode = obj.CourseCode;
            context.Courses.AddOrUpdate(course);*/
            context.Courses.AddOrUpdate(obj);
            return context.SaveChanges() > 0;
        }
    }
}
