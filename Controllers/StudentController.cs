using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            id = 101,
            name = "Rahul",
            course = "B.Tech",
            age = 21
        });
    }
}