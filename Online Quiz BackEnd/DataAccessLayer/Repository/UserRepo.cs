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
    internal class UserRepo : ICommonRepo<User, bool>
    {
        QuizContext context = new QuizContext();
        public bool Create(User obj)
        {
            context.Users.Add(obj);
            return context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var user = context.Users.Find(id);
            if(user != null)
            {
                context.Users.Remove(user);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public User Get(int id)
        {
            var user = context.Users.Find(id);
            return user;
        }

        
        public List<User> GetALL()
        {
            var users = context.Users.ToList(); 
            return users;
        }
        

        public bool Update(User obj)
        {
            /*var user = context.Users.Find(obj.Id);
            user.UserName = obj.UserName;
            user.Password = obj.Password;
            context.Users.AddOrUpdate(user);
            */
            context.Users.AddOrUpdate(obj);
            return context.SaveChanges() > 0;
        }
    }
}
