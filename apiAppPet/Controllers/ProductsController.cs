using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace apiAppPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Products
        [HttpGet]
        public List<Products> Get()
        {
            List<Products> lstproducts = new List<Products>();
            ProductsRepository repository = new ProductsRepository();
            lstproducts = repository.GetAllProductsPendent();

            return lstproducts;
        }

        [HttpPost]
        public void Post([FromBody]Products dataProduct)
        {
            string result = string.Empty;
            ProductsRepository repository = new ProductsRepository();
            result = repository.AddProducts(dataProduct);
        }

        //[Route("GetShopping")]
        //[HttpGet]
        //public List<Shopping> GetShopping(int id)
        //{
        //    List<Shopping> lstShopping = new List<Shopping>();
        //    ProductsRepository repository = new ProductsRepository();
        //    lstShopping = repository.GetShoppingByIdUser(id);
        //    return lstShopping;
        //}

    }
}
