using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Service.Entities
{
    [Table("Rooms")]

    public class RoomsEntity
    {
        //חדרים: מספר חדר,שם חדר, רופא, קומה, יש חלון, 
        [Key]
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string DoctorName { get; set; }
        public bool Window { get; set; }
        public int RoomLevel { get; set; }

    }
}
