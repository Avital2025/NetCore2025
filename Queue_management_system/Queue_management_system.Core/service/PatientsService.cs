using Queue_management_system.Entities;

namespace Queue_management_system.service
{
    public class PatientsService
    {
    
        public List<Patients> GetPatientsList()
        {
            if (ManagerDataContext.d.patientsList == null)
            {
                return null;
            }
            return ManagerDataContext.d.patientsList;
        }
        //public Patients GetPatientById(string tz) {

        //    if (ManagerDataContext.d.patientsList == null)
        //        ManagerDataContext.d.patientsList = new List<Patients>();
        //    Patients p = ManagerDataContext.d.patientsList.FirstOrDefault(p => p.patientTZ == tz);
        //    return p;
        //}

        public bool AddPatientsList(Patients patient)
        {
            if (ManagerDataContext.d.patientsList == null)
            {
                return false;
            }
            ManagerDataContext.d.patientsList.Add(patient);
            return true;
        }

        public bool UpdatePatientsList(Patients patient, string patientTZ)
        {
            if (ManagerDataContext.d.patientsList == null)
            {
                return false;
            }

            Patients p = ManagerDataContext.d.patientsList.Find(p => p.patientTZ == patientTZ);
            p.Name = patient.Name;
            p.Phone = patient.Phone;
            p.Mail = patient.Mail;
            p.AnotherPhone = patient.AnotherPhone;
            p.Age = patient.Age;
            p.Insurance = patient.Insurance;

            return true;
            /*   Name  Age  AnotherPhone  Insurance */


        }
        public bool DeletePatientsList(string patientTZ)
        {

            if (ManagerDataContext.d.patientsList == null)
            {
                return false;
            }

            ManagerDataContext.d.patientsList.Remove(ManagerDataContext.d.patientsList.Find(c => c.patientTZ == patientTZ));
            return true;
        }
    }
}
