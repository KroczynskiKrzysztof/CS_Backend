using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using WebApplication1.Models.DTOs;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/user")]
[Authorize(Roles = "User, Mod, Admin")]
public class UserController : Controller
{
    private readonly IDbService _dbService;

    public UserController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("/posts")]
    public async Task<IActionResult> GetPaginatedPosts(int pageNumber, int pageSize)
    {
        
        var posts = await _dbService.GetPaginatedPosts(pageNumber, pageSize,HttpContext.User.FindFirst(ClaimTypes.Role).Value);
        return Ok(posts);
    }

    [HttpGet("/postsWithTag")]
    public async Task<IActionResult> GetPaginatedPosts(int pageNumber, int pageSize, int tagId)
    {

        return Ok(await _dbService.GetPaginatedPosts(pageNumber, pageSize, tagId,HttpContext.User.FindFirst(ClaimTypes.Role).Value));
    }

    [HttpGet("/postdetails")]
    public async Task<IActionResult> GetPost(int id)
    {
        var post = await _dbService.GetPostDetails(id)!;
        if (post is null)
        {
            return NotFound();
        }

        return Ok(post);
    }

    [HttpPost("/addPost")]
    public async Task<IActionResult> PostPost(NewPostRequest newPostRequest)
    {
        if (string.IsNullOrWhiteSpace(newPostRequest.Content)||string.IsNullOrWhiteSpace(newPostRequest.Title))
        {
            return BadRequest(new{message="Title and content cannot be empty or filled with whitespaces"});
        }
        
        var userID =Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
        var post = await _dbService.AddNewPost(newPostRequest,userID);
        if (post is null)
        {
            return BadRequest("sth went wrong");
        }

        return Ok(post.PostId.ToString());
    }

    [HttpPost("/addComment")]
    public async Task<IActionResult> AddComment(CommentDTO2 commentDto2)
    {
        if (string.IsNullOrEmpty(commentDto2.Content))
        {
            return BadRequest(new{message="Comment cannot be empty!"});
        }
        var userID =Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
        var comment = _dbService.AddComment(commentDto2, userID);
        if (comment is null)
        {
            return BadRequest("sth went wrong");
        }

        return Ok(new{Message="Comment submitted"});
    }
}