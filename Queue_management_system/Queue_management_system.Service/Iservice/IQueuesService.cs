using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Core.Iservice
{
    public interface IQueuesService
    {
        IEnumerable<QueuesEntity> GetQueuesList();

        QueuesEntity GetById(int id);

        bool PostQueue(QueuesEntity queue);
        bool PutQueue(int id, QueuesEntity queue);
        bool DeleteQueue(int id);
    }
}
