using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public long MobileNumber { get; set; }
    }
}
