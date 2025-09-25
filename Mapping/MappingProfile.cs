using AutoMapper;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.DTOs;

namespace EmployeeManagement.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Department
            CreateMap<Department, DepartmentDto>()
                .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.Employees));

            CreateMap<DepartmentDto, Department>();

            // Employee
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DeptName));

            CreateMap<EmployeeDto, Employee>();

            // Attendance
            CreateMap<Attendance, AttendanceDto>()
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Employee.Name));

            CreateMap<AttendanceDto, Attendance>();

            // User
            CreateMap<User, RegisterDto>().ReverseMap();
            CreateMap<User, LoginDto>().ReverseMap();
        }
    }
}
