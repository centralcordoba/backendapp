using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAppPet.Privates;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace apiAppPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        
        /// <summary>
        /// A partir de la lista de productos pedidos, filtra de acuerdo a los productos ya pagados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetShopping")]
        public List<Shopping> GetShopping(string id)
        {
            List<Shopping> lstShopping = new List<Shopping>();
            ShoppingRepository repository = new ShoppingRepository();
            lstShopping = repository.GetShoppingByIdUser(id); 

            return ShoppingActions.SearchProductBuys(lstShopping);
        }

        

        // PUT: api/Shopping/5
        [HttpPost]
        public void Post([FromBody]Shopping shopping)
        {
            string result = string.Empty;
            ShoppingRepository repository = new ShoppingRepository();
            result = repository.DeleteShoppingById(shopping.Id_Trolley);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            string result = string.Empty;
            ShoppingRepository repository = new ShoppingRepository();
            result = repository.DeleteShoppingById(id);
        }
    }
}
