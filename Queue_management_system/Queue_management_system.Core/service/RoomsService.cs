using Queue_management_system.Core.IRepository;

namespace Queue_management_system.service
{
    public class RoomsService
    {

        readonly IGenericRepository<RoomsService> _roomsRepository;
        public RoomsService(IGenericRepository<RoomsService> roomsRepository)
        {
            _roomsRepository = roomsRepository;
        }
        public RoomsService GetById(int id)
        {
            return _roomsRepository.GetById(id);
        }
        public IEnumerable<RoomsService> GetQueuesList()
        {
            return _roomsRepository.GetAllData();
        }

        public bool DeleteQueue(int id)
        {

            return _roomsRepository.DeleteData(id);
        }

        public bool PostQueue(RoomsService employee)
        {
            return _roomsRepository.AddData(employee);
        }


        public bool PutEmployee(int id, RoomsService employee)
        {
            return _roomsRepository.UpdateData(id, employee);
        }



    }
}
