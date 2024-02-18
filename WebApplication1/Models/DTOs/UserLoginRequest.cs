using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.DTOs;

public class UserLoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
