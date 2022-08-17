using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;
            //to ensure that the seedign of the database is occuring 
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToArray();
        }
        // Can also write it with actionresult instead of iEnumerable
        //public actionresult getallproducts()
        //{
        //    return ok(_context.products.toarray());
        //}
    }
}
