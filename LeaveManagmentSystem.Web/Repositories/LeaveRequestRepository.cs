using LeaveManagmentSystem.Web.Contracts;
using LeaveManagmentSystem.Web.Data;

namespace LeaveManagmentSystem.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
