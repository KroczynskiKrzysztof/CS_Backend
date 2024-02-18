namespace WebApplication1.Models.DTOs;

public class UserDTO
{
    public string DisplayName { get; set; }
    public RoleDTO Role { get; set; }
    public string Token { get; set; }
    public bool PrefEng { get; set; }
}