using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Identity.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController: ControllerBase
{
    [HttpGet]
    [Authorize]
    public string? Get()
    {
        return $"Hello {User.Identity?.Name} from controller." ;
    }
}
