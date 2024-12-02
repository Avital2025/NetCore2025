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
    public class QueuesRepository: IGenericRepository<QueuesEntity>
    {
        readonly DataContext _dataContext;


        public QueuesRepository(DataContext datacontext)
        {
            _dataContext = datacontext;
        }


        public IEnumerable<QueuesEntity> GetAllData()
        {
            return _dataContext.queuesList;

        }


        public QueuesEntity GetById(int id)
        {
            var data = _dataContext.queuesList;
            if (data == null)
                return null;
            return data.Where(c => c.QueueId == id).FirstOrDefault();
        }


        public bool AddData(QueuesEntity queue)
        {
            try
            {
                _dataContext.queuesList.Add(queue);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteData(int id)
        {
            var data = _dataContext.queuesList;
            if (data == null) return false;
            int index = data.FindIndex(x => x.QueueId == id);
            if (index != -1)
            {
                data.Remove(data.Find(x => x.QueueId == id));
                _dataContext.SaveChange();
                return true;
            }
            return false;
        }
        public bool UpdateData(int id, QueuesEntity queue)
        {
            var data = _dataContext.queuesList;
            if (data == null) return false;
            int index = data.FindIndex(x => x.QueueId == id);
            if (index != -1)
            {
                data.RemoveAt(index);
                data.Insert(index, queue);
                _dataContext.SaveChange();
                return true;
            }
            return false;
        }
    }
}
