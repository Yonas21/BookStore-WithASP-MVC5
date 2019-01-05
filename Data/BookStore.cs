using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

    public class BookStore : DbContext
    {
        public BookStore (DbContextOptions<BookStore> options)
            : base(options)
        {
        }

        public DbSet<Bookstore.Models.BookModel> BookModel { get; set; }
    }
