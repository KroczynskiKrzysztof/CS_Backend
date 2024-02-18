// AuthService.cs

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;
using WebApplication1.Services;


public class AuthService: IAuthService
{
    private readonly IDbService _dbService;

    public AuthService(IDbService dbService)
    {
        _dbService = dbService;
    }

    public async Task<User>? Authenticate(string username, string password)
    {
        var user =  await _dbService.GetUserByUsernameAndPassword(username, password);

   
        return user!;
    }

    public async Task<string> GenerateJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = "consequat ac felis donec et odio pellentesque diam volutpat commodo sed egestas egestas fringilla phasellus faucibus scelerisque eleifend donec pretium"u8.ToArray();
        string? role = await _dbService.GetRoleById(user.Roleid) ?? "User";
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, role)
            }),
            Expires = DateTime.UtcNow.AddYears(1), 
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    public async Task<string> Register(User user)
    {

        if (await _dbService.ValidateNewUsername(user.Username))
        {
            return "username taken";
        }

        if (await _dbService.ValidateDisplayName(user.DisplayName))
        {
            return "display name taken";
        }
        
        
        await _dbService.CreateUser(user);
        return "ok"; 
            
    }
}