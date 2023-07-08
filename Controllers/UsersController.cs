using Microsoft.AspNetCore.Mvc;

namespace Discoteque.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string getAll()
    {
        // var result = new { status = "healthy" };
        // return Ok(result);
        return "Building";
    }


    [HttpGet]
    [Route("{id}")]
    public string GetById(string id)
    {
        // var result = new { status = "healthy" };
        // return Ok(result);
        return $"Building {id}";
    }
}