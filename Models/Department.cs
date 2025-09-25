namespace EmployeeManagement.API.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }   // PK, Auto Increment
        public string DeptName { get; set; } = string.Empty;

        // Navigation Property
        public ICollection<Employee>? Employees { get; set; }
    }
}
