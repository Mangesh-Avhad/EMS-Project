namespace EmployeeManagement.API.Services
{
    public class LoginResponseDto
    {
        public string Token { get; internal set; }
        public string Role { get; internal set; }
    }
}