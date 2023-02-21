using System.ComponentModel.DataAnnotations;

namespace WebApi_With_Ef_CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
