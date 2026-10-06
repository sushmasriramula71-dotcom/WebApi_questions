using Microsoft.AspNetCore.Mvc;
namespace MyApp.Controllers;

[ApiController]
[Route("Controller")]
public class AddtwoNumController: ControllerBase
{
   [HttpPost]
   public int post(int n1,int n2)
    {
       return n1+n2 ;
    }
   
   
}