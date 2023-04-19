﻿using LeaveManagmentSystem.Web.Data;
using LeaveManagmentSystem.Web.Models;

namespace LeaveManagmentSystem.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);

        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmpAllocation(int id);
    }
}
