using Microsoft.AspNetCore.Mvc;


[ApiController] 
[Route("api/[controller]")]
public class DevelopersController : ControllerBase
{
    [HttpGet]
    public string[] GetDevs()
    {
        return new string [] {"Thabo","Kevin", "Lebogang"};
    }


    [HttpGet("{id}")]
    public string GetDeveloper([FromRoute] int id)
    {
        return $"Developer ID: {id}";
        }


}

    
