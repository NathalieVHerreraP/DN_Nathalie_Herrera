using DataAccess.Example.Core;
using DataAccess.Example.EntityFrmwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataAccess.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehiclesDataManager _manager;

        public VehiclesController(IVehiclesDataManager manager)
        {
            _manager = manager;
        }

        // GET: api/<ColorsController>
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ColorsController>/5
        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            return _manager.Get(id);
        }

        // POST api/<ColorsController>
        [HttpPost]
        public void Post([FromBody] Vehicle value)
        {
            _manager.Insert(value);
        }

        // PUT api/<ColorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Vehicle value)
        {
            value.Id = id;
            _manager.Update(value);
        }

        // DELETE api/<ColorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _manager.Delete(id);
        }
    }
}
