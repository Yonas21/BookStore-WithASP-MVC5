using System;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class BookModel
    {
        public int ID { get; set; }
        public string author { get; set; }

        [DataType(DataType.Date)]
        public DateTime releaseDate { get; set; }

        public decimal price { get; set; }
    }
}