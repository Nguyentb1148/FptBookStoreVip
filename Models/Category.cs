
using System.ComponentModel.DataAnnotations;

namespace FptBookStore.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Book> Books { get; set; }

        //Book


    }
}
