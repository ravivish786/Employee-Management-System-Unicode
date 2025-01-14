using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Employee_Management_System
{
    internal class EmployeeModel
    {
        public EmployeeModel() { }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
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
