using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Entities;
using Queue_management_system.service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queue_management_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        static PatientsService p = new PatientsService();

        // GET: api/<PatientsController>
        [HttpGet]
        public ActionResult<List<Patients>> Get()
        {
            List<Patients> result = new List<Patients>();

            return result;
        }

        // GET api/<PatientsController>/5
        [HttpGet("{id}")]
        //public ActionResult<Patients> Getbyid(string tz)
        //{
        //    if (tz == null)
        //        return BadRequest();
        //    Patients res = p.GetPatientById(tz);
        //    if (res == null)
        //        return NotFound();
        //    return res;
        //}

        // POST api/<PatientsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Patients value)
        {
            return p.AddPatientsList(value);

        }

        // PUT api/<PatientsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string patientTZ, [FromBody] Patients value)
        {
            return p.UpdatePatientsList(value, patientTZ);
        }

        // DELETE api/<PatientsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string patientTZ)
        {
            return p.DeletePatientsList(patientTZ);
        }
    }
}
