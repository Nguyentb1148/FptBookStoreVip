using System.ComponentModel.DataAnnotations;

namespace FptBookStore.Models
{
    public class DetailOrder
    {
     
        public int DetailOrderID { get; set; }
        public int BookID { get; set; }
        public int OrderID { get; set; }
        public Book Book { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }

        //Book
        

    }
}
