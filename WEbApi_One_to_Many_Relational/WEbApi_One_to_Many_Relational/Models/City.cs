using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEbApi_One_to_Many_Relational.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string? CityName { get; set; }
        [ForeignKey("StateId")]
        public int StateId { get; set; }
        public State? State { get; set; }
    }
}
