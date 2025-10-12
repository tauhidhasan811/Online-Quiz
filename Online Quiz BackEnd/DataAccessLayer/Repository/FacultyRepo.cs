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
    internal class FacultyRepo : ICommonRepo<Faculty, bool>
    {
        QuizContext context = new QuizContext();
  
        public bool Create(Faculty obj)
        {
            context.Faculties.Add(obj);
            if(context.SaveChanges() > 0)
            {
                var user = new User();
                user.UserName = obj.UserName;
                user.Type = "Faculty";
                user.Password = obj.Password;
                user.FacultyId = obj.Id;
                bool check = DataAccessFactory.UserCommonFeature().Create(user);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var faculty = context.Faculties.Find(id);
            context.Faculties.Remove(faculty);
            return context.SaveChanges() > 0;
        }

        public Faculty Get(int id)
        {
            var faculty = context.Faculties.Find(id);
            return faculty;
        }
        public List<Faculty> GetALL()
        {
            var faculties = context.Faculties.ToList();
            return faculties;
        }
        

        public bool Update(Faculty obj)
        {
            var fac = context.Faculties.Find(obj.Id);
            var user = context.Users.Where(f => f.FacultyId == obj.Id).FirstOrDefault();
            fac.Name = obj.Name;
            fac.UserName = obj.UserName;
            fac.Password = obj.Password;
            fac.Email = obj.Email;
            context.Faculties.AddOrUpdate(fac);
            if(context.SaveChanges() > 0)
            {
                //user.UserName = obj.UserName;
                //user.Password = obj.Password;
                bool check = DataAccessFactory.UserCommonFeature().Update(user);
                return context.SaveChanges() > 0;
            }
            return false;
        }
    }
}
