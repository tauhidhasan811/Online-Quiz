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
    public class UserService
    {
        public static bool Create(UserDTO user)
        {
            var usr = CreateMap<UserDTO, User>.GetMap().Map<User>(user);
            bool check = DataAccessFactory.UserCommonFeature().Create(usr);
            return check;
        }
        public static UserDTO Get(int id)
        {
            var usr = CreateMap<User, UserDTO>.GetMap().Map<UserDTO>(DataAccessFactory.UserCommonFeature().Get(id));
            return usr;
        }
    }
}
