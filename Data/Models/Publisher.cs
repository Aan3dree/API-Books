using System.Collections.Generic;

namespace BooksApi.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public int Name { get; set; }

        //Navigation Properties
        public List<Book> Books { get; set; }
    }
}