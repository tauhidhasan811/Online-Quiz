using DataAccessLayer.Context;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class AuthRepo: IAuthRepo, ICommonRepo<Token, bool>
    {
        QuizContext context = new QuizContext();
        public User Authentication(string username, string password)
        {
            var user = context.Users.Where(u => u.UserName == username && u.Password == password).FirstOrDefault();
            if(user != null)
            {
                
                user.Password = null;
                user.UserName = null;
                return user;
            }
            return new User();
        }
        public int ValidId(string accesstoken)
        {
            int id = (from t in context.Tokens where t.AccessToken == accesstoken 
                      && t.DestroyedAt == null select t.Id).FirstOrDefault();
            return id;
        }
        public bool Create(Token obj)
        {
            context.Tokens.Add(obj);
            return context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var auth = context.Tokens.Find(id);
            context.Tokens.Remove(auth);
            return context.SaveChanges() > 0;

        }

        public Token Get(int id)
        {
            var token = context.Tokens.Find(id);
            return token;
        }

        public List<Token> GetALL()
        {
            var tokens = context.Tokens.ToList();
            return tokens;
        }

        public bool Update(Token obj)
        {
            //var token = context.Tokens.Find(obj.Id);
            //token.DestroyedAt = obj.DestroyedAt;
            context.Tokens.AddOrUpdate(obj);
            return context.SaveChanges() > 0;
        }

        
    }
}
