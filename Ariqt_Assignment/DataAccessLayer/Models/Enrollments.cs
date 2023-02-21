using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Enrollments
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int E_StudentID { get; set; }
        //[JsonIgnore]
        [AllowNull]
        [ForeignKey("E_StudentID")]
        public virtual Student? Student { get; set; }
        public int E_CourseID { get; set; }
        //[JsonIgnore]
        [ForeignKey("E_CourseID")]
        [AllowNull]
        public virtual Course? Course { get; set; }
    }
}
