namespace EmployeeManagement.API.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }   // PK
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        // Foreign Key
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
