using WebApplication1.Services;

namespace WebApplication1.Middlewares;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class UserIdMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IServiceProvider _serviceProvider;

    public UserIdMiddleware(RequestDelegate next, IServiceProvider serviceProvider)
    {
        _next = next;
        _serviceProvider = serviceProvider;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var controllerName = context.Request.RouteValues["controller"]?.ToString();
        Console.WriteLine(controllerName);
        if (!string.IsNullOrEmpty(controllerName) && controllerName == "Auth")
        {
            await _next(context);
            return;
        }
        
        var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

        if (string.IsNullOrEmpty(token))
        {
            context.Response.StatusCode = 401;
            return;
        }

        try
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            if (jsonToken == null)
            {
                context.Response.StatusCode = 401; // Unauthorized
                return;
            }

            var userId = jsonToken.Claims.FirstOrDefault(claim => claim.Type == "nameid")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                context.Response.StatusCode = 401;
                return;
            }

            var scope = _serviceProvider.CreateScope();
            if (scope.ServiceProvider.GetRequiredService<IDbService>().ValidateUser(int.Parse(userId)))
            {
                context.Response.StatusCode = 401;
                return;
            }
            await _next(context);
        }
        catch (Exception)
        {
            context.Response.StatusCode = 401;
        }
    }
}