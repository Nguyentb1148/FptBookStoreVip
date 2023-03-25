using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FptBookStore.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Decription { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Double Price { get; set; }
        public DateTime RealeData { get; set; }
        public string Picture { get; set; }
        public string Page { get; set; }

        //Relationships
        public List<DetailOrder> DetailOrders{ get; set; }

        //Category
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]

        public Category Categories { get; set; }

    }
}
