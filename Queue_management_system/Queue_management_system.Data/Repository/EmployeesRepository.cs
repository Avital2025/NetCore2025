using Microsoft.EntityFrameworkCore;
using Queue_management_system.Core.IRepository;
using Queue_management_system.Service.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_management_system.Data.Repository
{
    public class EmployeesRepository: IGenericRepository<EmployeesEntity>
    {
        readonly DataContext _dataContext;


        public EmployeesRepository(DataContext datacontext)
        {
            _dataContext = datacontext;
        }


        public IEnumerable<EmployeesEntity> GetAllData()
        {
            return _dataContext.employeesList;

        }


        public EmployeesEntity GetById(int id)
        {
            var data = _dataContext.employeesList;
            if (data == null)
                return null;
            return data.Where(c => c.EemployeeId == id).FirstOrDefault();
        }


        public bool AddData(EmployeesEntity employee)
        {
            try
            {
                _dataContext.employeesList.Add(employee);
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
            var data = _dataContext.employeesList.ToList();
            if (data == null) return false;
            int index = data.FindIndex(x => x.EemployeeId == id);
            if (index != -1)
            {
                data.Remove(data.Find(x => x.EemployeeId == id));
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateData(int id, EmployeesEntity employee)
        {
            var data = _dataContext.employeesList.ToList();
            if (data == null) return false;
            int index = data.FindIndex(x => x.EemployeeId == id);
            if (index != -1)
            {
                data.RemoveAt(index);
                data.Insert(index, employee);
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
       
        
    }
}
