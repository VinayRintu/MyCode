using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        public string? Emp_Name { get; set; }
    }
}
