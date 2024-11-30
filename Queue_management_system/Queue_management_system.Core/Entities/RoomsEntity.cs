using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Service.Entities
{
    public class RoomsEntity
    {
        //חדרים: מספר חדר,שם חדר, רופא, קומה, יש חלון, 
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string DoctorName { get; set; }
        public bool Window { get; set; }
        public int RoomLevel { get; set; }

    }
}
