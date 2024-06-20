using CreateApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restful.Entities;
using restful.core.Services;
using restful.service;

namespace RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : Controller
    {

        private readonly IGuestService guestService;
        public GuestController(IGuestService guestService_)
        {
            guestService = guestService_;
        }
        //private DataContext _dataContext;

        //public GuestController(DataContext DC)
        //{
        //    _dataContext = DC;
        //}
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> Get() {

         return  Ok( await guestService.GetGuestsAsync());
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Guest>> Get(int id)
        {
            
           var x = await guestService.GetByIdAsync(id);
            if (x == null)
            {
                return NotFound();
            }

            return Ok( x);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Guest value)
        {
            var guestToAdd = await guestService.AddAsync(value);
            //guestService.GetGuests().Add(value);
            return  Ok(guestToAdd);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public  async Task<ActionResult<Guest>> Put(int id, [FromBody] Guest value)
        {
            var x = await guestService.GetByIdAsync(id);
            
            if (x == null)
            {
                return NotFound();
            }
          return  Ok( await guestService.UpdateAsync(id, value));
            
        }
        [HttpPut("{id}/status")]
        //public async Task<Guest> Put(int id, [FromBody] string status)
        //{
            //find the object by id
            //var x = guestService.GetById(id);
            //await guestService.Update(id, value);
            //udpate properties
            //eve.Title = updateEvent.Title;
            //return x;
        //}

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var x = guestService.GetByIdAsync(id);
            if (x == null)
            {
                NotFound();
            }
            else  await guestService.DeleteAsync(id);
        }
    }
}
