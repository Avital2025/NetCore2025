using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Core.Iservice;
using Queue_management_system.Entities;
using Queue_management_system.service;
using Queue_management_system.Service.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queue_management_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueuesController : ControllerBase
    {

        readonly IQueuesService _queuesService;

        public QueuesController(IQueuesService queuesService)
        {
            _queuesService = queuesService;
        }

        // GET: api/<PatientsController>
        [HttpGet]
        public ActionResult<IEnumerable<QueuesEntity>> Get()
        {
            IEnumerable<QueuesEntity> result = _queuesService.GetQueuesList();
            if (result == null)
                return NotFound();
            return Ok(result);


        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]

        public ActionResult<QueuesEntity> Getbyid(int id)
        {
            if (id < 0)
                return BadRequest();
            QueuesEntity result = _queuesService.GetById(id);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] QueuesEntity value)
        {
            var result = _queuesService.PostQueue(value);
            if (!result) return BadRequest();
            return result;
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] QueuesEntity value)
        {
            if (value == null || id < 0)
                return BadRequest();
            bool f = _queuesService.PutQueue(id, value);
            if (!f)
                return NotFound();
            return f;

        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id < 0)
                return BadRequest();

            bool result = _queuesService.DeleteQueue(id);
            if (!result)
                return NotFound();
            return result;

        }


    }
}
