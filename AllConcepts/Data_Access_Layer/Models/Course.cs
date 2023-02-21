using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string? CourseName { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student? Student { get; set; }
    }
}
