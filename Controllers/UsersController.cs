using Microsoft.AspNetCore.Mvc;

namespace Discoteque.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public string get()
    {
        // var result = new { status = "healthy" };
        // return Ok(result);
        return "Building";
    }
}