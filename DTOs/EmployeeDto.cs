namespace EmployeeManagement.API.DTOs
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }  // useful for displaying dept name

        // Optional: Attendance info
        public List<AttendanceDto>? Attendances { get; set; }
    }
}
