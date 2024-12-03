using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Service.Entities;

namespace Queue_management_system.service
{
    public class QueuesService:IQueuesService
    {

        readonly IGenericRepository<QueuesEntity> _queuesRepository;
        public QueuesService(IGenericRepository<QueuesEntity> queuesRepository)
        {
            _queuesRepository = queuesRepository;
        }
        public QueuesEntity GetById(int id)
        {
            return _queuesRepository.GetById(id);
        }
        public IEnumerable<QueuesEntity> GetQueuesList()
        {
            return _queuesRepository.GetAllData();
        }

        public bool DeleteQueue(int id)
        {

            return _queuesRepository.DeleteData(id);
        }

        public bool PostQueue(QueuesEntity queue)
        {
            return _queuesRepository.AddData(queue);
        }


        public bool PutQueue(int id, QueuesEntity queue)
        {
            return _queuesRepository.UpdateData(id, queue);
        }

     
    }
}
