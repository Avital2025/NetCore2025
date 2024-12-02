using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Core.IRepository
{
    public interface IEmployeesRepository
    {
        List<EmployeesEntity> GetAllData();
        bool AddEmployeesList(EmployeesEntity employee);
        public EmployeesEntity GetById(int id);
        public bool AddEmployee(EmployeesEntity employee);
        public bool DeleteEmployee(int id);
        public bool UpdateEmpliyee(int id);

    }




}




}
