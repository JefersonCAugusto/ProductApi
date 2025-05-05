using Domain;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProduct()
    {
        return Ok(_context.Products.ToList());
    }

    [HttpPost]
    public ActionResult<Product> CreateProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();

        return CreatedAtAction(nameof(CreateProduct), new { id = product.Id }, product);
    }
}
