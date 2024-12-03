using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Service.Entities;

namespace Queue_management_system.service
{
    public class RoomsService:IRoomsService
    {

        readonly IGenericRepository<RoomsEntity> _roomsRepository;
        public RoomsService(IGenericRepository<RoomsEntity> roomsRepository)
        {
            _roomsRepository = roomsRepository;
        }
        public RoomsEntity GetById(int id)
        {
            return _roomsRepository.GetById(id);
        }
        public IEnumerable<RoomsEntity> GetRoomsList()
        {
            return _roomsRepository.GetAllData();
        }

        public bool DeleteRoom(int id)
        {

            return _roomsRepository.DeleteData(id);
        }

        public bool PostRoom(RoomsEntity room)
        {
            return _roomsRepository.AddData(room);
        }


        public bool PutRoom(int id, RoomsEntity room)
        {
            return _roomsRepository.UpdateData(id, room);
        }



    }
}
