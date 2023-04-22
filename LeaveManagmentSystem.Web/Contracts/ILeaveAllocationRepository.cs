using LeaveManagmentSystem.Web.Data;
using LeaveManagmentSystem.Web.Models;

namespace LeaveManagmentSystem.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);

        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);
        Task<LeaveAllocationEditVM> GetEmpAllocation(int id);
        Task<bool> UpdateEmpAllocation(LeaveAllocationEditVM model);
    }
}
