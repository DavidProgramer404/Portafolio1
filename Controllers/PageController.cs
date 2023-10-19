using Microsoft.AspNetCore.Mvc;
namespace Portafolio1.Controllers;


public class HelloController : Controller{
    [HttpGet]
    [Route("")]
    public string Index(){
        return "This is my Index!";
    }

    // Route declaration Option B
    // This will go to "localhost:5XXX/user/more"
    [HttpGet("projects")]
    public string Projects(){
        return "Thys is my projects";
    }

    [HttpGet("contact")]
    public string Contact(){
        return "  Thys is my Contact!";
    }
}