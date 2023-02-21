using System;                                      
using System.Collections.Generic;                  
using System.ComponentModel.DataAnnotations;       
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;                                 
using System.Text;                                
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string? CourseName { get; set; }
    }
}
