using CreateApi;
using Microsoft.AspNetCore.Mvc;
using restful.core.Services;
using restful.Entities;
using restful.service;

namespace RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly IRoomService RoomService;
     
        public RoomController(IRoomService RoomService_)
        {
            RoomService = RoomService_;
        }
        //private DataContext _dataContext;

        //public RoomController(DataContext DC)
        //{
        //    _dataContext = DC;
        //}

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           return  Ok( await RoomService.GetRooms());
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> Get(int id)
        {
            var x =  RoomService.GetByIdAsync( id);
            if (x == null)
            {
                return NotFound();
            }

            return Ok(await x);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Room value)
        {
            return Ok(await RoomService.AddAsync(value));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Room>> Put(int id, [FromBody] Room value)
        {
            return Ok(await RoomService.UpdateAsync(id, value));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var x = RoomService.GetByIdAsync(id);
            if (x == null)
            {
                NotFound();
            }
           await RoomService.DeleteAsync(id);
            return NoContent();
        }
    }
}
