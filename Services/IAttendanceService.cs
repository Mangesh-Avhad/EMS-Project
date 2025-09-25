using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Services
{
    public interface IAttendanceService
    {
        Task<IEnumerable<Attendance>> GetAllAsync();
        Task<Attendance?> GetByIdAsync(int id);
        Task<Attendance> CreateAsync(Attendance attendance);
        Task<Attendance> UpdateAsync(Attendance attendance);
        Task<bool> DeleteAsync(int id);

        Task<IEnumerable<Attendance>> GetByEmployeeIdAsync(int employeeId);
    }
}
