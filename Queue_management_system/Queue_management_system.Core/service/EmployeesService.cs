using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Service.Entities;

namespace Queue_management_system.service
{
    public class EmployeesService: IEmployeesService
    {

        readonly IGenericRepository<EmployeesEntity> _employeesRepository;
        public EmployeesService(IGenericRepository<EmployeesEntity> employeesRepository)
        {
            _employeesRepository= employeesRepository;
        }
        public EmployeesEntity GetById(int id)
        {
            return _employeesRepository.GetById(id);
        }
        public IEnumerable<EmployeesEntity> GetEmployeesList()
        {
            return _employeesRepository.GetAllData();
        }

        public bool DeleteEmployee(int id)
        {

            return _employeesRepository.DeleteData(id);
        }       

        public bool PostEmployee(EmployeesEntity employee)
        {
            return _employeesRepository.AddData(employee);
        }


        public bool PutEmployee(int id, EmployeesEntity employee)
        {
            return _employeesRepository.UpdateData(id, employee);
        }

    
    }
}
