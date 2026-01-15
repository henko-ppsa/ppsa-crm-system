using PPSA.CRM.Core.DTOs;

namespace PPSA.CRM.Core.Interfaces;

public interface IAuthService
{
    Task<LoginResponse> LoginAsync(LoginRequest request);
    Task<LoginResponse> RefreshTokenAsync(string refreshToken);
    Task RevokeRefreshTokenAsync(string refreshToken);
    Task<UserDto?> GetUserByIdAsync(int userId);
}