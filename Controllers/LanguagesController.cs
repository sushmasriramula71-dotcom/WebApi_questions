using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers;

[ApiController]
[Route("[controller]")]
public class LanguagesController : ControllerBase
{
    [HttpGet]
    public string[] Get()
    {
        return ["C#", "Java", "Python", "JavaScript", "Go"];
    }
}