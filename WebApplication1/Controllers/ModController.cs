using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.DTOs;
using WebApplication1.Services;

namespace WebApplication1.Controllers;
[ApiController]
[Route("api/mod")]
[Authorize(Roles = "Mod, Admin")]
public class ModController : Controller
{
    private readonly IDbService _dbService;

    public ModController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpPost("/deleteComment")]
    public async Task<IActionResult> DeleteComment( int cdr)
    {
        if (await _dbService.DeleteComment(cdr))
        {
            return Ok();
        }
        return BadRequest();
    } 
    [HttpPost("/deleteTag")]
    public async Task<IActionResult> DeleteTag(TagDeleteRequest tagDeleteRequest )
    {
        if (await _dbService.DeletePostTag(tagDeleteRequest))
        {
            return Ok();
        }
        return BadRequest();
    }
    [HttpPost("/addTag")]
    public async Task<IActionResult> AddTag(TagAddRequest tagAddRequest )
    {
        if (await _dbService.AddPostTag(tagAddRequest))
        {
            return Ok();
        }
        return BadRequest();
    }

    [HttpPost("/hidePost")]
    public async Task<IActionResult> HidePost([FromBody] IdDTO postId)
    {
        var role = HttpContext.User.FindFirst(ClaimTypes.Role).Value;

        if (await _dbService.HidePost(postId.Id,role=="Mod"?1:2))
        {
            return Ok();
        }

        return BadRequest();

    }
    
}