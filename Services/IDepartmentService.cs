using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task<Department> AddAsync(Department department);
        Task<Department?> UpdateAsync(int id, Department department);
        Task<bool> DeleteAsync(int id);
        Task UpdateAsync(int id, DepartmentDto dto);
    }
}
