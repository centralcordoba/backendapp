using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace apiAppPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingPaysController : ControllerBase
    {
        

        // POST: api/ShoppingPays
        [HttpPost]
        public void Post([FromBody]ShoppingPay shoppingPays)
        {
            string result = string.Empty;
            ShoppingRepository repository = new ShoppingRepository();
            result = repository.ShoppingPays(shoppingPays);
        }

        // PUT: api/ShoppingPays/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
