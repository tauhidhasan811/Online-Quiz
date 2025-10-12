using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IAuthRepo
    {
        User Authentication(string username, string password);
        int ValidId(string accesstoken);

    }
}
