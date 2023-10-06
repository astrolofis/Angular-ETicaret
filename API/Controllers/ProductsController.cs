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
        /*
        private readonly StoreContext _context;

        private readonly IProductRepostitory _productRepository;
        */
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductBrand> _productBrandRepository;
        private readonly IGenericRepository<ProductType> _productTypeRepository;

        public ProductsController(IGenericRepository<Product> productRepository,
            IGenericRepository<ProductBrand> productBrandRepository,
            IGenericRepository<ProductType> productTypeRepository)
        {
            _productRepository= productRepository;
            _productBrandRepository= productBrandRepository;
            _productTypeRepository= productTypeRepository;
            //_context = context;
        }
        


        /// <summary>
        /// Database'deki verileri çekme.
        /// </summary>
        /// <returns></returns>
        [HttpGet]//http verbs -> get post delete put
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.ListAllAsync();
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
            return await _productRepository.GetByIdAsync(id);
        }
        /// <summary>
        /// Database'den brand değerlerini çekme
        /// </summary>
        /// <returns></returns>
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            return Ok( await _productBrandRepository.ListAllAsync());
        }

        /// <summary>
        /// Database'deki type değerlerini çekme
        /// </summary>
        /// <returns></returns>
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            return Ok(await _productTypeRepository.ListAllAsync());
        }
    }
}