using System.ComponentModel.DataAnnotations;

namespace WEbApi_One_to_Many_Relational.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string? StateName { get; set; }
    }
}
