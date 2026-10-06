using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers;

[ApiController]
[Route("[controller]")]
public class CreateStudentController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(Student student)
    {
        return Ok(new
        {
            message = "Student created successfully",
            name = student.Name,
            age = student.Age,
            course = student.Course
        });
    }
}

public record Student(string Name, int Age, string Course);