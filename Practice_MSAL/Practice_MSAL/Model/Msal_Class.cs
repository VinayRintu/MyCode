using System.ComponentModel.DataAnnotations;

namespace Practice_MSAL.Model
{
    public class Msal_Class
    {
        [Key]
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }
    }
}
