using Microsoft.AspNetCore.Mvc;
using IdentityService.Infrastructure;
using IdentityService.Domain;

namespace IdentityService.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IdentityDbContext _db;

    public AuthController(IdentityDbContext db)
    {
        _db = db;
    }

    [HttpPost("login")]
    public IActionResult Login(string mobile)
    {
        var user = _db.Users.FirstOrDefault(x => x.Mobile == mobile);

        if (user == null)
        {
            user = new User { Mobile = mobile };
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        return Ok(user);
    }
}
