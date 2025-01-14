using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Employee_Management_System
{
    internal class EmployeeModel
    {
        public EmployeeModel() { }
        
        [Required]
        [Range(0, uint.MaxValue)]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public string Designation { get; set; }
        
        [Required]
        public string Department { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter valid EmailID. ")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{8,}$", ErrorMessage = "Please enter valid PhoneNumber. ")]
        public string Phone { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }

        public EmployeeModel(int employeeID, string name, string designation, string department, string email, string phone, DateTime joiningDate)
        {
            EmployeeID = employeeID;
            Name = name;
            Designation = designation;
            Department = department;
            Email = email;
            Phone = phone;
            JoiningDate = joiningDate;
        }





    }
}
