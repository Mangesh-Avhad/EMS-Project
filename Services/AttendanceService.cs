using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories;

namespace EmployeeManagement.API.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _repo;

        public AttendanceService(IAttendanceRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<Attendance>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Attendance?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<Attendance> CreateAsync(Attendance attendance) => _repo.AddAsync(attendance);
        public Task<Attendance> UpdateAsync(Attendance attendance) => _repo.UpdateAsync(attendance);
        public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);

        public Task<IEnumerable<Attendance>> GetByEmployeeIdAsync(int employeeId) => _repo.GetByEmployeeIdAsync(employeeId);
    }
}
