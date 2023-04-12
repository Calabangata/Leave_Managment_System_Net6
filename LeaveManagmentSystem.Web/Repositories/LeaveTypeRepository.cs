using LeaveManagmentSystem.Web.Contracts;
using LeaveManagmentSystem.Web.Data;

namespace LeaveManagmentSystem.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
