using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.API.Services;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.Helpers;  // ✅ Import the wrapper

namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentsController(IDepartmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var depts = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<Department>>.Ok(depts));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dept = await _service.GetByIdAsync(id);
            if (dept == null)
                return NotFound(ApiResponse<string>.Fail("Department not found"));

            return Ok(ApiResponse<Department>.Ok(dept));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department department)
        {
            if (!ModelState.IsValid)
                return BadRequest(ApiResponse<string>.Fail("Invalid department data"));

            var created = await _service.AddAsync(department);
            return Ok(ApiResponse<Department>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Department department)
        {
            if (!ModelState.IsValid)
                return BadRequest(ApiResponse<string>.Fail("Invalid department data"));

            var updated = await _service.UpdateAsync(id, department);
            if (updated == null)
                return NotFound(ApiResponse<string>.Fail("Department not found"));

            return Ok(ApiResponse<Department>.Ok(updated));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
                return NotFound(ApiResponse<string>.Fail("Department not found"));

            return Ok(ApiResponse<string>.Ok("Department deleted successfully"));
        }
    }
}
