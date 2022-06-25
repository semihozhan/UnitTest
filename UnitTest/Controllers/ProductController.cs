using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using Service.Abstract;

namespace UnitTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _product;
        public ProductController(IProductService product)
        {
            _product = product;
        }


        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _product.GetAll();
        }

        [HttpGet("{id}")]
        public Product ById(int id)
        {
            if (id < 0) { throw new System.Exception("Hatalı id"); }
            return _product.ByID(id);
        }
    }
}