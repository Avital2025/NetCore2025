using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Core.IRepository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAllData();
        T GetById(int id);
        bool AddData(T t);


        bool UpdateData(int id, T t);

        bool DeleteData(int id);

    }
}
