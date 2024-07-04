using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

public class HelloController : ControllerBase
{
    [HttpGet("/hello")] // Specify route attribute here if not using MapGet directly
    public IActionResult Hello()
    {
        return Ok("Hello, This is claims service!");
    }
}