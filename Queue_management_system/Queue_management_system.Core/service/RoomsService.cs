using Queue_management_system.Entities;

namespace Queue_management_system.service
{
    public class RoomsService
    {
        public List<Rooms> GetRoomsList()
        {
            if (ManagerDataContext.d.roomsList == null)
            {
                return null;
            }
            return ManagerDataContext.d.roomsList;
        }
        public bool AddRoomsList(Rooms rooms)
        {
            if (ManagerDataContext.d.roomsList == null)
            {
                return false;
            }
            ManagerDataContext.d.roomsList.Add(rooms);
            return true;
        }

        public bool UpdateRoomsList(Rooms room, int roomid)
        {
            if (ManagerDataContext.d.roomsList == null)
            {
                return false;
            }

            Rooms r = ManagerDataContext.d.roomsList.Find(r => r.RoomId == roomid);
            r.RoomName = room.RoomName;
            r.DoctorName = room.DoctorName;
            r.Window = room.Window;
            r.RoomLevel = room.RoomLevel;
            return true;
            /*RoomName DoctorName Window RoomLevel  */
        }

        public bool DeleteRoomsList(int roomId)
        {

            if (ManagerDataContext.d.roomsList == null)
            {
                return false;
            }

            ManagerDataContext.d.roomsList.Remove(ManagerDataContext.d.roomsList.Find(r => r.RoomId == roomId));
            return true;
        }

    }
}
