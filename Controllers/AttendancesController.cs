using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Services;
using AutoMapper;
using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendancesController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;
        private readonly IMapper _mapper;

        public AttendancesController(IAttendanceService attendanceService, IMapper mapper)
        {
            _attendanceService = attendanceService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AttendanceDto>>> GetAll()
        {
            var attendances = await _attendanceService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<AttendanceDto>>(attendances));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceDto>> GetById(int id)
        {
            var attendance = await _attendanceService.GetByIdAsync(id);
            if (attendance == null) return NotFound();

            return Ok(_mapper.Map<AttendanceDto>(attendance));
        }

        [HttpPost]
        public async Task<ActionResult<AttendanceDto>> Create(AttendanceDto dto)
        {
            var attendance = _mapper.Map<Attendance>(dto);
            await _attendanceService.CreateAsync(attendance); // Updated method name

            return CreatedAtAction(nameof(GetById), new { id = attendance.AttendanceId }, _mapper.Map<AttendanceDto>(attendance));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AttendanceDto dto)
        {
            if (id != dto.AttendanceId) return BadRequest();

            var attendance = _mapper.Map<Attendance>(dto);
            await _attendanceService.UpdateAsync(attendance);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _attendanceService.DeleteAsync(id);
            return NoContent();
        }
    }
}
