using Queue_management_system.Core.IRepository;


namespace Queue_management_system.service
{
    public class QueuesService
    {

        readonly IGenericRepository<QueuesService> _queuesRepository;
        public QueuesService(IGenericRepository<QueuesService> queuesRepository)
        {
            _queuesRepository = queuesRepository;
        }
        public QueuesService GetById(int id)
        {
            return _queuesRepository.GetById(id);
        }
        public IEnumerable<QueuesService> GetQueuesList()
        {
            return _queuesRepository.GetAllData();
        }

        public bool DeleteQueue(int id)
        {

            return _queuesRepository.DeleteData(id);
        }

        public bool PostQueue(QueuesService employee)
        {
            return _queuesRepository.AddData(employee);
        }


        public bool PutEmployee(int id, QueuesService employee)
        {
            return _queuesRepository.UpdateData(id, employee);
        }



    }
}
