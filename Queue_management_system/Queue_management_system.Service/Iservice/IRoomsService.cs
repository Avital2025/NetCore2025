using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Core.Iservice
{
    public interface IRoomsService
    {
        IEnumerable<RoomsEntity> GetRoomsList();

        RoomsEntity GetById(int id);

        bool PostRoom(RoomsEntity employee);
        bool PutRoom(int id, RoomsEntity employee);
        bool DeleteRoom(int id);
    }
}
