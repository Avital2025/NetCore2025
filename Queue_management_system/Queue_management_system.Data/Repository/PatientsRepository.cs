using Queue_management_system.Core.IRepository;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Data.Repository
{
    public class PatientsRepository:IGenericRepository<PatientsEntity>
    {
        readonly DataContext _dataContext;


        public PatientsRepository(DataContext datacontext)
        {
            _dataContext = datacontext;
        }


        public IEnumerable<PatientsEntity> GetAllData()
        {
            return _dataContext.patientsList;

        }


        public PatientsEntity GetById(int id)
        {
            var data = _dataContext.patientsList;
            if (data == null)
                return null;
            return data.Where(c => c.patientTZ == id).FirstOrDefault();
        }


        public bool AddData(PatientsEntity patient)
        {
            try
            {
                _dataContext.patientsList.Add(patient);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteData(int id)
        {
            var data = _dataContext.patientsList.ToList();
            if (data == null) return false;
            int index = data.FindIndex(x => x.patientTZ == id);
            if (index != -1)
            {
                data.Remove(data.Find(x => x.patientTZ == id));
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateData(int id, PatientsEntity patient)
        {
            var data = _dataContext.patientsList.ToList();
            if (data == null) return false;
            int index = data.FindIndex(x => x.patientTZ == id);
            if (index != -1)
            {
                data.RemoveAt(index);
                data.Insert(index, patient);
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }

   
    }
}
