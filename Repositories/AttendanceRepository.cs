using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly EMSContext _context;

        public AttendanceRepository(EMSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Attendance>> GetAllAsync()
        {
            return await _context.Attendances
                                 .Include(a => a.Employee)
                                 .ToListAsync();
        }

        public async Task<Attendance?> GetByIdAsync(int id)
        {
            return await _context.Attendances
                                 .Include(a => a.Employee)
                                 .FirstOrDefaultAsync(a => a.AttendanceId == id);
        }

        public async Task<Attendance> AddAsync(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
            await _context.SaveChangesAsync();
            return attendance;
        }

        public async Task<Attendance> UpdateAsync(Attendance attendance)
        {
            _context.Attendances.Update(attendance);
            await _context.SaveChangesAsync();
            return attendance;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var att = await _context.Attendances.FindAsync(id);
            if (att == null) return false;

            _context.Attendances.Remove(att);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Attendance>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _context.Attendances
                                 .Where(a => a.EmployeeId == employeeId)
                                 .Include(a => a.Employee)
                                 .ToListAsync();
        }
    }
}
