using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/validation")]
public class AuthController : Controller
{
    private readonly IAuthService _authService;
    private readonly IDbService _dbService;
    private readonly PasswordHasher _passwordHasher;

    public AuthController(IAuthService authService, IDbService dbService, PasswordHasher passwordHasher)
    {
        _authService = authService;
        _dbService = dbService;
        _passwordHasher = passwordHasher;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UserLoginRequest model)
    {
        var user = await _authService.Authenticate(model.Username, model.Password);

        if (user == null)
        {
            return Unauthorized(new { Message = "Invalid username or password" });
        }

        var token = await _authService.GenerateJwtToken(user);
        return Ok(new UserDTO()
        {
            Token = token, DisplayName = user.DisplayName,PrefEng = user.PrefEng,
            Role = new RoleDTO { RoleId = user.Roleid, Name = await _dbService.GetRoleById(user.Roleid) }
        });
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterRequest model)
    {
        var user = new User(){Username = model.Username,Password = _passwordHasher.HashPassword(model.Password),
            DisplayName = model.DisplayName,Roleid = model.RoleId,PrefEng = model.PrefEng};

        if (!(await _dbService.getRoles()).Any(dto => dto.RoleId==model.RoleId))
        {
            return BadRequest(new { Message = "Registration failed" });
        }
        var createdUserTask = await _authService.Register(user);

        if (createdUserTask == "ok")
        {
            return Ok(new { Message = "Registration ok" });
            
        }

        return BadRequest(new { Message = createdUserTask });
        
    }

    [HttpGet("roles")]
    public async Task<IActionResult> GetRoleList()
    {
        return Ok(await _dbService.getRoles());
    }
    [HttpPost("password")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest model)
    {
        var user = await _authService.Authenticate(model.Username, model.CurrentPassword);

        if (user == null)
        {
            return Unauthorized(new { Message = "Invalid username or password" });
        }

        await _dbService.ChangePassword(user, model.NewPassword);
        return Ok(new {Message="Password changed"});
    }
}