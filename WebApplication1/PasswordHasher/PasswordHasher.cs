using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;

public class PasswordHasher
{
    private readonly string _secretKey;

    public PasswordHasher(IConfiguration configuration)
    {
        _secretKey = configuration["SecretKey"];
    }

    public string HashPassword(string password)
    {
        using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_secretKey)))
        {
            var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashBytes);
        }
    }

    public bool VerifyPassword(string hashedPassword, string password)
    {
        return hashedPassword == HashPassword(password);
    }
}