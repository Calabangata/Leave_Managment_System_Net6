using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentSystem.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name = "First name")]
        public string Firstname { get; set; }

        [Display(Name = "Last name")]
        public string Lastname { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Date Joined")]
        public string DateJoined { get; set; }
    }
}
