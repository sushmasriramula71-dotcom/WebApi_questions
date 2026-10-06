using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(int id)
    {
        if (id == 101)
        {
            return Ok(new
            {
                id = 101,
                name = "Rahul",
                department = "IT"
            });
        }

        return NotFound("Employee not found");
    }
}