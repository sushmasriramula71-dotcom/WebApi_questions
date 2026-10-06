using Microsoft.AspNetCore.Mvc;
 
namespace MyApp.Controllers;
 
[ApiController]
[Route("[controller]")]
public class  GreetingController : ControllerBase
{
    [HttpPost]
    public string post(string name)
    {
        return $"Hello {name}";
    }
}