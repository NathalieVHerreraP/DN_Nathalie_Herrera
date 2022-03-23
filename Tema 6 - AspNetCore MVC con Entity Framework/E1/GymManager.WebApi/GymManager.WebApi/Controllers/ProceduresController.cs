using GymManager.Core;
using GymManager.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProceduresController : ControllerBase
    {

        private readonly iProceduresCall _queries;

        public ProceduresController(iProceduresCall queries) 
        {
            _queries = queries;
        }

        [HttpPost]
        public IEnumerable<ProductTypes> GetInventory([FromBody]int id)
        {
            var result = _queries.GetInventory(id);
            return result;
        }

        [HttpGet (nameof(GetNewMembers))]
        public IEnumerable<Members> GetNewMembers()
        {
            var result = _queries.GetNewMembers();
            return result;
        }

        [HttpPost (nameof(NewSale))]
        public IEnumerable<ProductTypes> NewSale([FromBody] NewSaleIds newSaleIds)
        {
            _queries.NewSale(newSaleIds);
            return null;
        }
    }

}
