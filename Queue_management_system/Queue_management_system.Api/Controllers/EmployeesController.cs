using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Core.Iservice;
using Queue_management_system.service;
using Queue_management_system.Service.Entities;
using System.Diagnostics.Metrics;

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
            IEnumerable<EmployeesEntity> result = _employeesService.GetEmployeesList();
            if (result == null)
                return NotFound();
            return Ok(result);

   
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]

        public ActionResult<EmployeesEntity> Getbyid(int id)
        {
            if (id < 0)
                return BadRequest();
            EmployeesEntity res = _employeesService.GetById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] EmployeesEntity value)
        {
            var result = _employeesService.PostEmployee(value);
            if (!result) return BadRequest();
            return result;
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] EmployeesEntity value)
        {
            if (value == null || id < 0)
                return BadRequest();
            bool f = _employeesService.PutEmployee(id, value);
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

            bool result = _employeesService.DeleteEmployee(id);
            if (!result)
                return NotFound();
            return result;

        }
    }
}
