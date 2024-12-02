using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Service.Entities
{
    public class EmployeesEntity
    {
        //(עובדים: שם, ת.ז., מייל, פלאפון, קוד עובד, סוג עובד(רופאה/מזכירה

        public string Name { get; set; }
        public string TZ { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int EemployeeId { get; set; }
        public string Type { get; set; }
    }
}
