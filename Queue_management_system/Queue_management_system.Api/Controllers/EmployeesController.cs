using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Core.Iservice;
using Queue_management_system.service;
using Queue_management_system.Service.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queue_management_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult<IEnumerable<EmployeesEntity>> Get()
        {
            List<EmployeesEntity> result = new List<EmployeesEntity>();

            return result;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]

        public ActionResult<EmployeesEntity> Getbyid(int id)
        {
            if (id < 0)
                return BadRequest();
            EmployeesEntity res = _employeesService.GetEmployeeById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] EmployeesEntity value)
        {
            return e.AddEmployeesList(value);

        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] EmployeesEntity value)
        {
            return e.UpdateEmployeesList(value, id);

        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return e.DeleteEmployeesList(id);

        }
    }
}
