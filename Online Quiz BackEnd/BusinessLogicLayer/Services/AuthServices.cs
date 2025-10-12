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
    public class AuthServices
    {
        public static TokenDTO Authorization(string username, string password)
        {
            var user = DataAccessFactory.AuthFeature().Authentication(username, password);
            if (user.Id > 0)
            {
                var token = new TokenDTO();
                token.CreatedAt = DateTime.Now;
                token.AccessToken = Guid.NewGuid().ToString();
                token.UserId = user.Id;
                token.Type =user.Type;
                var tk = CreateMap<TokenDTO, Token>.GetMap().Map<Token>(token);
                bool check = DataAccessFactory.AuthCommonFeature().Create(tk);
                if(check)
                {
                    var usr = CreateMap<UserDTO, User>.GetMap().Map<UserDTO>(DataAccessFactory.UserCommonFeature().Get(tk.UserId));
                    if(usr.Type=="Student")
                    {
                        token.UserId = usr.StudentId.Value;
                    }
                    else
                    {
                        token.UserId=usr.FacultyId.Value;
                    }
                        return token;
                }
                return new TokenDTO();
                
            }
            return new TokenDTO();
        }
        public static List<TokenDTO> GetAll()
        {
            var tokens = DataAccessFactory.AuthCommonFeature().GetALL();
            var tks = CreateMap<Token, TokenDTO>.GetMap().Map<List<TokenDTO>>(tokens);
            return tks;
        }
        public static string Delete(int id)
        {
            bool check = DataAccessFactory.AuthCommonFeature().Delete(id);
            if(check)
            {
                return "Deleted successfully";
            }
            return "Delete failed";
        }
        public static int ValidateToken(string accesstoken)
        {
            int id = DataAccessFactory.AuthFeature().ValidId(accesstoken);
            return id;
        }
        public static string Update(string accesstoken)
        {
            int id = ValidateToken(accesstoken);
            var token = DataAccessFactory.AuthCommonFeature().Get(id);
            token.DestroyedAt = DateTime.Now;
            bool check = DataAccessFactory.AuthCommonFeature().Update(token);
            if (check)
            {
                return "Successfully log out";
            }
            return "Failed to log out";
        }
        public static TokenDTO Get(int id)
        {
            var tk = DataAccessFactory.AuthCommonFeature().Get(id);
            var token = CreateMap<Token, TokenDTO>.GetMap().Map<TokenDTO>(tk);
            token.AccessToken = null;
            return token;
        }
        public static TokenDTO AlreadyLoggedIn(string accesstoken)
        {
            int id = DataAccessFactory.AuthFeature().ValidId(accesstoken);
            if (id > 0)
            { 
                var tk = DataAccessFactory.AuthCommonFeature().Get(id);
                var token = CreateMap<Token, TokenDTO>.GetMap().Map<TokenDTO>(tk);
                token.AccessToken = null;
                if (tk.UserId >0)
                {
                    var user = DataAccessFactory.UserCommonFeature().Get(tk.UserId);
                    user.UserName = null;
                    user.Password = null;
                    if (user.Type == "Student")
                    {
                        token.UserId = user.StudentId.Value;
                    }
                    else
                    {
                        token.UserId = user.FacultyId.Value;
                    }
                }
                return token;
            }
            return new TokenDTO();

        }

    }
}
