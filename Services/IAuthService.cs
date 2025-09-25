using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Services
{
    public interface IAuthService
    {
        Task<string> GenerateJwtToken(User user);
        Task<User> RegisterAsync(RegisterDto dto);
        Task<string?> LoginAsync(LoginDto dto);
    }
}
