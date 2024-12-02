using Queue_management_system.Service.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Queue_management_system
{
    public class DataContext
    {
      
        public List<EmployeesEntity> employeesList { get; set; }
        public List<PatientsEntity> patientsList { get; set; }
        public List<QueuesEntity> queuesList { get; set; }
        public List<RoomsEntity> roomsList { get; set; }
        /*
        public DataContext()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "courier.json");
            string jsonString = File.ReadAllText(path);
            employeesList = JsonSerializer.Deserialize<List<EmployeesEntity>>(jsonString);// typeof(Employees) ;
        }
        public bool SaveData(List<EmployeesEntitys> data)
        {
            return true;
        }*/
        public void SaveChange()
        {

        }
        
    }
}
