using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Core.Iservice;
using Queue_management_system.service;
using Queue_management_system.Service.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queue_management_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        readonly IRoomsService _roomsService;

        public RoomsController(IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }

        // GET: api/<PatientsController>
        [HttpGet]
        public ActionResult<IEnumerable<RoomsEntity>> Get()
        {
            IEnumerable<RoomsEntity> result = _roomsService.GetRoomsList();
            if (result == null)
                return NotFound();
            return Ok(result);


        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]

        public ActionResult<RoomsEntity> Getbyid(int id)
        {
            if (id < 0)
                return BadRequest();
            RoomsEntity result = _roomsService.GetById(id);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] RoomsEntity value)
        {
            var result = _roomsService.PostRoom(value);
            if (!result) return BadRequest();
            return result;
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] RoomsEntity value)
        {
            if (value == null || id < 0)
                return BadRequest();
            bool f = _roomsService.PutRoom(id, value);
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

            bool result = _roomsService.DeleteRoom(id);
            if (!result)
                return NotFound();
            return result;

        }


    }
}
