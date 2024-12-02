using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Service.Entities
{
    public class PatientsEntity
    {

        //לקוח: שם, ת.ז. גיל, פלאפון, מייל, טלפון נוסף, סוג ביטוח

        public string Name { get; set; }
        public int patientTZ { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string AnotherPhone { get; set; }
        public string Mail { get; set; }
        public string Insurance { get; set; }
    }
}
