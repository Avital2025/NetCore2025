using Queue_management_system.Entities;

namespace Queue_management_system.service
{
    public class QueuesService
    {
        public List<Queues> GetQueuesList()
        {
            if (ManagerDataContext.d.queuesList == null)
            {
                return null;
            }
            return ManagerDataContext.d.queuesList;
        }
        public bool AddQueuesList(Queues queue)
        {
            if (ManagerDataContext.d.queuesList == null)
            {
                return false;
            }
            ManagerDataContext.d.queuesList.Add(queue);
            return true;
        }

        public bool UpdateQueuesList(Queues queue, int queueId)
        {
            if (ManagerDataContext.d.queuesList == null)
            {
                return false;
            }

            Queues q = ManagerDataContext.d.queuesList.Find(q => q.QueueId == queueId);
            q.Name = patient.Name;
            q.Phone = patient.Phone;
            q.Mail = patient.Mail;
            q.AnotherPhone = patient.AnotherPhone;
            q.Age = patient.Age;
            q.Insurance = patient.Insurance;



            return true;
            /*   Name  Age  AnotherPhone  Insurance */


        }

        public bool DeleteQueuesList(int queueId)
        {

            if (ManagerDataContext.d.queuesList == null)
            {
                return false;
            }

            ManagerDataContext.d.queuesList.Remove(ManagerDataContext.d.queuesList.Find(q => q.QueueId == queueId));
            return true;
        }



    }
}
