using Data_Access_Layer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DataAccessLayer.Models
{
    public class Enrollments
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int StudentId { get; set; }
        [AllowNull]
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }        
        public int CourseId { get; set; }
        [AllowNull]
        [ForeignKey("CourseId")]
        public Course? Course { get;set; }
    }
}
