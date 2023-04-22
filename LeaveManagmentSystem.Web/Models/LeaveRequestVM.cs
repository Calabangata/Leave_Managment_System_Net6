using LeaveManagmentSystem.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentSystem.Web.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Date of Request")]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public EmployeeListVM Employee { get; set; }
        public string? RequestingEmployeeId { get; set; }
    }
}
