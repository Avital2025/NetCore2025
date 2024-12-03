using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Service.Entities;

namespace Queue_management_system.service
{
    public class PatientsService: IPatientsService
    {
        readonly IGenericRepository<PatientsEntity> _patientsRepository;
        public PatientsService(IGenericRepository<PatientsEntity> patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }
        public PatientsEntity GetById(int id)
        {
            return _patientsRepository.GetById(id);
        }
        public IEnumerable<PatientsEntity> GetPatientsList()
        {
            return _patientsRepository.GetAllData();
        }

        public bool DeletePatient(int id)
        {

            return _patientsRepository.DeleteData(id);
        }

        public bool PostPatient(PatientsEntity employee)
        {
            return _patientsRepository.AddData(employee);
        }


        public bool PutPatient(int id, PatientsEntity employee)
        {
            return _patientsRepository.UpdateData(id, employee);
        }

    }
}
