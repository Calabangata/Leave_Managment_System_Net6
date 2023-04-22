using LeaveManagmentSystem.Web.Data;
using LeaveManagmentSystem.Web.Models;

namespace LeaveManagmentSystem.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);

        Task<EmployeeLeaveRequestsVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminViewLeaveRequestsVM> GetAdminViewLeaveRequestsList();
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task CancelLeaveRequest(int leaveRequestId);
    }
}
