using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IAuthService
{
    public Task<string> GenerateJwtToken(User user);
    public Task<string>? Register(User user);
    public Task<User>? Authenticate(string username, string password);
    
}