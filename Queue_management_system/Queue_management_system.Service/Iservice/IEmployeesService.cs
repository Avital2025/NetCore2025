using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Core.Iservice
{
    public interface IEmployeesService
    {
        IEnumerable<EmployeesEntity> GetEmployeesList();

        EmployeesEntity GetById(int id);

        bool PostEmployee(EmployeesEntity employee);
        bool PutEmployee(int id, EmployeesEntity employee);
        bool DeleteEmployee(int id);

    }
}
