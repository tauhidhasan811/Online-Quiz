using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ICommonRepo<CLASS, Type >
    {
        Type Create(CLASS obj);
        bool Update(CLASS obj);
        bool Delete(int id);
        CLASS Get(int id);
        List<CLASS> GetALL();

    }
}
