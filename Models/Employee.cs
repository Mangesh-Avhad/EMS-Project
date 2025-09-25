namespace EmployeeManagement.API.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }   // PK
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        // Navigation
        public ICollection<Attendance>? Attendances { get; set; }
    }
}
