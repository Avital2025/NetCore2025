using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Entities;
using Queue_management_system.Service.Entities;

namespace Queue_management_system.service
{
    public class PatientsService: IPatientsService
    {
        readonly IGenericRepository<PatientsService> _patientsRepository;
        public PatientsService(IGenericRepository<PatientsService> patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }
        public PatientsService GetById(int id)
        {
            return _patientsRepository.GetById(id);
        }
        public IEnumerable<PatientsService> GetPatientsList()
        {
            return _patientsRepository.GetAllData();
        }

        public bool DeletePatient(int id)
        {

            return _patientsRepository.DeleteData(id);
        }

        public bool PostPatient(PatientsService employee)
        {
            return _patientsRepository.AddData(employee);
        }


        public bool PutPatient(int id, PatientsService employee)
        {
            return _patientsRepository.UpdateData(id, employee);
        }

    }
}
