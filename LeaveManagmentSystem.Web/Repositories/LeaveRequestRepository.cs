using AutoMapper;
using LeaveManagmentSystem.Web.Contracts;
using LeaveManagmentSystem.Web.Data;
using LeaveManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagmentSystem.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccesor;
        private readonly UserManager<Employee> userManager;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper,
            IHttpContextAccessor httpContext, UserManager<Employee> userManager) : base(context)
        {
            this.mapper = mapper;
            this.httpContextAccesor = httpContext;
            this.userManager = userManager;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccesor?.HttpContext?.User);

            var leaveRequest = mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;
            await AddAsync(leaveRequest);
        }
    }
}
