namespace EmployeeManagement.API.DTOs
{
    public class RegisterDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // ✅ Role field
        public string Role { get; set; } = "Employee";
    }
}

