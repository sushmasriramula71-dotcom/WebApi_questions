using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            id = 1,
            name = "Laptop",
            price = 75000,
            brand = "Dell"
        });
    }
}