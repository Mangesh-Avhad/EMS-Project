using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Repositories
{
    public interface IAttendanceRepository
    {
        Task<IEnumerable<Attendance>> GetAllAsync();
        Task<Attendance?> GetByIdAsync(int id);
        Task<Attendance> AddAsync(Attendance attendance);
        Task<Attendance> UpdateAsync(Attendance attendance);
        Task<bool> DeleteAsync(int id);

        // Extra: Get attendance of a specific employee
        Task<IEnumerable<Attendance>> GetByEmployeeIdAsync(int employeeId);
    }
}
