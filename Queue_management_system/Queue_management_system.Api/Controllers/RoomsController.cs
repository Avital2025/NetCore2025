using Microsoft.AspNetCore.Mvc;
using Queue_management_system.Entities;
using Queue_management_system.service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queue_management_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        static RoomsService r = new RoomsService();
        // GET: api/<RoomsController>
        [HttpGet]
        public ActionResult<List<Rooms>> Get()
        {
            List<Rooms> result = new List<Rooms>();
            return result;
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoomsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Rooms value)
        {
            return r.AddRoomsList(value);
        }


        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int roomid, [FromBody] Rooms value)
        {
            return r.UpdateRoomsList(value, roomid);
        }


        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int roomid)
        {
            return r.DeleteRoomsList(roomid);
        }


    }
}
