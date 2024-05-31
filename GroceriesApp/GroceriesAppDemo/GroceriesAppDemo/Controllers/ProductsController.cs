using GroceriesAppDemo.Data;
using GroceriesAppDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroceriesAppDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        Context _context;

        public ProductsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsModel>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpPost]
        public void PostProduct(ProductsModel model)
        {
            _context.Products.Add(model);
            _context.SaveChanges();
        }
    }
}
