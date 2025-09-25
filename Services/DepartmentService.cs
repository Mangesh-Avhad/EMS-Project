using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repo;

        public DepartmentService(IDepartmentRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<Department>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Department?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<Department> CreateAsync(Department department) => _repo.AddAsync(department);
        public Task<Department> UpdateAsync(Department department) => _repo.UpdateAsync(department);
        public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);

        // Implementation for IDepartmentService.AddAsync
        public Task<Department> AddAsync(Department department) => _repo.AddAsync(department);

        public Task<Department?> UpdateAsync(int id, Department department)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, DepartmentDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
