using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Data.Repository
{
    public class Queue_management_systemRepository
    {
        readonly DataContext _datacontext;
        public Queue_management_systemRepository(DataContext datacontext)
        {

            _datacontext = datacontext;

        }
    }
}
