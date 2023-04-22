using LeaveManagmentSystem.Web.Data;
using LeaveManagmentSystem.Web.Models;

namespace LeaveManagmentSystem.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);

        Task<EmployeeLeaveRequestsVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminViewLeaveRequestsVM> GetAdminViewLeaveRequestsList();
    }
}
