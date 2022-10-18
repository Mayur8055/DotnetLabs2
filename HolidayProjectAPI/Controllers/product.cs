using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class product : ControllerBase
    {
       private static List<Product>products=new List<Product> 

            {
                new Product
                {
                    id = 1,
                    name="Laptop",
                    cost=50000.0

                },
                 new Product
                {
                    id = 2,
                    name="Mobile",
                    cost=40000.0

                },
                  new Product
                {
                    id = 3,
                    name="Earphone",
                    cost=5000.0

                },
                   new Product
                {
                    id = 4,
                    name="Refridgerator",
                    cost=30000.0

                },
                    new Product
                {
                    id = 5,
                    name="Shoes",
                    cost=5000.0

                },
                     new Product
                {
                    id = 6,
                    name="Iron",
                    cost=2000.0

                },
                      new Product
                {
                    id = 7,
                    name="Washing-Machine",
                    cost=20000.0

                },
         };


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            
            return Ok(products);

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<List<Product>>> GetProduct(int Id)
        {
            var product =products.Find(p => p.id == Id);
            if (product == null)
                return BadRequest("product not found");

            return Ok(product);

        }
        [HttpPost]
        public async Task<ActionResult<List<Product>>> InsertProducts(Product product)
            
        {
            products.Add(product);
            return Ok(products);
        }
    }
}
