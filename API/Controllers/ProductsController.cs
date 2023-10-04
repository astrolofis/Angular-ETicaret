using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        private readonly IProductRepostitory _productRepository;

        public ProductsController(IProductRepostitory productrepository)
        {
            _productRepository= productrepository;
            //_context = context;
        }
        /// <summary>
        /// Database'deki verileri çekme.
        /// </summary>
        /// <returns></returns>
        [HttpGet]//http verbs -> get post delete put
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.GetProductAsync();
            return Ok(data);
        }
        /// <summary>
        /// Database'deki belirli bir veriyi çekme.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async  Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }
        /// <summary>
        /// Database'den brand değerlerini çekme
        /// </summary>
        /// <returns></returns>
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            return Ok( await _productRepository.GetProductBrandAsync());
        }

        /// <summary>
        /// Database'deki type değerlerini çekme
        /// </summary>
        /// <returns></returns>
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            return Ok(await _productRepository.GetProductTypesAsync());
        }
    }
}