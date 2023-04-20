using AutoMapper;
using LeaveManagmentSystem.Web.Data;
using LeaveManagmentSystem.Web.Models;

namespace LeaveManagmentSystem.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();

            CreateMap<Employee, EmployeeListVM>().ReverseMap();

            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();

            CreateMap<LeaveRequest, LeaveRequestCreateVM>().ReverseMap();

            CreateMap<LeaveRequest, LeaveRequestVM>().ReverseMap();
        }
    }
}
