using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Service.Entities;

namespace Queue_management_system.service
{
    public class EmployeesService: IEmployeesService
    {

        readonly IEmployeesRepository _employeesRepository;
        public EmployeesService( IEmployeesRepository employeesRepository)
        {
            _employeesRepository= employeesRepository;
        }


        public IEnumerable<EmployeesEntity> GetEmployeesList()
        {
            return _employeesRepository.GetAllData();
        }

        List<EmployeesEntity> IEmployeesService.GetEmployeesList()
        {
            throw new NotImplementedException();
        }
    }
}
