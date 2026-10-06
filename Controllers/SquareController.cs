using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
namespace MyApp.Controllers;
[ApiController]
[Route("[controller]")]
public class SquareController:ControllerBase
{
    [HttpPost]
    public int post(int n)
    {
        return n*n;
    }
}
