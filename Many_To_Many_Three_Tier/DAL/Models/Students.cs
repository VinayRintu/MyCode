using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int Standard { get; set; }
        public virtual ICollection<Enrollments>? Enrollments { get; set; }
    }
}
