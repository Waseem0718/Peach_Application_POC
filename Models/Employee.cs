using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSearchApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeNumber { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string PositionTitle { get; set; }
        public DateTime DateOfJoining { get; set; }
        public decimal ContractualPay { get; set; }  // Change from string to decimal
        public int ContractualHours { get; set; }    // Change from string to int
        public required string BranchNumber { get; set; }

        public DateTime? TerminationDate { get; set; }

    }
}
