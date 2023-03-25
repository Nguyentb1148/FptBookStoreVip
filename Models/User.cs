using System.ComponentModel.DataAnnotations;

namespace FptBookStore.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }

     
        // Relationships
        public List<Order> Orders { get; set; }
    }
}
