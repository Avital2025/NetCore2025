using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Core.Iservice;
using Queue_management_system.service;
using Queue_management_system.Service.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queue_management_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        readonly IPatientsService _patientsService;

        public PatientsController(IPatientsService patientsService)
        {
            _patientsService = patientsService;
        }

        // GET: api/<PatientsController>
        [HttpGet]
        public ActionResult<IEnumerable<PatientsEntity>> Get()
        {
            IEnumerable<PatientsEntity> result = _patientsService.GetPatientsList();
            if (result == null)
                return NotFound();
            return Ok(result);


        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]

        public ActionResult<PatientsEntity> Getbyid(int id)
        {
            if (id < 0)
                return BadRequest();
            PatientsEntity result = _patientsService.GetById(id);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] PatientsEntity value)
        {
            var result = _patientsService.PostPatient(value);
            if (!result) return BadRequest();
            return result;
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] PatientsEntity value)
        {
            if (value == null || id < 0)
                return BadRequest();
            bool f = _patientsService.PutPatient(id, value);
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

            bool result = _patientsService.DeletePatient(id);
            if (!result)
                return NotFound();
            return result;

        }




    }
}
