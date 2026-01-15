using Microsoft.AspNetCore.Mvc;
using PPSA.CRM.API.DTOs;
using PPSA.CRM.API.Services;

namespace PPSA.CRM.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    /// <summary>
    /// Login with email and password
    /// </summary>
    [HttpPost("login")]
    public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest request)
    {
        var result = await _authService.LoginAsync(request);
        
        if (result == null)
            return Unauthorized(new { message = "Invalid email or password" });

        return Ok(result);
    }

    /// <summary>
    /// Test endpoint to verify API is running
    /// </summary>
    [HttpGet("test")]
    public ActionResult Test()
    {
        return Ok(new { 
            message = "PPSA CRM API is running!", 
            timestamp = DateTime.UtcNow,
            version = "1.0.0"
        });
    }
}