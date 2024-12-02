using Queue_management_system.Core.IRepository;
using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Data.Repository
{
    public class EmployeesRepository: IEmployeesRepository
    {
        readonly DataContext _datacontext;
        public EmployeesRepository()
        {

        }
        public EmployeesRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }
        // לממש 5 פוקנציות, יש לי משתנה רידאונלי, דרכו אני פונה לדא קונטקסט
        public List<EmployeesEntity> GetAllData()
        {
            return _datacontext.employeesList;
        }
        public EmployeesEntity GetById(int id)
        {

        }
        public bool AddEmployee(EmployeesEntity employee)
        {
            try
            {
                _datacontext.employeesList.Add(employee);
                _datacontext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool DeleteEmployee(int id)
        {

        }
        public bool UpdateEmpliyee(int id)
        {

        }

        public bool AddEmployeesList(EmployeesEntity employee)
        {
            throw new NotImplementedException();
        }
    }
}
