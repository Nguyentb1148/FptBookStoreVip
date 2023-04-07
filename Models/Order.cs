using System.ComponentModel.DataAnnotations;
namespace FptBookStore.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; set; }
        public User PhoneNumber { get;set; }

        //Relationships
        public List<DetailOrder> DetailOrders { get; set; }
    }
}
