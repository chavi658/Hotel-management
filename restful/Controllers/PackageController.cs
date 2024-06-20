using CreateApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restful.core.Services;
using restful.Entities;
using restful.service;

namespace restful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : Controller
    {
        private readonly IPackageService packageService;

        public PackageController(IPackageService packageService_)
        {
            packageService = packageService_;
        }
        //private DataContext _dataContext;

        //public PackageController(DataContext DC)
        //{
        //    _dataContext = DC;
        //}

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
          return  Ok(  await packageService.GetPackagesAsync());
           
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var x =  packageService.GetByIdAsync(id);
            if (x == null)
            {
                return NotFound();
            }

            return Ok(await x);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Package value)
        {
            return Ok(await packageService.AddAsync(value));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Package>> Put(int id, [FromBody] Package value)
        {
            return Ok(await packageService.UpdateAsync(id, value));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var x =  packageService.GetByIdAsync(id);
            if (x == null)
            {
                NotFound();
            }
         await   packageService.DeleteAsync(id);
            return NoContent();
        }
    }
}
