using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.DTOs;
using WebApplication1.Services;

namespace WebApplication1.Controllers;
[ApiController]
[Route("api/admin")]
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly IDbService _dbService;

    public AdminController(IDbService dbService)
    {
        _dbService = dbService;
    }    
    
    [HttpPost("NUKE")]
    public IActionResult Nuke()
    {
        _dbService.Nuke();
        return Ok();
    }

    [HttpPost("/EraseUser")]
    public async Task<IActionResult> EraseUser(IdDTO idDto)
    {
        await _dbService.EraseUser(idDto.Id);
        return Ok();
    }
}