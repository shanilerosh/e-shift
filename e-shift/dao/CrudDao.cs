using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao
{
    internal interface CrudDao<T, ID>
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(ID id);
        DataTable GetAll();


    }
}
