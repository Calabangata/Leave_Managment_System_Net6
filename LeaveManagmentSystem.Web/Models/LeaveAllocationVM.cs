﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentSystem.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Number of days")]
        [Range(1, 50, ErrorMessage = "Incorrect number!")]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Allocation period")]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}