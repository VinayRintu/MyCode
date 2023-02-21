using System.ComponentModel.DataAnnotations;

namespace Key_Vault.Models
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }
        public string? CustName { get; set; }
        public int MobileNumber { get; set; }
        public string? Email { get; set; }
    }
}
