using API.Core.DbModels;
using API.Infrastructure.DataContext;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Database'deki verileri çekme.
        /// </summary>
        /// <returns></returns>
        [HttpGet]//http verbs -> get post delete put
        public ActionResult<List<Product>> GetProducts()
        {
            var data =  _context.Products.ToList();
            return data;
        }
        /// <summary>
        /// Database'deki belirli bir veriyi çekme.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public  ActionResult<Product> GetProduct(int id)
        {
            return  _context.Products.Find(id);
        }
    }
}