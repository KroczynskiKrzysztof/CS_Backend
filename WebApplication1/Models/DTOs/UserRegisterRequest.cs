namespace WebApplication1.Models.DTOs;

public class UserRegisterRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string DisplayName { get; set; }
    public int RoleId { get; set; }
    public bool PrefEng { get; set; }
}