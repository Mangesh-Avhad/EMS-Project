using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories;

namespace EmployeeManagement.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<Employee>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Employee?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<Employee> CreateAsync(Employee employee) => _repo.AddAsync(employee);
        public Task<Employee> UpdateAsync(Employee employee) => _repo.UpdateAsync(employee);
        public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
}
