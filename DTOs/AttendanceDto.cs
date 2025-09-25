namespace EmployeeManagement.API.DTOs
{
    public class AttendanceDto
    {
        public int AttendanceId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }  // optional for display
    }
}
