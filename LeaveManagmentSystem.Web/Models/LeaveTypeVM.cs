using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentSystem.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Type of Leave")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 35, ErrorMessage = "Please enter a number between 1 and 35!")]
        public int DefaultDays { get; set; }
    }
}
