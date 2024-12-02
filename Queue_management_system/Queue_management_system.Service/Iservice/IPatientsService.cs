using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Core.Iservice
{
    public interface IPatientsService
    {
        IEnumerable<PatientsEntity> GetPatientsList();

        PatientsEntity GetById(int id);

        bool PostPatient(PatientsEntity patient);
        bool PutPatient(int id, PatientsEntity patient);
        bool DeletePatient(int id);
    }
}
