using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Entities;
using Queue_management_system.service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queue_management_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueuesController : ControllerBase
    {

        static QueuesService q = new QueuesService();

        // GET: api/<QueuesController>
        [HttpGet]
        public ActionResult<List<Queues>> Get()
        {
            List<Queues> result = new List<Queues>();
            return result;
        }

        // GET api/<QueuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Queues> GetQueuebyid(int id)
        {
            if (id < 0)
                return BadRequest();
            Employees res = q.GetQueueById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<QueuesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Queues value)
        {
            return q.AddQueuesList(value);
        }



        // PUT api/<QueuesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int queueid, [FromBody] Queues value)
        {
            return q.UpdateQueuesList(value, queueid);
        }


        // DELETE api/<QueuesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return q.DeleteQueuesList(id);
        }


    }
}
