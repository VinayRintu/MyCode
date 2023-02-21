using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatesWebAPI.Models
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateId { get; set; }
        public string? StateName { get; set; }
        public string? Capital { get; set; }
        public string? CM { get; set; }
        public DateTime FormationDay { get; set; }
    }
}
